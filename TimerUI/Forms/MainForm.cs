using System;
using System.Windows.Forms;
using TimerLibrary;
using TimerLibrary.Models;

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
        public object Sync { get; set; }
        private Overlay overlay;
        public MatchModel Match { get; set; }
        public bool MatchValueChanged { get; set; }

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

            statusLabel.Text = $"Starting server at port {SyncPort}";

            try
            {
                Sync = new Server(port, Match.ToJsonString());
                ((Server)Sync).Run();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            statusLabel.Text = $"Server started at port {SyncPort}";
            syncTimer.Start();
        }

        public void ConnectToServer(string ip, int port)
        {
            SyncType = NetworkType.Client;
            SyncIp = ip;
            SyncPort = port;

            statusLabel.Text = $"Connecting to {SyncIp}:{SyncPort}";

            Sync = new Client(ip, port, Match.ToJsonString());

            try
            {
                ((Client)Sync).Send("InitialConnection", "OK");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            syncTimer.Start();
        }

        private void syncTimer_Tick(object sender, EventArgs e)
        {
            switch (Sync)
            {
                case null:
                    return;
                case Server server:
                    ServerTick(ref server);
                    break;
                case Client client:
                    ClientTick(ref client);
                    break;
            }

            UpdateForm();
            MatchValueChanged = false;
        }

        private void ClientTick(ref Client client)
        {
            statusLabel.Text =
                $"Server {SyncIp}:{SyncPort} ({client.CurrentConnectionStatus})";

            if (client.CurrentConnectionStatus != "Connected")
            {
                if (client.CurrentConnectionStatus == "Disconnected")
                {
                    ResetNetworking();
                }

                return;
            }

            if (MatchValueChanged)
            {
                try
                {
                    client.Send("UpdateMatch", Match.ToJsonString());
                    MatchValueChanged = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Can't sent updated match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    client.Disconnect();
                }
            }

            if (client.PendingUpdate)
            {
                Match = MatchModel.ParseJsonString(client.MatchJson);
            }
        }

        private void ServerTick(ref Server server)
        {
            statusLabel.Text = $"Server started at port {SyncPort} - {server.NumberOfClients} client/s";

            if (MatchValueChanged)
            {
                server.MatchJson = Match.ToJsonString();
                server.SendUpdatedMatchToClients();
            }

            if (server.PendingUpdate)
            {
                Match = MatchModel.ParseJsonString(server.MatchJson);
            }
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

        public void ResetNetworking()
        {
            switch (Sync)
            {
                case Server server:
                    server.Disconnect();
                    break;

                case Client client:
                    client.Disconnect();
                    break;
            }

            statusLabel.Text = "Disconnected";
            Sync = null;
            SyncType = NetworkType.None;
        }

        private void resetNetworkOption_Click(object sender, EventArgs e)
        {
            ResetNetworking();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetNetworking();
        }
    }
}
