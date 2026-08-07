using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    private TcpClient client;
    private NetworkStream stream;

    public void Connect()
    {
        client = new TcpClient();

        client.Connect("127.0.0.1", 5000);

        stream = client.GetStream();
    }


    public void Send(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);

        stream.Write(data, 0, data.Length);
    }

    public string ReceiveMessage()
    {
        try
        {
            byte[] buffer = new byte[1024];

            int bytesRead = stream.Read(buffer, 0, buffer.Length);

            if (bytesRead == 0)
                return "";

            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }
        catch (Exception ex) {
            return  "";
        }
    }

    public event Action<string>? MessageReceived;

    public void StartListening()
    {
        Task.Run(() =>
        {
            while (client.Connected)
            {
                string message = ReceiveMessage();

                if (!string.IsNullOrEmpty(message))
                {
                    MessageReceived?.Invoke(message);
                }
            }
        });
    }

    public void Disconnect()
    {
        stream?.Close();

        client?.Close();
    }
}
