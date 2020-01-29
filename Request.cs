using System;
using System.Net;

namespace MAServer
{
    class Request
    {
        public String Method { get; set; }
        public String URL { get; set; }
        public String ReqType { get; set; } //Like Download , OpenFile,...
        public String HTTP { get; set; }
        public String Host { get; set; }
        public String User_Agent { get; set; }
        public String Connection { get; set; }
        public String Message_Body { get; set; }

        private Request(String method, String url, String http, String host, String user_agent, String connection, String message_body)
        {
            this.Method = method;
            this.URL = url;
            this.HTTP = http;
            this.Host = host;
            this.User_Agent = user_agent;
            this.Connection = connection;
            this.Message_Body = message_body;
        }

        public static Request GetRequest(String request)
        {

            String method = null,
                   url = null,
                   reqtype = null,
                   http = null,
                   host = null,
                   user_agent = null,
                   connection = null,
                   message_body = null;

            String[] Request_Lines = request.Split('\n');
            String[] Status_Line = Request_Lines[0].Split(' ');
            String[] Headers;
            if (Status_Line[0] != null)
                method = Status_Line[0];
            if (Status_Line[1] != null)
            {
                String[] reqURL = Status_Line[1].Split(':');
                if (reqURL.Length == 1)
                {
                    reqtype = null;
                    url = Status_Line[1];
                    url = url.Substring(1, url.Length - 1);
                }

                else
                {
                    reqtype = reqURL[0];
                    //   reqtype = reqtype.Substring(1, reqtype.Length - 1);
                    url = reqURL[1];
                }


            }
            if (Status_Line[2] != null)
                http = Status_Line[2];

            for (int i = 0; i < Request_Lines.Length; i++)
            {
                Headers = Request_Lines[i].Split(' ');

                if (Headers[0].Equals("Host:"))
                {
                    host = Headers[1];
                }
                else if (Headers[0].Equals("User-Agent:"))
                {
                    for (int j = 1; j < Headers.Length; j++)
                        user_agent += (Headers[j] + " ");

                    Users.Add_to_List(user_agent);

                }
                else if (Headers[0].Equals("Connection:"))
                {
                    connection = Headers[1];
                }

                if (Request_Lines[i] == "\n")
                    message_body += Request_Lines[i];
            }

            return new Request(method, url, http, host, user_agent, connection, message_body);
        }


    }
}
