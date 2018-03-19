using System;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI.Partials
{
    public partial class SummonerPartial : UserControl
    {
        public string RoleName
        {
            get => roleName.Text;
            set => roleName.Text = value;
        }

        public SummonerPartial()
        {
            InitializeComponent();
        }

        public void DisplaySummonerOnPage(Summoner summoner)
        {
            RoleName = summoner.Name;
            firstSpell.DisplaySpellOnPage(summoner.FirstSummonerSpell);
            secondSpell.DisplaySpellOnPage(summoner.SecondSummonerSpell);
        }

        private void DisplaySummoner_Load(object sender, EventArgs e)
        {
            //MessageBox.Show();
        }
    }
}
