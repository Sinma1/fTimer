using System;
using System.Drawing;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI.Partials
{
    public partial class SpellPartial : UserControl
    {
        public SummonerSpell ThisSpell { get; set; }

        public int Cooldown
        {
            get => ThisSpell.Cooldown;
            set => ThisSpell.Cooldown = value;
        }

        public string SpellName
        {
            get => spellName.Text;
            set => spellName.Text = value;
        }

        public string SpellCooldownLeft
        {
            get => spellCountdown.Text.Substring(0, spellCountdown.Text.Length - 1);
            set => spellCountdown.Text = $"{value}s";
        }

        public SpellPartial(SummonerSpell spell)
        {
            InitializeComponent();

            ThisSpell = spell;
            DisplaySpellOnPage(spell);

            timer.Start();
        }

        public void DisplaySpellOnPage(SummonerSpell spell)
        {
            SpellName = spell.Name;
            SpellCooldownLeft = spell.Cooldown.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!ThisSpell.SpellUsedTime.HasValue || ThisSpell.SecondsLeft <= 0)
            {
                spellCountdown.ForeColor = Color.LimeGreen;
                spellCountdown.Text = $"Ready({ThisSpell.Cooldown}s)";

                return;
            }

            SpellCooldownLeft = (Cooldown - DateTime.Now.Subtract(ThisSpell.SpellUsedTime.Value).Seconds).ToString();
        }

        private void spellStartButton_Click(object sender, EventArgs e)
        {
            spellCountdown.ForeColor = Color.Red;
            ThisSpell.SpellUsedTime = DateTime.Now;
        }

        private void resetButton_Click(object sender, EventArgs e) => ThisSpell.SpellUsedTime = null;

        private void spellSubstract10_Click(object sender, EventArgs e)
        {
            ThisSpell.SpellUsedTime = ThisSpell.SpellUsedTime?.AddSeconds(-10);
        }

        private void spellSubstract30_Click(object sender, EventArgs e)
        {
            ThisSpell.SpellUsedTime = ThisSpell.SpellUsedTime?.AddSeconds(-30);
        }

        private void editSpellButton_Click(object sender, EventArgs e)
        {
            var editSpellWindow = new EditSpellWindow(this);
            editSpellWindow.Show();

        }
    }
}
