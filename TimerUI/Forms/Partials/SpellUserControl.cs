using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerLibrary.Models;

namespace TimerUI.Forms.Partials
{
    public partial class SpellUserControl : UserControl
    {
        public SummonerSpellModel SummonerSpell { get; set; }

        public SpellUserControl()
        {
            InitializeComponent();   
        }

        public void SetUpData(SummonerSpellModel summonerSpell)
        {
            SummonerSpell = summonerSpell;
            spellNameLabel.Text = summonerSpell.Name;
            CooldownTimer.Start();
        }

        public void UpdateData()
        {
            spellNameLabel.Text = SummonerSpell.Name;
        }

        public void ValuesChanged()
        {
            var parent = ParentForm as MainForm;
        }

        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            if (SummonerSpell.SecondsLeft <= 0)
            {
                spellCountdownLabel.ForeColor = Color.LimeGreen;
                spellCountdownLabel.Text = $"Ready({SummonerSpell.Cooldown}s)";
                return;
            }

            spellCountdownLabel.ForeColor = Color.Red;
            spellCountdownLabel.Text = $"{SummonerSpell.SecondsLeft}s";
        }

        private void spellStartButton_Click(object sender, EventArgs e)
        {
            SummonerSpell.SpellUsedTime = DateTime.Now;
            (ParentForm as MainForm).MatchValueChanged = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SummonerSpell.SpellUsedTime = null;
        }

        private void spellSubstract10Second_Click(object sender, EventArgs e)
        {
            SummonerSpell.SubtractSeconds(10);
        }

        private void spellSubstract30Second_Click(object sender, EventArgs e)
        {
            SummonerSpell.SubtractSeconds(30);
        }

        private void editSpellButton_Click(object sender, EventArgs e)
        {
            new EditSpellForm(this).Show();
        }
    }
}
