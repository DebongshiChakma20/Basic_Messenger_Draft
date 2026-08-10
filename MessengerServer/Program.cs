using System.Net;
using System.Net.Sockets;
using System.Text;

UserRepository users = new UserRepository();
MessageRepository messages = new MessageRepository();
Dictionary<string, TcpClient> connectedUsers = new Dictionary<string, TcpClient>();



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

            //for registration

            if (message.StartsWith("REGISTER:"))
            {
                string data = message.Substring("REGISTER:".Length);

                string[] parts = data.Split('|');

                if (parts.Length != 3)
                {
                    byte[] reply = Encoding.UTF8.GetBytes("REGISTER_FAILED");
                    stream.Write(reply, 0, reply.Length);
                    continue;
                }

                string userId = parts[0];
                string username = parts[1];
                string password = parts[2];

                if (users.UserExists(userId))
                {
                    byte[] reply = Encoding.UTF8.GetBytes("REGISTER_EXISTS");
                    stream.Write(reply, 0, reply.Length);
                    continue;
                }

                bool registered =
                    users.RegisterUser(userId, username, password);

                string response = registered
                    ? "REGISTER_SUCCESS"
                    : "REGISTER_FAILED";

                byte[] responseData =
                    Encoding.UTF8.GetBytes(response);

                stream.Write(responseData, 0, responseData.Length);

                continue;
            }
            //login
            if (message.StartsWith("LOGIN:"))
            {
                string data = message.Substring("LOGIN:".Length);

                string[] parts = data.Split('|', 2);

                if (parts.Length < 2)
                {
                    Console.WriteLine("Invalid LOGIN request: " + message);

                    byte[] reply = Encoding.UTF8.GetBytes("LOGIN_FAILED");
                    stream.Write(reply, 0, reply.Length);

                    continue;
                }

                string userId = parts[0];
                string password = parts[1];

                Console.WriteLine("Login attempt: " + userId);

                bool success = users.LoginUser(userId, password);

                if (success)
                {
                    Console.WriteLine("Login successful!");

                    connectedUsers[userId] = client;

                    byte[] reply = Encoding.UTF8.GetBytes("LOGIN_SUCCESS");
                    stream.Write(reply, 0, reply.Length); ;
                }
                else
                {
                    Console.WriteLine("Login failed!");

                    byte[] reply = Encoding.UTF8.GetBytes("LOGIN_FAILED");
                    stream.Write(reply, 0, reply.Length);
                }

                continue;
            }

            //SEND
            if (message.StartsWith("SEND_MESSAGE:"))
            {
                string data = message.Substring("SEND_MESSAGE:".Length);

                string[] parts = data.Split('|', 3);

                if (parts.Length < 3)
                    continue;

                string senderId = parts[0];
                string receiverId = parts[1];
                string messageText = parts[2];

                Console.WriteLine(
                    $"{senderId} -> {receiverId}: {messageText}");

                // Save message to SQL
                bool saved = messages.SaveMessage(
                    senderId,
                    receiverId,
                    messageText
                );

                if (!saved)
                {
                    Console.WriteLine("Failed to save message.");
                    continue;
                }

                // Send message to receiver
                if (connectedUsers.ContainsKey(receiverId))
                {
                    Console.WriteLine("Receiver found: " + receiverId);

                    TcpClient receiverClient = connectedUsers[receiverId];

                    NetworkStream receiverStream =receiverClient.GetStream();

                    string response =$"MESSAGE:{senderId}|{messageText}";

                    Console.WriteLine("Sending to receiver: " + response);

                    byte[] reply =Encoding.UTF8.GetBytes(response);

                    receiverStream.Write(reply, 0, reply.Length);
                }
                else
                {
                    Console.WriteLine("Receiver is NOT online: " + receiverId);
                }

                continue;
            }

            // search
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

            //other 
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

