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
        private MatchModel matchToUpdate;
        private readonly List<Connection> connectedClients = new List<Connection>();

        public Server(int port, MatchModel match)
        {
            PortToBind = port;
            matchToUpdate = match;
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
            NetworkComms.AppendGlobalConnectionEstablishHandler(connection =>
            {
                connectedClients.Add(connection);
            });

            NetworkComms.AppendGlobalConnectionCloseHandler(connection =>
            {
                connectedClients.Remove(connection);
            });

            NetworkComms.AppendGlobalIncomingPacketHandler<string>("UpdateMatch", ReceivedUpdateMatch);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("InitialConnection", ReceiveInitialConnection);

            MessageBox.Show("ZACZYNAMY SERVER");
        }

        #region Receive Functions

        private void ReceivedUpdateMatch(PacketHeader header, Connection connection, string message)
        {
            matchToUpdate = new JavaScriptSerializer().Deserialize<MatchModel>(message);
            SendUpdatedMatchToClients();
        }

        private void ReceiveInitialConnection(PacketHeader packetheader, Connection connection, string welcomeMessage)
        {
            connectedClients.Add(connection);
            SendToClient(connection, "ConnectionStatus", "Connected");
        }
        #endregion

        #region Send functions

        private void SendUpdatedMatchToClients()
        {
            foreach (var connectedClient in connectedClients)
            {
                try
                {
                    SendToClient(connectedClient, "UpdatedMatch", matchToUpdate.ToJsonString());
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
