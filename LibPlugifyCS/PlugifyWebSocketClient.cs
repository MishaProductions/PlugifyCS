using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LibPlugifyCS
{
    public class PlugifyWebSocketClient
    {
        private string URL;
        public bool IsOpen { get; set; }
        private ClientWebSocket client = new ClientWebSocket();
        public event EventHandler<string> OnMessage;

        public PlugifyWebSocketClient(string url)
        {
            this.URL = url;

        }
        public async Task Start()
        {
            await client.ConnectAsync(new Uri(URL), CancellationToken.None);
            IsOpen = true;
            while (client.State != WebSocketState.Open)
            {
                await Task.Delay(1);
            }
            Thread bgThread = new Thread(new ThreadStart(BackgroundThread));
            bgThread.Start();
        }

        private async void BackgroundThread()
        {
            while (true)
            {
                if (client.State == WebSocketState.Open | client.State == WebSocketState.CloseSent)
                {
                    var message = await Receive();
                    if (message != null)
                    {
                        OnMessage.Invoke(this, message);
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public async Task Send(string data)
        {
            Console.WriteLine("TX: "+data);
            await client.SendAsync(Encoding.UTF8.GetBytes(data), WebSocketMessageType.Text, true, CancellationToken.None);

        }
        public async Task<string?> Receive()
        {
            var buffer = new ArraySegment<byte>(new byte[2048]);
            do
            {
                WebSocketReceiveResult result = null;
                using (var ms = new MemoryStream())
                {
                    do
                    {
                        try
                        {
                            result = await client.ReceiveAsync(buffer, CancellationToken.None);
                            ms.Write(buffer.Array, buffer.Offset, result.Count);
                        }
                        catch
                        {
                            IsOpen = false;
                            break;
                        }
                    } while (!result.EndOfMessage);

                    if (result.MessageType == WebSocketMessageType.Close)
                        break;

                    ms.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(ms, Encoding.UTF8))
                        return await reader.ReadToEndAsync();
                }
            } while (true);
            IsOpen = false;
            return null;
        }

        public void Close()
        {
            if (client != null)
            {
                try
                {
                    client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Normal closure", CancellationToken.None);
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }
    }
}
