using System;
using System.Collections.Generic;
using System.Net;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;

namespace TimerLibrary
{
    public class Server
    {
        public int PortToBind { get; set; }
        public string MatchJson { get; set; }
        private readonly List<Connection> connectedClients = new List<Connection>();
        public bool PendingUpdate { get; set; }

        public Server(int port, string match)
        {
            PortToBind = port;
            MatchJson = match;
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
            MatchJson = message;
            SendUpdatedMatchToClients();
            PendingUpdate = true;
            Console.WriteLine($"SERVER-{header.PacketType}: {message}");
        }

        private void ReceiveInitialConnection(PacketHeader packetheader, Connection connection, string welcomeMessage)
        {
            connectedClients.Add(connection);
            SendToClient(connection, "ConnectionStatus", "Connected");
            SendToClient(connection, "UpdateMatch", MatchJson);

            Console.WriteLine("{packetheader.PacketType}: {welcomeMessage}");
        }

        #endregion

        #region Send functions

        public void SendUpdatedMatchToClients()
        {
            foreach (var connectedClient in connectedClients)
            {
                try
                {
                    SendToClient(connectedClient, "UpdatedMatch", MatchJson);
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
