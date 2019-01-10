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
                client.Connect("192.168.0.35", 5001);
                NetworkStream stream = client.GetStream();


                Encoding encode = Encoding.GetEncoding("utf-8");
                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);
                    String str = reader.ReadLine();
                    Console.WriteLine(str);

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
