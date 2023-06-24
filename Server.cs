using System.Net.Sockets;
using System.Net;
using System;

class Server{
    // Creating a Web Socket in C#
    // https://developer.mozilla.org/en-US/docs/Web/API/WebSockets_API/Writing_WebSocket_server

    // How a WS server works

    // Server listens
    // We send a handshake in the form of a HTTP GET request
    // Check the request header for Sec-WebSocket-Key
    // Validate and upgrade connection to web socket


    // Sending messages to server

    // Encoded messages are sent to server
    // They are decoded


    public static void Main(string[] args){

        string PORT = "127.0.0.1";
        TcpListener server = new TcpListener(IPAddress.Parse(PORT),80);

        server.Start();
        Console.WriteLine(
            "Server has started on " + PORT+":80.{0}Waiting for a connection..."
            ,Environment.NewLine
        );

        TcpClient client = server.AcceptTcpClient();

        Console.WritleLine("A client has connected");
    }
}