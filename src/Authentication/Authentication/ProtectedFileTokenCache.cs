﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Properties;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.IO;
using System.Security.Cryptography;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    /// <summary>
    /// An implementation of the Adal token cache that stores the cache items
    /// in the DPAPI-protected file.
    /// </summary>
    public class ProtectedFileTokenCache : TokenCache, IAzureTokenCache
    {
        private static readonly string CacheFileName = Path.Combine(
// TODO: Remove IfDef
#if NETSTANDARD
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                Resources.AzureDirectoryName,
#else
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                Resources.OldAzureDirectoryName,
#endif
                 "TokenCache.dat");

        private static readonly object FileLock = new object();

        private readonly IDataStore _store;

        public byte[] CacheData
        {
            get
            {
                return Serialize();
            }

            set
            {
                Deserialize(value);
                HasStateChanged = true;
                EnsureStateSaved();
            }
        }

        // Initializes the cache against a local file.
        // If the file is already present, it loads its content in the ADAL cache
        private ProtectedFileTokenCache()
        {
            _store = AzureSession.Instance.DataStore;
            Initialize(CacheFileName);
        }

        public ProtectedFileTokenCache(byte[] inputData, IDataStore store = null) : this(CacheFileName, store)
        {
            CacheData = inputData;
        }

        public ProtectedFileTokenCache(string cacheFile, IDataStore store = null)
        {
            _store = store ?? AzureSession.Instance.DataStore;
            Initialize(cacheFile);
        }

        private void Initialize(string fileName)
        {
            EnsureCacheFile(fileName);

            AfterAccess = AfterAccessNotification;
            BeforeAccess = BeforeAccessNotification;
        }

        // Empties the persistent store.
        public override void Clear()
        {
            base.Clear();
            if (_store.FileExists(CacheFileName))
            {
                _store.DeleteFile(CacheFileName);
            }
        }

        // Triggered right before ADAL needs to access the cache.
        // Reload the cache from the persistent store in case it changed since the last access.
        private void BeforeAccessNotification(TokenCacheNotificationArgs args)
        {
            ReadFileIntoCache();
        }

        // Triggered right after ADAL accessed the cache.
        private void AfterAccessNotification(TokenCacheNotificationArgs args)
        {
            // if the access operation resulted in a cache update
            EnsureStateSaved();
        }

        private void EnsureStateSaved()
        {
            if (HasStateChanged)
            {
                WriteCacheIntoFile();
            }
        }

        private void ReadFileIntoCache(string cacheFileName = null)
        {
            if(cacheFileName == null)
            {
                cacheFileName = CacheFileName;
            }

            lock (FileLock)
            {
                if (!_store.FileExists(cacheFileName)) return;

                var existingData = _store.ReadFileAsBytes(cacheFileName);
                if (existingData != null)
                {
// TODO: Remove IfDef
#if NETSTANDARD
                    Deserialize(existingData);
#else
                    try
                    {
                        Deserialize(ProtectedData.Unprotect(existingData, null, DataProtectionScope.CurrentUser));
                    }
                    catch (CryptographicException)
                    {
                        _store.DeleteFile(cacheFileName);
                    }
#endif
                }
            }
        }

        private void WriteCacheIntoFile(string cacheFileName = null)
        {
            if(cacheFileName == null)
            {
                cacheFileName = CacheFileName;
            }
// TODO: Remove IfDef
#if NETSTANDARD
            var dataToWrite = Serialize();
#else
            var dataToWrite = ProtectedData.Protect(Serialize(), null, DataProtectionScope.CurrentUser);
#endif

            lock (FileLock)
            {
                if (!HasStateChanged) return;

                _store.WriteFile(cacheFileName, dataToWrite);
                HasStateChanged =  false;
            }
        }

        private void EnsureCacheFile(string cacheFileName = null)
        {
            lock (FileLock)
            {
                if (_store.FileExists(cacheFileName))
                {
                    var existingData = _store.ReadFileAsBytes(cacheFileName);
                    if (existingData != null)
                    {
// TODO: Remove IfDef
#if NETSTANDARD
                        Deserialize(existingData);
#else
                        try
                        {
                            Deserialize(ProtectedData.Unprotect(existingData, null, DataProtectionScope.CurrentUser));
                        }
                        catch (CryptographicException)
                        {
                            _store.DeleteFile(cacheFileName);
                        }
#endif
                    }
                }

                // Eagerly create cache file.
// TODO: Remove IfDef
#if NETSTANDARD
                var dataToWrite = Serialize();
#else
                var dataToWrite = ProtectedData.Protect(Serialize(), null, DataProtectionScope.CurrentUser);
#endif
                _store.WriteFile(cacheFileName, dataToWrite);
            }
        }
    }
}
