using System;
using System.Windows.Forms;
using TimerLibrary.Models;
using TimerUI.Forms.Partials;

namespace TimerUI.Forms
{
    public partial class MainForm : Form
    {
        private SummonerUserControl[] summonersControls;
        private Overlay overlay;
        public MatchModel Match { get; set; }
        public bool MatchValueChanged { get; set; } = false;

        public MainForm()
        {
            InitializeComponent();

            Match = new MatchModel()
            {
                TopSummoner = SummonerModel.CreateDefaultSummoner("Top", "flash", "teleport"),
                JungleSummoner = SummonerModel.CreateDefaultSummoner("Jungle", "flash", "smite"),
                MidSummoner = SummonerModel.CreateDefaultSummoner("Mid", "flash", "barrier"),
                AdcSummoner = SummonerModel.CreateDefaultSummoner("Adc", "flash", "heal"),
                SupportSummoner = SummonerModel.CreateDefaultSummoner("Support", "flash", "exhaust"),
            };

            summonersControls = new SummonerUserControl[]
            {
                topSummoner, jungleSummoner, midSummoner, adcSummoner, supportSummoner
            };

            UpdateForm();
        }

        private void UpdateForm()
        {
            topSummoner.SetUpData(Match.TopSummoner);
            jungleSummoner.SetUpData(Match.JungleSummoner);
            midSummoner.SetUpData(Match.MidSummoner);
            adcSummoner.SetUpData(Match.AdcSummoner);
            supportSummoner.SetUpData(Match.SupportSummoner);
        }

        private void overlaySetting_Click(object sender, EventArgs e)
        {
            if (overlaySetting.Checked)
            {
                overlay = new Overlay(this);
                return;
            }

            overlay.Dispose();
        }

        private void networkThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                

                if (this.InvokeRequired)
                {
                    //this.Invoke((MethodInvoker) test);
                }

            }
        }
    }
}
