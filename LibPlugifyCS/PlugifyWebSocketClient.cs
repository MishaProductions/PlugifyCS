using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Uno.Wasm.WebSockets;

namespace LibPlugifyCS
{
    public class PlugifyWebSocketClient
    {
        private string URL;
        public bool IsOpen { get; set; }
        private ClientWebSocket client = new ClientWebSocket();
        public event EventHandler<string>? OnMessage;

        public PlugifyWebSocketClient(string url)
        {
            this.URL = url;

        }
        public async Task Start()
        {
            await client.ConnectAsync(new Uri(URL), CancellationToken.None);
            IsOpen = true;
            Thread bgThread = new Thread(new ThreadStart(BackgroundThread));
            bgThread.Start();
        }

        private async void BackgroundThread()
        {
            while (true)
            {
                Console.WriteLine("tick");
                if (client.State == WebSocketState.Open | client.State == WebSocketState.CloseSent)
                {
                    var message = await Receive();
                    Console.WriteLine("a");
                    if (message != null)
                    {
                        if (OnMessage != null)
                            OnMessage.Invoke(this, message);
                        Console.WriteLine("b");
                    }
                }
                else
                {
                    Console.WriteLine("web socket closed");
                    break;
                }
            }
        }
        public async Task Send(string data)
        {
            Console.WriteLine("TX: " + data);
            await client.SendAsync(Encoding.UTF8.GetBytes(data), WebSocketMessageType.Text, true, CancellationToken.None);

        }
        public async Task<string?> Receive()
        {
            var buffer = new ArraySegment<byte>(new byte[2048]);
            do
            {
                Console.WriteLine("1");
                WebSocketReceiveResult? result = null;
                using (var ms = new MemoryStream())
                {
                    do
                    {
                        Console.WriteLine("2");
                        result = await client.ReceiveAsync(buffer, CancellationToken.None);
                        Console.WriteLine("2.5");
                        ms.Write(buffer.Array, buffer.Offset, result.Count);
                        Console.WriteLine("3");
                    } while (!result.EndOfMessage);
                    Console.WriteLine("4");
                    if (result.MessageType == WebSocketMessageType.Close)
                        break;
                    Console.WriteLine("5");
                    ms.Seek(0, SeekOrigin.Begin);
                    Console.WriteLine("6");
                    using (var reader = new StreamReader(ms, Encoding.UTF8))
                        return await reader.ReadToEndAsync();
                }
            } while (true);
            Console.WriteLine("websocket closed");
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
