﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamSchedule.GUI.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Documents\\Visual Studio 2013\\Projects\\DoAn1\\data\\DS_SV.xlsx")]
        public string studentPath {
            get {
                return ((string)(this["studentPath"]));
            }
            set {
                this["studentPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Documents\\Visual Studio 2013\\Projects\\DoAn2\\data\\DS_MON.xlsx")]
        public string coursePath {
            get {
                return ((string)(this["coursePath"]));
            }
            set {
                this["coursePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Documents\\Visual Studio 2013\\Projects\\DoAn2\\data\\DS_PHONG.xlsx")]
        public string roomPath {
            get {
                return ((string)(this["roomPath"]));
            }
            set {
                this["roomPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Documents\\Visual Studio 2013\\Projects\\DoAn2\\data\\DS_DKMH.xlsx")]
        public string registerPath {
            get {
                return ((string)(this["registerPath"]));
            }
            set {
                this["registerPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string schedulePath {
            get {
                return ((string)(this["schedulePath"]));
            }
            set {
                this["schedulePath"] = value;
            }
        }
    }
}
