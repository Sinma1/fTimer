using System;
using System.Threading;
using System.Windows.Forms;
using TimerLibrary;
using TimerLibrary.Models;
using TimerUI.Forms.Partials;

namespace TimerUI.Forms
{
    public enum NetworkType
    {
        None,
        Server,
        Client
    }

    public partial class MainForm : Form
    {
        private SummonerUserControl[] summonersControls;
        private Overlay overlay;
        public MatchModel Match { get; set; }
        public bool MatchValueChanged { get; set; } = false;

        public NetworkType SyncType { get; set; } = NetworkType.None;
        public string SyncIp { get; set; }
        public int SyncPort { get; set; }

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

            summonersControls = new[]
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

        public void StartServer(int port)
        {
            SyncType = NetworkType.Server;
            SyncPort = port;

            statusLabel.Text = $"Hosting at port {SyncPort}";
            networkThread.RunWorkerAsync();
        }

        public void ConnectToServer(string ip, int port)
        {
            SyncType = NetworkType.Client;
            SyncIp = ip;
            SyncPort = port;

            statusLabel.Text = $"Connected to {SyncIp}:{SyncPort}";
            networkThread.RunWorkerAsync();
        }

        private void networkThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (SyncType == NetworkType.Server)
            {
                var server = new Server(SyncPort, Match);
                server.Run();

                while (true)
                {
                    Thread.Sleep(1000);
                }
            }

            if (SyncType == NetworkType.Client)
            {
                var client = new Client(SyncIp, SyncPort, Match);
                client.Send("InitialConnection", "OK");

                while (true)
                {
                    Thread.Sleep(1000);
                }
            }

            //while (true)
            //{
                

            //    if (InvokeRequired)
            //    {
            //        //this.Invoke((MethodInvoker) test);
            //    }

            //    System.Threading.Thread.Sleep(1000);
            //}
        }

        private void connectOption_Click(object sender, EventArgs e)
        {
            if (SyncType != NetworkType.None)
            {
                MessageBox.Show("You are already connected/hosting");
                return;
            }

            new Networking.ConnectForm(this).Show();
        }

        private void hostOption_Click(object sender, EventArgs e)
        {
            if (SyncType != NetworkType.None)
            {
                MessageBox.Show("You are already connected/hosting");
                return;
            }

            new Networking.HostServerForm(this).Show();
        }
    }
}
