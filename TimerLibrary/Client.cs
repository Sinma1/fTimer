using System.Windows.Forms;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using TimerLibrary.Models;

namespace TimerLibrary
{
    public class Client
    {
        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public string CurrentConnectionStatus { get; set; }
        public MatchModel Match { get; set; }

        public Client(string ip, int port, MatchModel match)
        {
            ServerIp = ip;
            ServerPort = port;
            Match = match;

            Register();
        }

        private void Register()
        {
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("ConnectionStatus", ReceiveConnectionStatus);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("UpdatedMatch", ReceiveUpdatedMatch);

            MessageBox.Show("ZACZYNAMY KLIENTA");

        }

        #region Receive Functions
        private void ReceiveConnectionStatus(PacketHeader packetheader, Connection connection, string status)
        {
            CurrentConnectionStatus = status;
        }

        private void ReceiveUpdatedMatch(PacketHeader packetheader, Connection connection, string jsonMatch)
        {
            Match = MatchModel.ParseJsonString(jsonMatch);
        }


        #endregion

        ~Client()
        {
            NetworkComms.Shutdown();
        }

        public void Send(string header, string data)
        {
            NetworkComms.SendObject(header, ServerIp, ServerPort, data);
        }
    }
}
