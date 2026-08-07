using System.Net;
using System.Net.Sockets;
using System.Text;

TcpListener server = new TcpListener(IPAddress.Any, 5000);

server.Start();

Console.WriteLine("Server started...");

while (true)
{
    TcpClient client = server.AcceptTcpClient();

    Console.WriteLine("Client Connected");

    Task.Run(() => HandleClient(client));
}

static void HandleClient(TcpClient client)
{
    NetworkStream stream = client.GetStream();

    try
    {
        while (true)
        {
            byte[] buffer = new byte[1024];

            int bytesRead =
                stream.Read(buffer, 0, buffer.Length);

            if (bytesRead == 0)
                break;

            string message =
                Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Console.WriteLine(message);

            byte[] reply =
                Encoding.UTF8.GetBytes("Received");

            stream.Write(reply, 0, reply.Length);
        }
    }
    catch
    {

    }

    client.Close();

    Console.WriteLine("Disconnected");
}