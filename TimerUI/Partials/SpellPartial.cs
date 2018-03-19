using System;
using System.Drawing;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI.Partials
{
    public partial class SpellPartial : UserControl
    {
        public SummonerSpell ThisSpell { get; set; }

        public int Cooldown { get; set; }

        public string GetTimeLeft()
        {
            return (ThisSpell.TimeLeft.Seconds > 0 ? ThisSpell.TimeLeft.Seconds.ToString(): "0");
        }

        public string SpellName
        {
            get => spellName.Text;
            set => spellName.Text = value;
        }

        public string SpellCooldownLeft
        {
            get => spellCooldownLeft.Text.Substring(0, spellCooldownLeft.Text.Length - 1);
            set => spellCooldownLeft.Text = $"{value}s";
        }

        public SpellPartial()
        {
            InitializeComponent();

            timer.Start();
        }

        public void DisplaySpellOnPage(SummonerSpell spell)
        {
            SpellName = spell.Name;
            SpellCooldownLeft = spell.Cooldown.ToString();
            Cooldown = spell.Cooldown;

            ThisSpell = spell;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!ThisSpell.SpellUsedTime.HasValue || ThisSpell.TimeLeft.Seconds <= 0)
            {
                spellCooldownLeft.ForeColor = Color.LimeGreen;
                spellCooldownLeft.Text = $"Ready({Cooldown}s)";

                return;
            }

            SpellCooldownLeft = (Cooldown - DateTime.Now.Subtract(ThisSpell.SpellUsedTime.Value).Seconds).ToString();
        }

        private void spellStartButton_Click(object sender, EventArgs e)
        {
            spellCooldownLeft.ForeColor = Color.Red;
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
