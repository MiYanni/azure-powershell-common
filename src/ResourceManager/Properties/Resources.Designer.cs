﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Common.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.ResourceManager.Common.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure PowerShell collects usage data in order to improve your experience.
        ///The data is anonymous and does not include commandline argument values.
        ///The data is collected by Microsoft.
        ///
        ///Use the Disable-AzDataCollection cmdlet to turn the feature Off. The cmdlet can be found in the Az.Accounts module. To disable data collection: PS &gt; Disable-AzDataCollection.
        ///Use the Enable-AzDataCollection cmdlet to turn the feature On. The cmdlet can be found in the Az.Accounts module. To enable  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ARMDataCollectionMessage {
            get {
                return ResourceManager.GetString("ARMDataCollectionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not remove tag/tag value because it&apos;s being referenced by other resources..
        /// </summary>
        public static string CanNotDeleteTag {
            get {
                return ResourceManager.GetString("CanNotDeleteTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context cannot be null.  Please log in using Connect-AzureRmAccount..
        /// </summary>
        public static string ContextCannotBeNull {
            get {
                return ResourceManager.GetString("ContextCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Azure PowerShell Data Collection Confirmation.
        /// </summary>
        public static string DataCollectionActivity {
            get {
                return ResourceManager.GetString("DataCollectionActivity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You choose not to participate in Microsoft Azure PowerShell data collection..
        /// </summary>
        public static string DataCollectionConfirmNo {
            get {
                return ResourceManager.GetString("DataCollectionConfirmNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This confirmation message will be dismissed in &apos;{0}&apos; second(s)....
        /// </summary>
        public static string DataCollectionConfirmTime {
            get {
                return ResourceManager.GetString("DataCollectionConfirmTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You choose to participate in Microsoft Azure PowerShell data collection..
        /// </summary>
        public static string DataCollectionConfirmYes {
            get {
                return ResourceManager.GetString("DataCollectionConfirmYes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The setting profile has been saved to the following path &apos;{0}&apos;..
        /// </summary>
        public static string DataCollectionSaveFileInformation {
            get {
                return ResourceManager.GetString("DataCollectionSaveFileInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default Resource Group.
        /// </summary>
        public static string DefaultResourceGroupKey {
            get {
                return ResourceManager.GetString("DefaultResourceGroupKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Select-AzureSubscription -Default &lt;subscriptionName&gt; to set the default subscription..
        /// </summary>
        public static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ResourceType name: &apos;{0}&apos; is invalid..
        /// </summary>
        public static string InvalidResourceType {
            get {
                return ResourceManager.GetString("InvalidResourceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tag format. Expect @{tagName = $null} or @{tagName = &quot;tagValue&quot;}.
        /// </summary>
        public static string InvalidTagFormat {
            get {
                return ResourceManager.GetString("InvalidTagFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided account {0} does not have access to any subscriptions. Please try logging in with different credentials..
        /// </summary>
        public static string NoSubscriptionFound {
            get {
                return ResourceManager.GetString("NoSubscriptionFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No locations exist for all of the given ResourceTypes..
        /// </summary>
        public static string NoValidLocationsFound {
            get {
                return ResourceManager.GetString("NoValidLocationsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid ResourceType given to LocationCompleter..
        /// </summary>
        public static string NoValidProviderFound {
            get {
                return ResourceManager.GetString("NoValidProviderFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile cannot be null.  Please run Connect-AzureRmAccount..
        /// </summary>
        public static string ProfileCannotBeNull {
            get {
                return ResourceManager.GetString("ProfileCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure PowerShell context has not been properly initialized.  Please import the module and try again..
        /// </summary>
        public static string ProfileNotInitialized {
            get {
                return ResourceManager.GetString("ProfileNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure PowerShell collects usage data in order to improve your experience.
        ///The data is anonymous and does not include commandline argument values.
        ///The data is collected by Microsoft.
        ///
        ///Use the Disable-AzureDataCollection cmdlet to turn the feature Off. The cmdlet can be found in the Azure module.  To disable data collection: PS &gt; Disable-AzureDataCollection.
        ///Use the Enable-AzureDataCollection cmdlet to turn the feature On. The cmdlet can be found in the Azure module.  To enable data collection: PS &gt; Enab [rest of string was truncated]&quot;;.
        /// </summary>
        public static string RDFEDataCollectionMessage {
            get {
                return ResourceManager.GetString("RDFEDataCollectionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing tag .....
        /// </summary>
        public static string RemoveTagMessage {
            get {
                return ResourceManager.GetString("RemoveTagMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove tag &apos;{0}&apos;.
        /// </summary>
        public static string RemovingTag {
            get {
                return ResourceManager.GetString("RemovingTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the &apos;{0}&apos; resource named &apos;{1}&apos; in resource group &apos;{2}&apos;.
        /// </summary>
        public static string ResourceConfirmTarget {
            get {
                return ResourceManager.GetString("ResourceConfirmTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the resource with identity &apos;{0}&apos;.
        /// </summary>
        public static string ResourceIdConfirmTarget {
            get {
                return ResourceManager.GetString("ResourceIdConfirmTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to register resource provider &apos;{0}&apos;.
        /// </summary>
        public static string ResourceProviderRegisterAttempt {
            get {
                return ResourceManager.GetString("ResourceProviderRegisterAttempt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to register resource provider &apos;{0}&apos;.Details: &apos;{1}&apos;.
        /// </summary>
        public static string ResourceProviderRegisterFailure {
            get {
                return ResourceManager.GetString("ResourceProviderRegisterFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Succeeded to register resource provider &apos;{0}&apos;.
        /// </summary>
        public static string ResourceProviderRegisterSuccessful {
            get {
                return ResourceManager.GetString("ResourceProviderRegisterSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run Connect-AzureRmAccount to login..
        /// </summary>
        public static string RunConnectAccount {
            get {
                return ResourceManager.GetString("RunConnectAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided account {0} does not have access to subscription ID &quot;{1}&quot;. Please try logging in with different credentials or a different subscription ID..
        /// </summary>
        public static string SubscriptionIdNotFound {
            get {
                return ResourceManager.GetString("SubscriptionIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided account {0} does not have access to subscription name &quot;{1}&quot;. Please try logging in with different credentials or a different subscription name..
        /// </summary>
        public static string SubscriptionNameNotFound {
            get {
                return ResourceManager.GetString("SubscriptionNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tag &apos;{0}&apos; not found.
        /// </summary>
        public static string TagNotFoundMessage {
            get {
                return ResourceManager.GetString("TagNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tenant &apos;{0}&apos; was not found. Please verify that your account has access to this tenant..
        /// </summary>
        public static string TenantNotFound {
            get {
                return ResourceManager.GetString("TenantNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider.List() timed out. Please retry..
        /// </summary>
        public static string TimeOutForProviderList {
            get {
                return ResourceManager.GetString("TimeOutForProviderList", resourceCulture);
            }
        }
    }
}
