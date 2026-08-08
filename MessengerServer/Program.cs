using System.Net;
using System.Net.Sockets;
using System.Text;

UserRepository users = new UserRepository();

TcpListener server = new TcpListener(IPAddress.Any, 5000);

server.Start();

Console.WriteLine("Messenger Server started...");
Console.WriteLine("Waiting for clients...");

while (true)
{
    TcpClient client = server.AcceptTcpClient();

    Console.WriteLine("Client connected.");

    // Handle this client separately
    Task.Run(() => HandleClient(client));
}


void HandleClient(TcpClient client)
{
    NetworkStream stream = client.GetStream();

    try
    {
        while (client.Connected)
        {
            byte[] buffer = new byte[1024];

            int bytesRead = stream.Read(buffer, 0, buffer.Length);

            if (bytesRead == 0)
                break;

            string message =
                Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Console.WriteLine("Received: " + message);


            // SEARCH USER
            if (message.StartsWith("SEARCH_USER:"))
            {
                string userId =
                    message.Substring("SEARCH_USER:".Length);

                Console.WriteLine("Searching for: " + userId);

                if (users.UserExists(userId))
                {
                    string response =
                        $"USER_FOUND|{userId}|Unknown|Online";

                    byte[] reply =
                        Encoding.UTF8.GetBytes(response);

                    stream.Write(reply, 0, reply.Length);
                }
                else
                {
                    byte[] reply =
                        Encoding.UTF8.GetBytes("USER_NOT_FOUND");

                    stream.Write(reply, 0, reply.Length);
                }
            }

            // OTHER MESSAGE
            else
            {
                byte[] reply =
                    Encoding.UTF8.GetBytes("Received");

                stream.Write(reply, 0, reply.Length);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(
            "Client error: " + ex.Message);
    }

    client.Close();

    Console.WriteLine("Client disconnected.");
}