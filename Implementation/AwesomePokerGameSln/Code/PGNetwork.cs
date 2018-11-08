using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace AwesomePokerGameSln.Code
{
    public class PGNetwork : Socket
    {
        //Constructor
        public  PGNetwork() : base(SocketType.Stream, ProtocolType.Tcp)
        {
            Socket netsock = new Socket(SocketType.Stream, ProtocolType.Tcp);
        }

        public static void Connect(PGNetwork netsock)
        {
            try
            {
                //Tries to connect. Currently using google as a placeholder
                netsock.Connect("Google.com", 8888);
            }
            catch(SocketException)
            {
                //If Connect fails it throws an exception
                Console.WriteLine("Error: Connection Failed.");
                return;
            }
            return;
        }

        public static void Disconnect(PGNetwork netsock)
        {
            //Make sure there is a connection before we try to close a
            //non existant connection.
            if (netsock.Connected == true)
            {
                netsock.Close();
            }
            else
            {
                return;
            }
        }
    }
}
