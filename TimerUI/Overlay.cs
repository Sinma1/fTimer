using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimerUI
{

    public partial class Overlay : Form
    {
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private readonly MainWindow parentWindow;

        public Overlay(MainWindow parentWindow)
        {
            InitializeComponent();

            ShowIcon = false;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;

            var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            this.parentWindow = parentWindow;

            LoadConfigForOverlay();

            Show();
            timer.Start();
        }

        private void LoadConfigForOverlay()
        {
            cooldownsLabel.ForeColor = (Color)Properties.Settings.Default["CooldownsColors"];
            cooldownsLabel.Location = (Point)Properties.Settings.Default["CooldownsPosition"];
            cooldownsLabel.Font = (Font)Properties.Settings.Default["CooldownsFont"];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var spellsToDisplay = new List<String>();
            foreach (var summoner in parentWindow.SummonersList)
            {
                var firstSpell = summoner.FirstSummonerSpell;
                var secondSpell = summoner.SecondSummonerSpell;

                if (firstSpell.SecondsLeft > 0)
                {
                    spellsToDisplay.Add($"({summoner.Name}){firstSpell.Name}={firstSpell.SecondsLeft}");
                }

                if (secondSpell.SecondsLeft > 0)
                {
                    spellsToDisplay.Add($"({summoner.Name}){secondSpell.Name}={secondSpell.SecondsLeft}");
                }
            }

            cooldownsLabel.Text = "";
            foreach (var spell in spellsToDisplay)
            {
                cooldownsLabel.Text += $"{spell}\n";
            }
        }
    }
}
