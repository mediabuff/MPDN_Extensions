﻿namespace Mpdn.PlayerExtensions
{
    namespace Example
    {
        public partial class DisplayChangerConfigDialog : DisplayChangerConfigBase
        {
            public DisplayChangerConfigDialog()
            {
                InitializeComponent();
            }

            protected override void LoadSettings()
            {
                checkBoxActivate.Checked = Settings.Activate;
                checkBoxRestore.Checked = Settings.Restore;
                checkBoxRestricted.Checked = Settings.Restricted;
                textBoxVideoTypes.Text = Settings.VideoTypes;
            }

            protected override void SaveSettings()
            {
                Settings.Activate = checkBoxActivate.Checked;
                Settings.Restore = checkBoxRestore.Checked;
                Settings.Restricted = checkBoxRestricted.Checked;
                Settings.VideoTypes = textBoxVideoTypes.Text;
            }
        }

        public class DisplayChangerConfigBase : ScriptConfigDialog<DisplayChangerSettings>
        {
        }
    }
}
