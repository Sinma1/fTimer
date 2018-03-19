using System;
using System.Drawing;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI
{
    public partial class DisplaySpell : UserControl
    {
        public int Cooldown { get; set; }
        public DateTime? SpellUsedTime { get; set; }
        public TimeSpan TimeLeft => SpellUsedTime.Value.AddSeconds(Cooldown).Subtract(DateTime.Now);

        public string GetTimeLeft()
        {
            return (TimeLeft.Seconds > 0 ? TimeLeft.Seconds.ToString(): "0");
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

        public DisplaySpell()
        {
            InitializeComponent();

            timer.Start();
        }

        public void DisplaySpellOnPage(SummonerSpell spell)
        {
            SpellName = spell.Name;
            SpellCooldownLeft = spell.Cooldown.ToString();
            Cooldown = spell.Cooldown;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!SpellUsedTime.HasValue || TimeLeft.Seconds <= 0)
            {
                spellCooldownLeft.ForeColor = Color.LimeGreen;
                spellCooldownLeft.Text = $"Ready({Cooldown}s)";

                return;
            }

            SpellCooldownLeft = (Cooldown - DateTime.Now.Subtract(SpellUsedTime.Value).Seconds).ToString();
        }

        private void spellStartButton_Click(object sender, EventArgs e)
        {
            spellCooldownLeft.ForeColor = Color.Red;
            SpellUsedTime = DateTime.Now;
        }

        private void resetButton_Click(object sender, EventArgs e) => SpellUsedTime = null;

        private void spellSubstract10_Click(object sender, EventArgs e)
        {
            SpellUsedTime = SpellUsedTime?.AddSeconds(-10);
        }

        private void spellSubstract30_Click(object sender, EventArgs e)
        {
            SpellUsedTime = SpellUsedTime?.AddSeconds(-30);
        }

        private void editSpellButton_Click(object sender, EventArgs e)
        {
            var editSpellWindow = new EditSpellWindow(this);
            editSpellWindow.Show();

        }
    }
}
