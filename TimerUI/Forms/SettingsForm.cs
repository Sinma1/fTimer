using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TimerUI.Forms
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm _instance;

        public static SettingsForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new SettingsForm();
                }

                _instance.BringToFront();
                return _instance;
            }
        }

        private SettingsForm()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void LoadSettings()
        {
            var color = Properties.Settings.Default.CooldownsColors;
            var font = Properties.Settings.Default.CooldownsFont;
            var size = Properties.Settings.Default.CooldownsPosition;

            fontColorDialog.Color = color;
            fontColorValue.BackColor = color;

            fontDialog.Font = font;
            fontValue.Text = $"{font.OriginalFontName}, {font.SizeInPoints}";

            positionXValue.Value = size.X;
            positionYValue.Value = size.Y;


            //Load hotkey settings
            topFirstSpellValue.Text = Properties.Settings.Default.TopFirstSpellHotkey;
            topSecondSpellValue.Text = Properties.Settings.Default.TopSecondSpellHotkey;

            jungleFirstSpellValue.Text = Properties.Settings.Default.JungleFirstSpellHotkey;
            jungleSecondSpellValue.Text = Properties.Settings.Default.JungleSecondSpellHotkey;

            midFirstSpellValue.Text = Properties.Settings.Default.MidFirstSpellHotkey;
            midSecondSpellValue.Text = Properties.Settings.Default.MidSecondSpellHotkey;

            adcFirstSpellValue.Text = Properties.Settings.Default.AdcFirstSpellHotkey;
            adcSecondSpellValue.Text = Properties.Settings.Default.AdcSecondSpellHotkey;

            supportFirstSpellValue.Text = Properties.Settings.Default.SupportFirstSpellHotkey;
            supportSecondSpellValue.Text = Properties.Settings.Default.SupportSecondSpellHotkey;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.CooldownsColors = fontColorDialog.Color;

            Properties.Settings.Default.CooldownsFont = fontDialog.Font;

            Properties.Settings.Default.CooldownsPosition = 
                new Point((int)positionXValue.Value, (int)positionYValue.Value);


            Properties.Settings.Default.TopFirstSpellHotkey = topFirstSpellValue.Text;
            Properties.Settings.Default.TopSecondSpellHotkey = topSecondSpellValue.Text;

            Properties.Settings.Default.JungleFirstSpellHotkey = jungleFirstSpellValue.Text;
            Properties.Settings.Default.JungleSecondSpellHotkey = jungleSecondSpellValue.Text;

            Properties.Settings.Default.MidFirstSpellHotkey = midFirstSpellValue.Text;
            Properties.Settings.Default.MidSecondSpellHotkey = midSecondSpellValue.Text;

            Properties.Settings.Default.AdcFirstSpellHotkey = adcFirstSpellValue.Text;
            Properties.Settings.Default.AdcSecondSpellHotkey = adcSecondSpellValue.Text;

            Properties.Settings.Default.SupportFirstSpellHotkey = supportFirstSpellValue.Text;
            Properties.Settings.Default.SupportSecondSpellHotkey = supportSecondSpellValue.Text;

            Properties.Settings.Default.Save();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontValue.Text = $"{fontDialog.Font.OriginalFontName}, {fontDialog.Font.SizeInPoints}";
            }
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            if (fontColorDialog.ShowDialog() == DialogResult.OK)
            {
                fontColorValue.BackColor = fontColorDialog.Color;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CaptureHotkey(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textbox)
            {
                textbox.Text = new KeysConverter().ConvertToString(e.KeyData);
            }
        }

        private void StopFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
