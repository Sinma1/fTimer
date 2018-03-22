using System.Net;
using System.Threading;
using System.Web.Script.Serialization;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using TimerLibrary.Models;

namespace TimerLibrary
{
    public class Server
    {
        public int PortToBind { get; set; }
        private MatchModel matchToUpdate;

        public Server(int port, MatchModel match)
        {
            PortToBind = port;
            matchToUpdate = match;

            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Message", OnMessageReceived);
        }

        public void Run()
        {
            Connection.StartListening(ConnectionType.TCP, new IPEndPoint(IPAddress.Any, PortToBind));
        }

        private void OnMessageReceived(PacketHeader header, Connection connection, string message)
        {
            matchToUpdate = new JavaScriptSerializer().Deserialize<MatchModel>(message);
        }
    }
}
