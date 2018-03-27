using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerUI.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
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
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.CooldownsColors = fontColorDialog.Color;

            Properties.Settings.Default.CooldownsFont = fontDialog.Font;

            Properties.Settings.Default.CooldownsPosition = 
                new Point((int)positionXValue.Value, (int)positionYValue.Value);

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
    }
}
