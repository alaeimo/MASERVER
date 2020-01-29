using System;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Collections.Generic;

namespace MAServer
{
    class Server
    {
        private static IPAddress IP;
        private static Int32 PORT = 80;
        private static bool Started = false;
        public static List<String> Statuslist = new List<string>();
        public static String url = "";
        private Thread Server_Thread;
        private TcpListener tcpServer;

        public Server()
        {
            IP = IPAddress.Parse(GetIPAddress()[0]);
            PORT = 80;
        }
        public void Start_Server()
        {
            if (!Started)
            {
                Statuslist.Add("Server Started!");
                tcpServer = new TcpListener(IP, PORT);
                Server_Thread = new Thread(new ThreadStart(Listener));
                Server_Thread.Start();
            }
        }

        public void Listener()
        {
            Started = true;
            try
            {
                tcpServer.Start(100);
            }
            catch (Exception)
            {
                Statuslist.Add(" Can't Start Server");
            }

            Statuslist.Add("Wait for Client ...");
            while (Started)
            {
                try
                {
                    HandleClient();
                }
                catch (Exception)
                {
                    Statuslist.Add("Can't Connect");
                }
            }
        }//EOF Listener

        public void HandleClient()
        {
            TcpClient tcpClient = tcpServer.AcceptTcpClient();

            Statuslist.Add("Connected");
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            String msg = "";
            try
            {
                while (sr.Peek() != -1)
                {
                    msg += sr.ReadLine() + '\n';
                }
            }
            catch (Exception)
            {
                Statuslist.Add("Reading Failed");
            }

            if (msg != "")
            {
                Request request = Request.GetRequest(msg);
                Response response = Response.Create_Response(request);
                if (response == null) Statuslist.Add("Can't Open File");
                else
                {
                    String Header = String.Format("{0} {1} {2}\r\nConnection: {3}\r\nDate: {4}\r\nServer: {5}\r\nLast_Modified: {6}\r\nAccept-Ranges: bytes\r\nContent-Type: {7}\r\nContent-Length: {8}\r\nContent_Disposition: {9}\r\n\n", // Two \n for an empty line.
                    response.Http_Version, response.Status_Code, response.Reason_Phrase, response.Connection, response.Date, response.Server_Name, response.Last_Modified, response.Content_Type, response.Content_Length, response.Content_Disposition);

                    Byte[] header_in_bytes = get_bytes(Header);

                    url = request.ReqType;
                    NetworkStream ns = tcpClient.GetStream();
                    try
                    {
                        ns.Write(header_in_bytes, 0, header_in_bytes.Length);

                        if (response.Data == null)
                            ns.Write(response.HtmlPage, 0, response.HtmlPage.Length);
                        ns.Write(response.Data, 0, response.Data.Length);
                        Statuslist.Add("Data Sending..");

                    }
                    catch (Exception)
                    {

                        Statuslist.Add("Can't Send data to client");
                    }

                }
            }

            tcpClient.Close();
        }
        public void Stop_Server()
        {
            try
            {
                Statuslist.Add("Server Stoped!");

                tcpServer.Stop();

                Server_Thread.Abort();

                Started = false;
            }
            catch (Exception)
            {
                Statuslist.Add("Can't Stop Server");
            }

        }
        public static String[] GetIPAddress()
        {
            String[] Result = new String[2];
            IPAddress ipAddress = IPAddress.Any;
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
                {
                    IPInterfaceProperties properties = netif.GetIPProperties();
                    foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                        if (netif.Name.Equals("Wi-Fi"))
                            if (unicast.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                ipAddress = unicast.Address;
                                Result[0] = ipAddress.ToString();
                                Result[1] = netif.Name;

                            }
                }
            }
            else
            {
                var Host = Dns.GetHostEntry(Dns.GetHostName());
                foreach(var ip in Host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Result[0] = ip.ToString();
                        Result[1] = "LocalHost";
                    }
                }
            }
            //IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            ////string ipAddress = string.Empty;
            //foreach (IPAddress ip in host.AddressList)
            //{
            //    if (ip.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        ipAddress = ip;
            //        break;
            //    }
            //}

            return Result;
        }

        private static Byte[] get_bytes(String s)
        {
            Byte[] b = new Byte[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                b[i] = (Byte)s[i];
            }

            return b;
        }

        private static void wait(int time)
        {

            Thread.Sleep(time);
        }

    }
}
