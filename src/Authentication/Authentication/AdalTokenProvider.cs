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
using Microsoft.Azure.Commands.Common.Authentication.Models;
using System;
using System.Security;
using Microsoft.Azure.Commands.Common.Authentication.Properties;

#if !NETSTANDARD
using System.Windows.Forms;
#endif

namespace Microsoft.Azure.Commands.Common.Authentication
{
    /// <summary>
    /// A token provider that uses ADAL to retrieve
    /// tokens from Azure Active Directory
    /// </summary>
    public class AdalTokenProvider : ITokenProvider
    {
        private readonly ITokenProvider userTokenProvider;
        private readonly ITokenProvider servicePrincipalTokenProvider;
#if !NETSTANDARD
        public AdalTokenProvider()
            : this(new ConsoleParentWindow())
        {
        }

        public AdalTokenProvider(IWin32Window parentWindow)
        {
            this.userTokenProvider = new UserTokenProvider(parentWindow);
            this.servicePrincipalTokenProvider = new ServicePrincipalTokenProvider();
        }

        public AdalTokenProvider(Func<IServicePrincipalKeyStore> getKeyStore)
        {
            this.userTokenProvider = new UserTokenProvider(new ConsoleParentWindow());
            this.servicePrincipalTokenProvider = new ServicePrincipalTokenProvider(getKeyStore);
        }

        public IAccessToken GetAccessToken(
            AdalConfiguration config,
            string promptBehavior,
            Action<string> promptAction,
            string userId,
            SecureString password,
            string credentialType)
        {
            switch (credentialType)
            {
                case AzureAccount.AccountType.User:
                    return userTokenProvider.GetAccessToken(config, promptBehavior, promptAction, userId, password, credentialType);
                case AzureAccount.AccountType.ServicePrincipal:
                    return servicePrincipalTokenProvider.GetAccessToken(config, promptBehavior, promptAction, userId, password, credentialType);
                default:
                    throw new ArgumentException(Resources.UnknownCredentialType, "credentialType");
            }
        }

        public IAccessToken GetAccessTokenWithCertificate(
            AdalConfiguration config,
            string clientId,
            string certificate,
            string credentialType)
        {
            switch (credentialType)
            {
                case AzureAccount.AccountType.ServicePrincipal:
                    return servicePrincipalTokenProvider.GetAccessTokenWithCertificate(config, clientId, certificate, credentialType);
                default:
                    throw new ArgumentException(string.Format(Resources.UnsupportedCredentialType, credentialType), "credentialType");
            }
        }
#else
        public AdalTokenProvider()
        {
            this.userTokenProvider = new UserTokenProvider();
            this.servicePrincipalTokenProvider = new ServicePrincipalTokenProvider();
        }

        public AdalTokenProvider(Func<IServicePrincipalKeyStore> getKeyStore)
        {
            this.userTokenProvider = new UserTokenProvider();
            this.servicePrincipalTokenProvider = new ServicePrincipalTokenProvider(getKeyStore);
        }

        public IAccessToken GetAccessToken(
            AdalConfiguration config,
            string promptBehavior,
            Action<string> promptAction,
            string userId,
            SecureString password,
            string credentialType)
        {
            switch (credentialType)
            {
                case AzureAccount.AccountType.User:
                    return userTokenProvider.GetAccessToken(
                        config,
                        promptBehavior,
                        promptAction,
                        userId,
                        password,
                        credentialType);
                case AzureAccount.AccountType.ServicePrincipal:
                    return servicePrincipalTokenProvider.GetAccessToken(
                        config,
                        promptBehavior,
                        promptAction,
                        userId,
                        password,
                        credentialType);
                default:
                    throw new ArgumentException(Resources.UnsupportedCredentialType, "credentialType");
            }
        }

        public IAccessToken GetAccessTokenWithCertificate(
            AdalConfiguration config,
            string clientId,
            string certificate,
            string credentialType)
        {
            switch (credentialType)
            {
                case AzureAccount.AccountType.ServicePrincipal:
                    return servicePrincipalTokenProvider.GetAccessTokenWithCertificate(config, clientId, certificate, credentialType);
                default:
                    throw new ArgumentException(string.Format(Resources.UnsupportedCredentialType, credentialType), "credentialType");
            }
        }
#endif

    }
}
