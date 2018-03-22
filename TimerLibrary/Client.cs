using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkCommsDotNet;

namespace TimerLibrary
{
    public class Client
    {
        public string ServerIp { get; set; }
        public int ServerPort { get; set; }

        public Client(string ip, int port)
        {
            this.ServerIp = ip;
            this.ServerPort = port;
        }

        ~Client()
        {
            NetworkComms.Shutdown();
        }

        public void Send(string data)
        {
            NetworkComms.SendObject("Message", ServerIp, ServerPort, data);
        }
    }
}
