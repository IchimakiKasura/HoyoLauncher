﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HoyoLauncherProject.Core.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class HoyoLauncher : global::System.Configuration.ApplicationSettingsBase {
        
        private static HoyoLauncher defaultInstance = ((HoyoLauncher)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new HoyoLauncher())));
        
        public static HoyoLauncher Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HONKAI_IMPACT_THIRD_DIR {
            get {
                return ((string)(this["HONKAI_IMPACT_THIRD_DIR"]));
            }
            set {
                this["HONKAI_IMPACT_THIRD_DIR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("H:\\\\Genshin Impact")]
        public string GENSHIN_IMPACT_DIR {
            get {
                return ((string)(this["GENSHIN_IMPACT_DIR"]));
            }
            set {
                this["GENSHIN_IMPACT_DIR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("H:\\\\Star Rail")]
        public string HONKAI_STAR_RAIL_DIR {
            get {
                return ((string)(this["HONKAI_STAR_RAIL_DIR"]));
            }
            set {
                this["HONKAI_STAR_RAIL_DIR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ZENLESS_ZONE_ZERO_DIR {
            get {
                return ((string)(this["ZENLESS_ZONE_ZERO_DIR"]));
            }
            set {
                this["ZENLESS_ZONE_ZERO_DIR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CURRENT_SELECTED {
            get {
                return ((string)(this["CURRENT_SELECTED"]));
            }
            set {
                this["CURRENT_SELECTED"] = value;
            }
        }
    }
}
