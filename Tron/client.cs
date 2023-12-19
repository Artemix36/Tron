using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tron
{
    internal class client
    {
        public static void Connect(IPEndPoint IPEnd)
        {
            using (Socket client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                client_socket.ConnectAsync(IPEnd);
                Console.WriteLine(client_socket.LocalEndPoint);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

    }
}
