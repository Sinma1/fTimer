using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NHotkey;
using NHotkey.WindowsForms;
using TimerLibrary.Models;
using TimerUI.Forms;
using TimerUI.Properties;

namespace TimerUI
{

    public partial class Overlay : Form
    {
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private readonly MainForm parentWindow;

        public Overlay(MainForm parentWindow)
        {
            InitializeComponent();

            ShowIcon = false;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;

            var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            this.parentWindow = parentWindow;

            LoadConfigForOverlay();
            RegisterHotkeys();

            Show();
            timer.Start();
        }

        private void RegisterHotkeys()
        {
            RegisterHotkeyForRole(parentWindow.Match.TopSummoner);
            RegisterHotkeyForRole(parentWindow.Match.JungleSummoner);
            RegisterHotkeyForRole(parentWindow.Match.MidSummoner);
            RegisterHotkeyForRole(parentWindow.Match.AdcSummoner);
            RegisterHotkeyForRole(parentWindow.Match.SupportSummoner);
        }

        private void RegisterHotkeyForRole(SummonerModel summoner)
        {
            var converter = new KeysConverter();

            try
            {
                var firstSpellKey = (Keys)converter.ConvertFromString(
                                    Settings.Default[$"{summoner.Name}FirstSpellHotkey"].ToString());

                HotkeyManager.Current.AddOrReplace($"{summoner.Name}FirstSpell", firstSpellKey, delegate
                {
                    summoner.FirstSummonerSpell.SpellUsedTime = DateTime.Now;
                });


                var secondSpellKey = (Keys)converter.ConvertFromString(
                    Settings.Default[$"{summoner.Name}SecondSpellHotkey"].ToString());

                HotkeyManager.Current.AddOrReplace($"{ summoner.Name }SecondSpell", secondSpellKey, delegate
                {
                    summoner.SecondSummonerSpell.SpellUsedTime = DateTime.Now;
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.Message, @"Error while registering hotkey");
            }
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
            foreach (var summoner in parentWindow.Match.Summoners)
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
