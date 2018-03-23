using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;
using TimerLibrary.Models;

namespace TimerLibrary
{
    public class Server
    {
        public int PortToBind { get; set; }
        public MatchModel MatchToUpdate { get; set; }
        private readonly List<Connection> connectedClients = new List<Connection>();
        public bool PendingUpdate { get; set; } = false;

        public Server(int port, MatchModel match)
        {
            PortToBind = port;
            MatchToUpdate = match;
        }

        public void Run()
        {
            Register();
            Connection.StartListening(ConnectionType.TCP, new IPEndPoint(IPAddress.Any, PortToBind));
        }

        public void Shutdown()
        {
            NetworkComms.Shutdown();
        }


        private void Register()
        {
            NetworkComms.AppendGlobalConnectionCloseHandler(connection =>
            {
                connectedClients.Remove(connection);
            });

            NetworkComms.AppendGlobalIncomingPacketHandler<string>("UpdateMatch", ReceivedUpdateMatch);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("InitialConnection", ReceiveInitialConnection);

           // MessageBox.Show("ZACZYNAMY SERVER");
        }

        #region Receive Functions

        private void ReceivedUpdateMatch(PacketHeader header, Connection connection, string message)
        {
            MatchToUpdate = new JavaScriptSerializer().Deserialize<MatchModel>(message);
            SendUpdatedMatchToClients();
            PendingUpdate = true;
            MessageBox.Show($"SERVER-{header.PacketType}: {message}");
        }

        private void ReceiveInitialConnection(PacketHeader packetheader, Connection connection, string welcomeMessage)
        {
            connectedClients.Add(connection);
            SendToClient(connection, "ConnectionStatus", "Connected");
            //MessageBox.Show($"{packetheader.PacketType}: {welcomeMessage}");
        }

        #endregion

        #region Send functions

        public void SendUpdatedMatchToClients()
        {
            foreach (var connectedClient in connectedClients)
            {
                try
                {
                    SendToClient(connectedClient, "UpdatedMatch", MatchToUpdate.ToJsonString());
                }
                catch (CommsException exception)
                {
                    Console.WriteLine(exception.Message);
                    connectedClients.Remove(connectedClient);
                }
            }
        }

        private void SendToClient(Connection connection, string header, string message)
        {
            TCPConnection.GetConnection(
                new ConnectionInfo(connection.ConnectionInfo.RemoteEndPoint)).SendObject(header, message);
        }

        #endregion
    }
}
