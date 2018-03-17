using System;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI
{
    public partial class DisplaySummoner : UserControl
    {
        public string RoleName
        {
            get => roleName.Text;
            set => roleName.Text = value;
        }

        public DisplaySummoner()
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
