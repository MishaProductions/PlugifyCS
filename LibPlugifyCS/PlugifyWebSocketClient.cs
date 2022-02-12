using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Control? dummy;
        public void Start()
        {
            client.ConnectAsync(new Uri(URL), CancellationToken.None);
            IsOpen = true;
            dummy = new Control();
            dummy.CreateControl();
            while (client.State != WebSocketState.Open) ;
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
                        dummy?.BeginInvoke(new Action(() => OnMessage.Invoke(this, message)));
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public async Task Send(string data) =>
    await client.SendAsync(Encoding.UTF8.GetBytes(data), WebSocketMessageType.Text, true, CancellationToken.None);
        public async Task<string?> Receive()
        {
            var buffer = new ArraySegment<byte>(new byte[2048]);
            do
            {
                WebSocketReceiveResult result;
                using (var ms = new MemoryStream())
                {
                    do
                    {
                        result = await client.ReceiveAsync(buffer, CancellationToken.None);
                        ms.Write(buffer.Array, buffer.Offset, result.Count);
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
            client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Normal closure", CancellationToken.None);
        }
    }
}
