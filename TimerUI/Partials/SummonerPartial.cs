using System;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI.Partials
{
    public partial class SummonerPartial : UserControl
    {
        private Summoner summoner;

        public string RoleName
        {
            get => roleName.Text;
            set => roleName.Text = value;
        }

        public SummonerPartial(Summoner summoner)
        {
            this.secondSpell = new SpellPartial(summoner.FirstSummonerSpell);
            this.firstSpell = new SpellPartial(summoner.SecondSummonerSpell);

            InitializeComponent();

            this.summoner = summoner;
            DisplaySummonerOnPage(summoner);
        }

        public void DisplaySummonerOnPage(Summoner summoner)
        {
            RoleName = summoner.Name;
            firstSpell.DisplaySpellOnPage(summoner.SecondSummonerSpell);
            secondSpell.DisplaySpellOnPage(summoner.FirstSummonerSpell);
        }

        private void DisplaySummoner_Load(object sender, EventArgs e)
        {
            //MessageBox.Show();
        }
    }
}
