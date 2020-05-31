using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPclientAndTcpLisenter
{
    class MyTcpListener
    {
        IPAddress localAddr;
        int port;
       TextBox showTextTextBox;
        public string receiveText;
        Form form;
        Context context;
         
        public MyTcpListener(string localAddr, int port,Form form, TextBox showTextBox)      
           {

            this.localAddr = IPAddress.Parse(localAddr);
            this.port = port;
            this.form = form;
            this.showTextTextBox = showTextBox;


        }


        public MyTcpListener(string localAddr, int port,TextBox showTextBox)
        {

            this.localAddr = IPAddress.Parse(localAddr);
            this.port = port;

            this.showTextTextBox=showTextTextBox;

        }



        public  void  GetAndSendData()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
               // Int32 port = 13000;
              //  IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);
                        receiveText = data;
                      Action action = () =>
                       {
                         // string  receiveString = Encoding.Default.GetString(data).Trim('\0');//转换成字符串  
                            showTextTextBox.Text = data;
                        };
                      form.Invoke(action);



                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }




    }
}
