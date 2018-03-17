using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerLibrary;

namespace TimerUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            var summonersList = new List<Summoner>
            {
                Summoner.CreateDefaultSummoner("TOP", "flash", "teleport"),
                Summoner.CreateDefaultSummoner("JUNGLE", "flash", "smite"),
                Summoner.CreateDefaultSummoner("MID", "flash", "barrier"),
                Summoner.CreateDefaultSummoner("ADC", "flash", "heal"),
                Summoner.CreateDefaultSummoner("SUPPORT", "flash", "exhaust")
            };

            topSummoner.DisplaySummonerOnPage(summonersList[0]);
            jungleSummoner.DisplaySummonerOnPage(summonersList[1]);
            midSummoner.DisplaySummonerOnPage(summonersList[2]);
            adcSummoner.DisplaySummonerOnPage(summonersList[3]);
            supportSummoner.DisplaySummonerOnPage(summonersList[4]);

            settingsToolStripMenuItem.CheckOnClick = true;
        }
    }
}
