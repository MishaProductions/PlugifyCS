using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace PlugifyClient
{
    public partial class LogonDialog : Form
    {
        public LogonDialog()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        WebSocket ws;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text))
            {
                lblToken.Text = "Token cannot be empty";
                lblToken.Visible = true;
            }
            else
            {
                // Log in
                ws = new WebSocket("wss://api.plugify.cf/");
                ws.OnMessage += Ws_OnMessage;
                ws.ConnectAsync();
                progressBar1.Visible = true;
            }
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            string s = "{\"event\": 1, \"data\": {\"token\": \"" + txtToken.Text + "\"}}";
            Console.WriteLine(e.Data);
            var obj = JObject.Parse(e.Data);
            dynamic d = obj;
            switch (obj.Value<int>("event"))
            {
                case 0:
                    ws.Send(s);
                    break;
                case 2:
                    // vaild token
                    Properties.Settings.Default.token = txtToken.Text;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    ws.Close();
                    lblToken.Invoke((MethodInvoker)delegate ()
                    {
                        Close();
                    });
                    break;
                case 3:
                    ws.Close();
                    lblToken.Invoke((MethodInvoker)delegate () { progressBar1.Visible = false;  lblToken.Text = d.data; lblToken.Visible = true; });
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
