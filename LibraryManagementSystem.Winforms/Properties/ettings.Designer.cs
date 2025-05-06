namespace LibraryManagementSystem.Winforms.Properties
{
    [global::System.Runtime.CompilerServices.CompilerGenerated()]
    [global::System.CodeDom.Compiler.GeneratedCode("SettingsSingleFileGenerator", "1.0.0.0")]
    internal sealed partial class Settings : System.Configuration.ApplicationSettingsBase
    {
        private static Settings defaultInstance =
            ((Settings)(System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default => defaultInstance;

        [System.Configuration.UserScopedSetting()]
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("")]
        public string JwtToken
        {
            get => ((string)(this["JwtToken"]));
            set => this["JwtToken"] = value;
        }
    }
}