using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;


namespace Server_CS
{
    internal class Program
    {
        const int portNo = 50000; // change
        static void Main(string[] args)
        {
            System.Net.IPAddress localAdd = System.Net.IPAddress.Parse("127.0.0.1");
            //---listen at the local address---
            TcpListener listener = new TcpListener(localAdd, portNo);
            listener.Start();
            while (true)
            {
                ChatClient user = new ChatClient(listener.AcceptTcpClient());
            }
            
        }
    }
}