using Newtonsoft.Json.Linq;
using PlugifyCS.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WebSocketSharp;

namespace PlugifyCS
{
    public partial class frmMain : Form
    {
        private WebSocket ws;
        private dynamic UserInfo;
        private dynamic Groups;
        private dynamic ChannelInfo;
        private dynamic ChannelDetails;
        private string CurrentChannelID = "";
        private string currentGroupID = "";
        private dynamic currentGroupObj = "";

        private Loading loadingForm = new Loading();
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);

            if (Properties.Settings.Default.Theme == "light")
            {
                pnlChannels.BackColor = Color.White;
                messagesPanel.BackColor = Color.White;
                pnlServers.BackColor = Color.White;
                pnlUserArea.BackColor = Color.White;
                pnlMessageContainer.BackColor = Color.White;
                messageSendArea.BackColor = Color.White;
                txtMessage.BackColor = Color.White;

                lblUserName.ForeColor = Color.Black;
                lblPing.ForeColor = Color.Black;
                messagesPanel.ForeColor = Color.Black;
                pnlMessageContainer.ForeColor = Color.Black;

                lblHome.ForeColor = Color.Black;
                lblNoChannel.ForeColor = Color.Black;
                txtMessage.ForeColor = Color.Black;
                lblGroupName.ForeColor = Color.Black;
            }
            else if (Properties.Settings.Default.Theme == "classic")
            {
                pnlChannels.BackColor = SystemColors.Control;
                messagesPanel.BackColor = SystemColors.Control;
                pnlServers.BackColor = SystemColors.Control;
                pnlUserArea.BackColor = SystemColors.Control;
                pnlMessageContainer.BackColor = SystemColors.Control;
                messageSendArea.BackColor = SystemColors.Control;
                txtMessage.BackColor = SystemColors.Control;

                lblUserName.ForeColor = Color.Black;
                lblPing.ForeColor = Color.Black;
                messagesPanel.ForeColor = Color.Black;
                pnlMessageContainer.ForeColor = Color.Black;

                lblHome.ForeColor = Color.Black;
                lblNoChannel.ForeColor = Color.Black;
                txtMessage.ForeColor = Color.Black;
                lblGroupName.ForeColor = Color.Black;

                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            }

            messageSendArea.Visible = false;
            pnlChannels.Visible = false;
            lblHome.Visible = true;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.token == "")
            {
                var login = new LogonDialog();
                login.ShowDialog();
            }
            progressBar1.Visible = true;
            ws = new WebSocket("wss://api.plugify.cf/");
            ws.OnMessage += Ws_OnMessage;
            ws.OnError += Ws_OnError;
            ws.OnClose += Ws_OnClose;

            ws.ConnectAsync();
            loadingForm.Show();
            BringToFront();

            while (UserInfo == null)
            {
                Application.DoEvents();
            }

            LoggedIn();
        }
        private void Ws_OnClose(object sender, CloseEventArgs e)
        {
            lblError.Text = "Connection closed: " + e.Reason;
            pnlError.Visible = false;
        }
        private void Ws_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            pnlError.Invoke((MethodInvoker)delegate ()
            {
                lblError.Text = e.Message;
                pnlError.Visible = true;
            });
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            string s = "{\"event\": 1, \"data\": {\"token\": \"" + Properties.Settings.Default.token + "\"}}";
            Console.WriteLine(e.Data);
            var obj = JObject.Parse(e.Data);
            dynamic d = obj;
            var eventID = obj.Value<int>("event");
            switch (eventID)
            {
                //WELCOME
                case 0:
                    ws.Send(s);
                    break;
                //AUTHENTICATE_SUCCESS
                case 2:
                    // vaild token

                    //Get groups
                    string s2 = "{\"event\":11,\"data\":null}";
                    ws.Send(s2);

                    UserInfo = d;
                    break;
                //AUTHENTICATE_ERROR
                case 3:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        loadingForm.Hide();
                        //We have an invaild token
                        ws.Close();
                        var login = new LogonDialog();
                        login.ShowDialog();
                    });
                    break;
                //CHANNEL_JOIN_SUCCESS
                case 5:
                    ChannelDetails = d;
                    break;
                //CHANNEL_JOIN_ERROR 
                case 6:
                    lblError.Text = "Error while joining channel";
                    pnlError.Visible = true;
                    break;
                //MESSAGE_SEND_SUCCESS
                case 8:
                    break;
                //MESSAGE_SEND_ERROR
                case 9:
                    break;
                //MESSAGE_NEW
                case 10:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        btnCreateOrJoinGroup.Visible = false;
                        var ctl = new MessageControl();
                        string dispname = d.data.author.displayName;
                        string name = d.data.author.name;
                        string content = d.data.content;

                        ctl.SetSettings("https://cds.plugify.cf/defaultAvatars/" + name, name + " (@" + dispname + ")", content, "WIP");
                        ctl.Size = new Size(messagesPanel.Width - 10, ctl.Height);
                        messagesPanel.Controls.Add(ctl);
                        btnCreateOrJoinGroup.Visible = true;
                    });
                    break;
                //GROUP_GET_SUCCESS
                case 12:
                    Groups = d;
                    break;
                //CHANNELS_GET_SUCCESS 
                case 14:
                    ChannelInfo = d;
                    break;
                //JOINED_NEW_GROUP
                case 15:
                    AddGroupToList(d.data);
                    break;






                //PING
                case 9001:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
        private void AddGroupToList(dynamic group)
        {
            PictureBox theGroup = new PictureBox();
            theGroup.Size = new Size(56, 56);
            theGroup.ImageLocation = "https://cds.plugify.cf/defaultAvatars/" + group.name;
            theGroup.SizeMode = PictureBoxSizeMode.StretchImage;
            theGroup.Tag = group;
            theGroup.InitialImage = Properties.Resources.plug;
            pnlServers.Controls.Remove(btnCreateOrJoinGroup);
            theGroup.Click += delegate (object sender, EventArgs e)
            {
                OpenGroup(group);
            };
            pnlServers.Controls.Add(theGroup);
            pnlServers.Controls.Add(btnCreateOrJoinGroup);
        }
        private void LoggedIn()
        {
            lblUserPFP.ImageLocation = "https://cds.plugify.cf/defaultAvatars/" + UserInfo.data.username;
            lblUserName.Text = UserInfo.data.username;
            lblPing.Text = "@" + UserInfo.data.username;

            //Get groups
            while (Groups == null)
            {
                Application.DoEvents();
            }

            progressBar1.Visible = false;

            foreach (var item in Groups.data)
            {
                AddGroupToList(item);
            }
            loadingForm.TopMost = false;
            loadingForm.Hide();
        }
        private void OpenGroup(dynamic group)
        {
            lblHome.Visible = false;
            //progressBar1.Visible = true;
            lblGroupName.Text = group.name;
            prgMessageLoading.Visible = false;
            pnlChannels.Controls.Clear();
            pnlChannels.Controls.Add(pnlGroupInfo);
            messagesPanel.Controls.Clear();
            messagesPanel.Controls.Add(lblHome);
            messagesPanel.Controls.Add(lblNoChannel);
            CurrentChannelID = "";
            currentGroupID = group.id;
            currentGroupObj = group;

            //Get group detail
            string s2 = "{\"event\":13,\"data\": {\"groupID\": \"" + group.id + "\"}}";
            ws.Send(s2);
            while (ChannelInfo == null)
            {
                Application.DoEvents();
            }
            //progressBar1.Visible = false;
            lblNoChannel.Visible = true;
            foreach (var item in ChannelInfo.data)
            {
                Label lbl = new Label();
                if (item.type == "text")
                    lbl.Text = "# - " + item.name;
                else
                {
                    lbl.Text = "?? - " + item.name;
                }
                lbl.Tag = item;
                if (Properties.Settings.Default.Theme == "light" || Properties.Settings.Default.Theme == "classic")
                    lbl.ForeColor = Color.Black;
                else
                    lbl.ForeColor = Color.White;

                lbl.Click += delegate (object sender, EventArgs e)
                 {
                     lblNoChannel.Visible = false;
                     prgMessageLoading.Visible = true;
                     CurrentChannelID = item.id;
                     messagesPanel.Controls.Clear();
                     messagesPanel.Controls.Add(lblHome);
                     messagesPanel.Controls.Add(lblNoChannel);
                     foreach (Control c in pnlChannels.Controls)
                     {
                         c.BackColor = Color.Transparent;
                     }
                     lbl.BackColor = Color.DodgerBlue;

                     //Get channel details
                     string s3 = "{\"event\":4,\"data\": {\"id\": \"" + ((string)item.id).TrimStart('{').TrimEnd('}') + "\"}}";
                     ws.Send(s3);

                     while (ChannelDetails == null)
                     {
                         Application.DoEvents();
                     }
                     foreach (var message in ChannelDetails.data.history)
                     {
                         var ctl = new MessageControl();
                         string dispname = message.author.displayName;
                         string name = message.author.name;
                         string content = message.content;

                         ctl.SetSettings("https://cds.plugify.cf/defaultAvatars/" + name, name + " (@" + dispname + ")", content, "WIP");
                         ctl.Size = new Size(messagesPanel.Width - 25, ctl.Height);
                         messagesPanel.Controls.Add(ctl);
                     }
                     ChannelDetails = null;
                     prgMessageLoading.Visible = false;
                 };
                pnlChannels.Controls.Add(lbl);
            }
            pnlChannels.Controls.Add(btnCreateChannel);
            ChannelInfo = null;
            messageSendArea.Visible = true;
            pnlChannels.Visible = true;
            lblHome.Visible = false;
        }
        private void btnErrorClose_Click(object sender, EventArgs e)
        {
            pnlError.Visible = false;
        }
        private void textboxControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }
        private void SendMessage()
        {
            string messageContents = txtMessage.Text;
            txtMessage.Text = "";

            string s3 = "{\"event\":7,\"data\": {\"content\": \"" + messageContents.TrimStart('{').TrimEnd('}') + "\", \"channelID\": \"" + CurrentChannelID + "\"}}";
            ws.Send(s3);
            txtMessage.Text = "";
        }
        private void tmrPing_Tick(object sender, EventArgs e)
        {
            if (ws != null)
            {
                if (ws.IsAlive)
                {
                    string s3 = "{\"event\":9001}";
                    ws.Send(s3);
                }
            }
        }
        private void btnCreateChannel_Click(object sender, EventArgs e)
        {
            if (new Random().Next(0, 3) == 1 && Properties.Settings.Default.Ad)
            {
                new Advertisment().ShowDialog();
            }
            var d = new CreateNewChannel();
            if (d.ShowDialog() == DialogResult.OK)
            {
                var json = ApiPost("https://api.plugify.cf/v2/channels/create", "{\"name\": \"" + d.Result + "\", \"groupID\": \"" + currentGroupID + "\", \"type\": \"text\"}");
                if ((bool)json.success)
                {
                    OpenGroup(currentGroupObj); //refresh group list
                }
                else
                {
                    MessageBox.Show("Error while creating channel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            messageSendArea.Visible = false;
            pnlChannels.Visible = false;
            lblHome.Visible = true;
            CurrentChannelID = "";
            currentGroupID = "";
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }
        private void btnSendMSG_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            foreach (Control item in messagesPanel.Controls)
            {
                if (item is MessageControl c)
                {
                    c.Size = new Size(messagesPanel.Width - 25, c.Size.Height);
                }
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPing.Stop();
            if (ws != null)
                ws.Close();
            Application.Exit();
            Environment.Exit(0);
        }

        //https://stackoverflow.com/a/77233/11250752
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
        private dynamic ApiPost(string url, string content)
        {
            var webRequest = System.Net.WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("Authorization", Properties.Settings.Default.token);

            //write the input data (aka post) to a byte array
            byte[] requestBytes = new ASCIIEncoding().GetBytes(content);
            //get the request stream to write the post to
            Stream requestStream = webRequest.GetRequestStream();
            //write the post to the request stream
            requestStream.Write(requestBytes, 0, requestBytes.Length);
            WebResponse r = null;
            try
            {
                r = webRequest.GetResponse();
            }
            catch (WebException e)
            {
                r = e.Response;
            }

            using (System.IO.Stream s = r.GetResponseStream())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                {
                    var jsonResponse = sr.ReadToEnd();
                    return JObject.Parse(jsonResponse);
                }
            }
        }

        private void btnCreateOrJoinGroup_Click(object sender, EventArgs e)
        {
            var dlg = new InviteDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.Result2)
                {
                    var result = ApiPost("https://api.plugify.cf/v2/invites/use", "{\"id\": \"" + dlg.Result1 + "\"}");
                    if ((bool)result.error)
                    {
                        MessageBox.Show("Invaild invite or server error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var result = ApiPost("https://api.plugify.cf/v2/groups/create", "{\"name\": \"" + dlg.Result1 + "\"}");
                    if (!(bool)result.success)
                    {
                        MessageBox.Show("Unkown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        result.name = dlg.Result1;
                        result.id = result.data.id;
                        AddGroupToList(result);
                    }
                }
            }
        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implmented in plugify backend.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGroupSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
