﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSettings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
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
        [global::System.Configuration.DefaultSettingValueAttribute("")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public short LAST_GAME {
            get {
                return ((short)(this["LAST_GAME"]));
            }
            set {
                this["LAST_GAME"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CHECKBOX_MINIMIZE_TRAY {
            get {
                return ((bool)(this["CHECKBOX_MINIMIZE_TRAY"]));
            }
            set {
                this["CHECKBOX_MINIMIZE_TRAY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FIRSTRUN {
            get {
                return ((bool)(this["FIRSTRUN"]));
            }
            set {
                this["FIRSTRUN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CHECKBOX_BACKGROUND {
            get {
                return ((bool)(this["CHECKBOX_BACKGROUND"]));
            }
            set {
                this["CHECKBOX_BACKGROUND"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CHECKBOX_LASTGAME {
            get {
                return ((bool)(this["CHECKBOX_LASTGAME"]));
            }
            set {
                this["CHECKBOX_LASTGAME"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://sdk-os-static.mihoyo.com/bh3_global/mdk/launcher/api/resource?launcher_id" +
            "=10")]
        public string HI3_VERSION_API {
            get {
                return ((string)(this["HI3_VERSION_API"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://sdk-os-static.mihoyo.com/hk4e_global/mdk/launcher/api/resource?launcher_i" +
            "d=10&key=gcStgarh")]
        public string GENSHIN_VERSION_API {
            get {
                return ((string)(this["GENSHIN_VERSION_API"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://hkrpg-launcher-static.hoyoverse.com/hkrpg_global/mdk/launcher/api/resourc" +
            "e?launcher_id=35&key=vplOVX8Vn7cwG8yb")]
        public string HSR_VERSION_API {
            get {
                return ((string)(this["HSR_VERSION_API"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://sdk-os-static.mihoyo.com/bh3_global/mdk/launcher/api/content?filter_adv=t" +
            "rue&language=en-us&launcher_id=10")]
        public string HI3_CONTENT_API {
            get {
                return ((string)(this["HI3_CONTENT_API"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://sdk-os-static.mihoyo.com/hk4e_global/mdk/launcher/api/content?filter_adv=" +
            "true&language=en-us&launcher_id=10&key=gcStgarh")]
        public string GENSHIN_CONTENT_API {
            get {
                return ((string)(this["GENSHIN_CONTENT_API"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://hkrpg-launcher-static.hoyoverse.com/hkrpg_global/mdk/launcher/api/content" +
            "?filter_adv=true&language=en-us&launcher_id=35&key=vplOVX8Vn7cwG8yb")]
        public string HSR_CONTENT_API {
            get {
                return ((string)(this["HSR_CONTENT_API"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CHECKBOX_TITLE {
            get {
                return ((bool)(this["CHECKBOX_TITLE"]));
            }
            set {
                this["CHECKBOX_TITLE"] = value;
            }
        }
    }
}
