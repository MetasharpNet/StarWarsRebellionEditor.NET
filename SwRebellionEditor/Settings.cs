using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SwRebellionEditor
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized((SettingsBase)new Settings());

        public static Settings Default => Settings.defaultInstance;

        [DefaultSettingValue("1024, 768")]
        [UserScopedSetting]
        [DebuggerNonUserCode]
        public Size BackgroundSize
        {
            get => (Size)this[nameof(BackgroundSize)];
            set => this[nameof(BackgroundSize)] = (object)value;
        }

        [DefaultSettingValue("0, 0")]
        [DebuggerNonUserCode]
        [UserScopedSetting]
        public Point MainWindowTopLeftCornerPosition
        {
            get => (Point)this[nameof(MainWindowTopLeftCornerPosition)];
            set => this[nameof(MainWindowTopLeftCornerPosition)] = (object)value;
        }

        [DefaultSettingValue("False")]
        [UserScopedSetting]
        [DebuggerNonUserCode]
        public bool PlaySoundEffects
        {
            get => (bool)this[nameof(PlaySoundEffects)];
            set => this[nameof(PlaySoundEffects)] = (object)value;
        }

        [DefaultSettingValue("False")]
        [UserScopedSetting]
        [DebuggerNonUserCode]
        public bool PlayMusic
        {
            get => (bool)this[nameof(PlayMusic)];
            set => this[nameof(PlayMusic)] = (object)value;
        }

        [UserScopedSetting]
        [DefaultSettingValue("False")]
        [DebuggerNonUserCode]
        public bool appPlaySounds
        {
            get => (bool)this[nameof(appPlaySounds)];
            set => this[nameof(appPlaySounds)] = (object)value;
        }

        [UserScopedSetting]
        [DefaultSettingValue("True")]
        [DebuggerNonUserCode]
        public bool IsFirstStartup
        {
            get => (bool)this[nameof(IsFirstStartup)];
            set => this[nameof(IsFirstStartup)] = (object)value;
        }

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
        }
    }
}
