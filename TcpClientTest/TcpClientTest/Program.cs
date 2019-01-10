using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TcpClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient();
                client.Connect("localhost", 5001);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);

                    if (dataToSend.IndexOf("<EOF>") > -1) break;

                    dataToSend = Console.ReadLine();


                }




            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                client.Close();
            }

        }
    }
}
