using System;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;

namespace TimerLibrary
{
    public class Client
    {
        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public string CurrentConnectionStatus { get; set; }
        public string MatchJson { get; set; }
        public bool PendingUpdate { get; set; }

        public Client(string ip, int port, string matchJson)
        {
            ServerIp = ip;
            ServerPort = port;
            MatchJson = matchJson;

            Register();
        }

        public void Disconnect()
        {
            NetworkComms.Shutdown();
        }

        private void Register()
        {
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("ConnectionStatus", ReceiveConnectionStatus);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("UpdatedMatch", ReceiveUpdatedMatch);
        }


        #region Receive Functions

        private void ReceiveConnectionStatus(PacketHeader packetheader, Connection connection, string status)
        {
            CurrentConnectionStatus = status;
            Console.WriteLine($"{packetheader.PacketType}: {status}");
        }

        private void ReceiveUpdatedMatch(PacketHeader packetheader, Connection connection, string jsonMatch)
        {
            MatchJson = jsonMatch;
            Console.WriteLine(jsonMatch);
            PendingUpdate = true;
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
