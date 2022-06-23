﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Diagnostics.Monitoring.WebApi {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Diagnostics.Monitoring.WebApi.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get process environment..
        /// </summary>
        internal static string ErrorMessage_CanNotGetEnvironment {
            get {
                return ResourceManager.GetString("ErrorMessage_CanNotGetEnvironment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP egress is not enabled..
        /// </summary>
        internal static string ErrorMessage_HttpEgressDisabled {
            get {
                return ResourceManager.GetString("ErrorMessage_HttpEgressDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid metric count..
        /// </summary>
        internal static string ErrorMessage_InvalidMetricCount {
            get {
                return ResourceManager.GetString("ErrorMessage_InvalidMetricCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom trace metric provider &apos;{0}&apos; must use the global counter interval &apos;{1}&apos;.
        /// </summary>
        internal static string ErrorMessage_InvalidMetricInterval {
            get {
                return ResourceManager.GetString("ErrorMessage_InvalidMetricInterval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metrics was not enabled..
        /// </summary>
        internal static string ErrorMessage_MetricsDisabled {
            get {
                return ResourceManager.GetString("ErrorMessage_MetricsDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to select a single target process because multiple target processes have been discovered..
        /// </summary>
        internal static string ErrorMessage_MultipleTargetProcesses {
            get {
                return ResourceManager.GetString("ErrorMessage_MultipleTargetProcesses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default process configuration has been set..
        /// </summary>
        internal static string ErrorMessage_NoDefaultProcessConfig {
            get {
                return ResourceManager.GetString("ErrorMessage_NoDefaultProcessConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to discover a target process..
        /// </summary>
        internal static string ErrorMessage_NoTargetProcess {
            get {
                return ResourceManager.GetString("ErrorMessage_NoTargetProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation not found..
        /// </summary>
        internal static string ErrorMessage_OperationNotFound {
            get {
                return ResourceManager.GetString("ErrorMessage_OperationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation is not running..
        /// </summary>
        internal static string ErrorMessage_OperationNotRunning {
            get {
                return ResourceManager.GetString("ErrorMessage_OperationNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to enumerate processes..
        /// </summary>
        internal static string ErrorMessage_ProcessEnumeratuinFailed {
            get {
                return ResourceManager.GetString("ErrorMessage_ProcessEnumeratuinFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rate limit reached..
        /// </summary>
        internal static string ErrorMessage_TooManyRequests {
            get {
                return ResourceManager.GetString("ErrorMessage_TooManyRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected limit key: &apos;{0}&apos;.
        /// </summary>
        internal static string ErrorMessage_UnexpectedLimitKey {
            get {
                return ResourceManager.GetString("ErrorMessage_UnexpectedLimitKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected {0}: {1}.
        /// </summary>
        internal static string ErrorMessage_UnexpectedType {
            get {
                return ResourceManager.GetString("ErrorMessage_UnexpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null, empty, or whitespace..
        /// </summary>
        internal static string ErrorMessage_ValueEmptyNullWhitespace {
            get {
                return ResourceManager.GetString("ErrorMessage_ValueEmptyNullWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not a valid hexadecimal number..
        /// </summary>
        internal static string ErrorMessage_ValueNotHex {
            get {
                return ResourceManager.GetString("ErrorMessage_ValueNotHex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not a valid integer..
        /// </summary>
        internal static string ErrorMessage_ValueNotInt {
            get {
                return ResourceManager.GetString("ErrorMessage_ValueNotInt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be of type string..
        /// </summary>
        internal static string ErrorMessage_ValueNotString {
            get {
                return ResourceManager.GetString("ErrorMessage_ValueNotString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to determine the default process..
        /// </summary>
        internal static string LogFormatString_DefaultProcessUnexpectedFailure {
            get {
                return ResourceManager.GetString("LogFormatString_DefaultProcessUnexpectedFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Egressed artifact to {location}.
        /// </summary>
        internal static string LogFormatString_EgressedArtifact {
            get {
                return ResourceManager.GetString("LogFormatString_EgressedArtifact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request canceled..
        /// </summary>
        internal static string LogFormatString_RequestCanceled {
            get {
                return ResourceManager.GetString("LogFormatString_RequestCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request failed..
        /// </summary>
        internal static string LogFormatString_RequestFailed {
            get {
                return ResourceManager.GetString("LogFormatString_RequestFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolved target process..
        /// </summary>
        internal static string LogFormatString_ResolvedTargetProcess {
            get {
                return ResourceManager.GetString("LogFormatString_ResolvedTargetProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request limit for endpoint reached. Limit: {limit}, oustanding requests: {requests}.
        /// </summary>
        internal static string LogFormatString_ThrottledEndpoint {
            get {
                return ResourceManager.GetString("LogFormatString_ThrottledEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Written to HTTP stream..
        /// </summary>
        internal static string LogFormatString_WrittenToHttpStream {
            get {
                return ResourceManager.GetString("LogFormatString_WrittenToHttpStream", resourceCulture);
            }
        }
    }
}
