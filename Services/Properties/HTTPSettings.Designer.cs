﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clickatell.Services.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class HTTPSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static HTTPSettings defaultInstance = ((HTTPSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new HTTPSettings())));
        
        public static HTTPSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/http/auth")]
        public string AuthenticateURL {
            get {
                return ((string)(this["AuthenticateURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/http/sendmsg")]
        public string SendMessageURL {
            get {
                return ((string)(this["SendMessageURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/http/getbalance")]
        public string BalanceURL {
            get {
                return ((string)(this["BalanceURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/utils/routeCoverage.php")]
        public string CoverageURL {
            get {
                return ((string)(this["CoverageURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/http/delmsg")]
        public string StopMessageURL {
            get {
                return ((string)(this["StopMessageURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/http/getmsgcharge")]
        public string MessageChargeURL {
            get {
                return ((string)(this["MessageChargeURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://api.clickatell.com/http/querymsg")]
        public string MessageStatusURL {
            get {
                return ((string)(this["MessageStatusURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("user")]
        public string QueryString_User {
            get {
                return ((string)(this["QueryString_User"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("password")]
        public string QueryString_Password {
            get {
                return ((string)(this["QueryString_Password"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("api_id")]
        public string QueryString_ApiId {
            get {
                return ((string)(this["QueryString_ApiId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("to")]
        public string QueryString_To {
            get {
                return ((string)(this["QueryString_To"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("text")]
        public string QueryString_Text {
            get {
                return ((string)(this["QueryString_Text"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("apimsgid")]
        public string QueryString_ApiMsgId {
            get {
                return ((string)(this["QueryString_ApiMsgId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("msisdn")]
        public string QueryString_MSISDN {
            get {
                return ((string)(this["QueryString_MSISDN"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0},")]
        public string PhoneNumberFormat {
            get {
                return ((string)(this["PhoneNumberFormat"]));
            }
        }
    }
}
