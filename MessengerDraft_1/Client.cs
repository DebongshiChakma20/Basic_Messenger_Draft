using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class Client
{
    private TcpClient? client;
    private NetworkStream? stream;
    private bool listening = false;

    public event Action<string>? MessageReceived;

    public void Connect()
    {
        try
        {
            if (client != null && client.Connected)
                return;

            client = new TcpClient();

            client.Connect("127.0.0.1", 5000);

            stream = client.GetStream();

            MessageBox.Show("Connected to Messenger Server.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Connection error: " + ex.Message);
        }
    }

    public void Send(string message)
    {
        try
        {
            if (client == null || stream == null || !client.Connected)
            {
                MessageBox.Show("Client is NOT connected.");
                return;
            }

            byte[] data = Encoding.UTF8.GetBytes(message);

            stream.Write(data, 0, data.Length);
            stream.Flush();

            Console.WriteLine("Sent: " + message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Send error: " + ex.Message);
        }
    }

    public string ReceiveMessage()
    {
        try
        {
            if (stream == null)
                return "";

            byte[] buffer = new byte[1024];

            int bytesRead = stream.Read(buffer, 0, buffer.Length);

            if (bytesRead == 0)
                return "";

            string message =
                Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Console.WriteLine("Client received: " + message);

            return message;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Receive error: " + ex.Message);
            return "";
        }
    }

    public void StartListening()
    {
        if (listening)
            return;

        listening = true;

        Thread thread = new Thread(() =>
        {
            while (listening && client != null && client.Connected)
            {
                string message = ReceiveMessage();

                if (!string.IsNullOrEmpty(message))
                {
                    MessageReceived?.Invoke(message);
                }
            }

            listening = false;
        });

        thread.IsBackground = true;
        thread.Start();
    }

    public void Disconnect()
    {
        listening = false;

        try
        {
            stream?.Close();
            client?.Close();
        }
        catch
        {
        }

        stream = null;
        client = null;
    }
}