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
        private Overlay overlay;
        public List<Summoner> SummonersList { get; set; }

        public MainWindow()
        {
            SummonersList = new List<Summoner>
            {
                Summoner.CreateDefaultSummoner("TOP", "flash", "teleport"),
                Summoner.CreateDefaultSummoner("JUNGLE", "flash", "smite"),
                Summoner.CreateDefaultSummoner("MID", "flash", "barrier"),
                Summoner.CreateDefaultSummoner("ADC", "flash", "heal"),
                Summoner.CreateDefaultSummoner("SUPPORT", "flash", "exhaust")
            };
            topSummoner = new Partials.SummonerPartial(SummonersList[0]);
            jungleSummoner = new Partials.SummonerPartial(SummonersList[1]);
            midSummoner = new Partials.SummonerPartial(SummonersList[2]);
            adcSummoner = new Partials.SummonerPartial(SummonersList[3]);
            supportSummoner = new Partials.SummonerPartial(SummonersList[4]);
            
            InitializeComponent();

            overlaySetting.CheckOnClick = true;
        }

        private void overlaySetting_Click(object sender, System.EventArgs e)
        {
            if (overlaySetting.Checked)
            {
                overlay = new Overlay(this);
            }
            else
            {
                overlay.Dispose();
            }
        }
    }
}
