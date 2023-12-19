using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Tron
{
    internal class Server
    {
        public static void Host(IPEndPoint IPEnd)
        {
            using (Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client_socket.Bind(IPEnd);
                Console.WriteLine(client_socket.LocalEndPoint);
                client_socket.Listen(1);
                try
                {
                    client_socket.AcceptAsync();
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}
