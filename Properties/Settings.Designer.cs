﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandBrake_Encoder.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\HandBrake\\HandBrakeCLI.exe")]
        public string HandBrakeCLILocation {
            get {
                return ((string)(this["HandBrakeCLILocation"]));
            }
            set {
                this["HandBrakeCLILocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-t 1 -c 1 -f mp4 -X 480 -e x264 -q 20 -a 1 -E faac -6 auto -R Auto -B 96 -D 0 -x " +
            "cabac=0:ref=2:me=umh:bframes=3:subq=6:8x8dct=0:trellis=0:weightb=0:merange=24 -v" +
            " 1")]
        public string HandBrakeCMD {
            get {
                return ((string)(this["HandBrakeCMD"]));
            }
            set {
                this["HandBrakeCMD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultEncodeLocation {
            get {
                return ((string)(this["DefaultEncodeLocation"]));
            }
            set {
                this["DefaultEncodeLocation"] = value;
            }
        }
    }
}
