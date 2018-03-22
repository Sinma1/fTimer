using System.Windows.Forms;
using TimerLibrary.Models;

namespace TimerUI.Forms.Partials
{
    public partial class SummonerUserControl : UserControl
    {
        public SummonerModel Summoner { get; set; }

        public SummonerUserControl()
        {
            InitializeComponent();
        }

        public void SetUpData(SummonerModel summoner)
        {
            Summoner = summoner;

            roleNameLabel.Text = summoner.Name;
            firstSpellControl.SetUpData(summoner.FirstSummonerSpell);
            secondSpellControl.SetUpData(summoner.SecondSummonerSpell);
        }
    }
}
