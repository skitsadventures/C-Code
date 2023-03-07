using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Multiplayer
{
    internal class Client1
    {
        public static int dataBufferSize = 4096;
        public int id;
        public TCP tcp;

        public Client1(int _Clientid)
        {
            id = _Clientid;
            tcp = new TCP(id);
        }

        public class TCP
        {
            public TcpClient socket;

            private readonly int id;
            private NetworkStream stream;
            private byte[] recieveBuffer;

            public TCP(int _id)
            {
                id = _id;
            }

            public void Connect(TcpClient _socket)
            {
                socket = _socket;
                socket.ReceiveBufferSize = dataBufferSize;
                socket.SendBufferSize = dataBufferSize;

                stream = socket.GetStream();
                recieveBuffer = new byte[dataBufferSize];
                stream.BeginRead(recieveBuffer, 0, dataBufferSize, RecieveCallback, null);
            }

            private void RecieveCallback(IAsyncResult _result)
            {
                try
                {
                    int _byteLength = stream.EndRead(_result);
                    if (_byteLength <=0)
                    {
                        return;
                    }

                    byte[] _data = new byte[_byteLength];
                    Array.Copy(recieveBuffer, _data, _byteLength);

                    stream.BeginRead(recieveBuffer, 0, dataBufferSize, RecieveCallback, null);
                }

                catch (Exception _ex)
                {
                    Console.WriteLine($"Error recieving TCP data: {_ex}");
                }
            }  
        }
    }
}
