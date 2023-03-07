using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Multiplayer
{
    internal class Server
    {
        public static int MaxPlayes { get; private set; }

        public static int Port { get; private set; }

        public static Dictionary<int, Client1> clients = new Dictionary<int, Client1>();

        private static TcpListener TcpListener;

        public static void Start(int _maxPlayers, int _port)
        {
            MaxPlayes = _maxPlayers;
            Port = _port;

            Console.WriteLine("Starting Server ...");
            InitializeServerData(); 

            TcpListener = new TcpListener(IPAddress.Any, Port);
            TcpListener.Start();
            TcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);

            Console.WriteLine($"Server started on {Port}.");
        }

        private static void TCPConnectCallback(IAsyncResult _result)
        {
            TcpClient _Client = TcpListener.EndAcceptTcpClient(_result);
            TcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPConnectCallback), null);
            Console.WriteLine($"Incoming connection from {_Client.Client.RemoteEndPoint}...");

            for (int i = 1; i <= MaxPlayes; i++)
            {
                if (clients[i].tcp.socket == null)
                {
                    clients[i].tcp.Connect(_Client);
                    return;
                }
            }

            Console.WriteLine($"{_Client.Client.RemoteEndPoint} failed to connect: Server full! ");

        }

        private static void InitializeServerData()
        {
            for (int i = 0; i < MaxPlayes; i++)
            {
                clients.Add(i, new Client1(i)); 
            }
        }
    }
}
