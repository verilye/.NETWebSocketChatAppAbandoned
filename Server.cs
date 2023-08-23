using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

class Server
{

    // Creating a Web Socket in C#
    // https://developer.mozilla.org/en-US/docs/Web/API/WebSockets_API/Writing_WebSocket_server

    // Things to consider:
    // Security, debugging, scaling and load balancing

    public static void Main(string[] args)
    {

        // Send a http request to 'get' the connection and then upgrade it to a websocket connection (In C# this is the System.Net.Sockets)
        // This upgraded connection is a single, two way transmission control Protocol connection

        string PORT = "127.0.0.1";
        // Websocket protocol by default uses port 80 for regular websocket connections
        TcpListener server = new TcpListener(IPAddress.Parse(PORT), 80);

        server.Start();
        Console.WriteLine(
            "Server has started on " + PORT + ":80.{0}Waiting for a connection..."
            , Environment.NewLine
        );

        TcpClient client = server.AcceptTcpClient();

        Console.WriteLine("A client has connected");

        // Open up a Network stream object so that bytes can be pulled from it and checked 
        // We are looking for a GET command to upgrade the connection
        NetworkStream stream = client.GetStream();

        while (true)
        {
            while(client.Available <3){

            }

            byte[] bytes = new byte[client.Available];

            stream.Read(bytes,0,bytes.Length);

            String data = Encoding.UTF8.GetString(bytes);

            if(Regex.IsMatch(data,"^GET")){
                // connect and potentially check for authorisation
            }else{
                // reject
            }



        }
    }
}