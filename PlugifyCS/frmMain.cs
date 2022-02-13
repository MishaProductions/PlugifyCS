using LibPlugifyCS;
using Markdig;
using Newtonsoft.Json.Linq;
using PlugifyCS.Controls;
using PlugifyCS.Dialogs;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using WebSocketSharp;

namespace PlugifyCS
{
    public partial class frmMain : Form
    {
        private static readonly TwemojiSharp.TwemojiLib lib = new TwemojiSharp.TwemojiLib();
        private readonly Loading loadingForm = new Loading();

        private dynamic ChannelInfo;
        private dynamic ChannelDetails;
        private PlugifyGroup currentGroupObj;

        private string CurrentChannelID = "";
        private string currentGroupID = "";
        internal PlugifyCSClient client = new PlugifyCSClient();
        ElementHost HomeView;
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
                pnlChannelTopBar.BackColor = Color.White;
                pnlMemberList.BackColor = Color.White;

                lblUserName.ForeColor = Color.Black;
                lblPing.ForeColor = Color.Black;
                messagesPanel.ForeColor = Color.Black;
                pnlMessageContainer.ForeColor = Color.Black;

                lblNoChannel.ForeColor = Color.Black;
                txtMessage.ForeColor = Color.Black;
                lblGroupName.ForeColor = Color.Black;
                btnCreateChannel.ForeColor = Color.Black;
                btnSendMSG.ForeColor = Color.Black;
                lblMembersListTitle.ForeColor = Color.Black;
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
                pnlChannelTopBar.BackColor = SystemColors.Control;
                pnlMemberList.BackColor = SystemColors.Control;

                lblUserName.ForeColor = Color.Black;
                lblPing.ForeColor = Color.Black;
                messagesPanel.ForeColor = Color.Black;
                pnlMessageContainer.ForeColor = Color.Black;

                lblNoChannel.ForeColor = Color.Black;
                txtMessage.ForeColor = Color.Black;
                lblGroupName.ForeColor = Color.Black;
                btnCreateChannel.ForeColor = Color.Black;
                btnSendMSG.ForeColor = Color.Black;
                lblMembersListTitle.ForeColor = Color.Black;

                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            }


            messageSendArea.Visible = false;
            pnlChannels.Visible = false;
            btnHome_Click(null, null);
        }
        #region Native Windows apis
        [DllImport("dwmapi.dll", PreserveSig = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, uint attr, ref uint attrValue, int attrSize);
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public extern static int SetWindowTheme(IntPtr hWnd, string
                                           pszSubAppName, string pszSubIdList);
        #endregion
        private async void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                //Make sure we are using windows
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    try
                    {
                        uint a = 1;
                        //19: DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1
                        //20: DWMWA_USE_IMMERSIVE_DARK_MODE

                        var ret = DwmSetWindowAttribute(this.Handle, 20, ref a, Marshal.SizeOf(typeof(bool)));
                        if (ret != 0)
                        {
                            //older versions of windows 10
                            ret = DwmSetWindowAttribute(this.Handle, 19, ref a, Marshal.SizeOf(typeof(bool)));
                        }
                        SetWindowTheme(messagesPanel.Handle, "DarkMode_Explorer", null);
                        SetWindowTheme(pnlMemberList.Handle, "DarkMode_Explorer", null);
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            if (Properties.Settings.Default.token == "")
            {
                var login = new LogonDialog();
                login.ShowDialog();
            }

            //register events
            client.OnGroupRemoved += Client_OnGroupRemoved;
            client.OnGroupJoin += Client_OnGroupJoin;

            await client.Start(Properties.Settings.Default.token);
            loadingForm.Show();
            BringToFront();
            LoggedIn();
        }

        private void Client_OnGroupJoin(dynamic data)
        {
            AddGroupToList(PlugifyCSClient.GroupFromStructure(data.group));
        }

        private void Client_OnGroupRemoved(dynamic data)
        {
            foreach (var item in pnlServers.Controls)
            {
                if (item is RoundPicture p)
                {
                    if (p.Tag is PlugifyGroup g)
                    {
                        if (g.ID == (string)data.id)
                        {
                            p.Dispose();
                            break;
                        }
                    }
                }
            }

            if ((string)data.id == currentGroupID)
            {
                btnHome_Click(null, null);
            }
        }

        private void AddGroupToList(PlugifyGroup group)
        {
            RoundPicture theGroup = new RoundPicture();
            theGroup.Size = new Size(56, 56);
            theGroup.BackgroundImageLayout = ImageLayout.Stretch;
            theGroup.SetURL((string)group.ID, (string)group.ImageURL);
            theGroup.Tag = group;
            theGroup.IsGoodLookingButton = true;

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
            // we need to cast this to a string because c# is stupid
            lblUserPFP.SetURL(client.CurrentUser.PFPUrl, client.CurrentUser.UserName, 0);
            lblUserName.Text = client.CurrentUser.UserName;
            lblPing.Text = "@" + client.CurrentUser.UserName;
            pnlServers.Controls.Clear();
            pnlServers.Controls.Add(btnCreateOrJoinGroup);
            foreach (var item in client.Groups)
            {
                AddGroupToList(item);
            }
            loadingForm.TopMost = false;
            loadingForm.Hide();
        }
        private async void OpenGroup(PlugifyGroup group)
        {
            HomeView.Visible = false;
            //progressBar1.Visible = true;
            lblGroupName.Text = group.Name;
            prgMessageLoading.Visible = false;
            pnlChannels.Controls.Clear();
            pnlChannels.Controls.Add(pnlGroupInfo);
            messagesPanel.Controls.Clear();
            messagesPanel.Controls.Add(HomeView);
            messagesPanel.Controls.Add(lblNoChannel);
            CurrentChannelID = "";
            currentGroupID = group.ID;
            currentGroupObj = group;
            pnlChannelTopBar.Visible = true;
            pnlMemberList.Visible = false;

            pnlMemberList.Controls.Clear();
            pnlMemberList.Controls.Add(panel1);

            ChannelInfo = await client.GetGroupInfo(group.ID);

            btnLeaveGroup.Visible = group.OwnerUsername != client.CurrentUser?.UserName;

            //progressBar1.Visible = false;
            lblNoChannel.Visible = true;
            foreach (var item in ChannelInfo.data)
            {
                ChannelControl lbl = new ChannelControl();
                if (item.type == "text")
                    lbl.Text = "#" + item.name;
                else
                {
                    lbl.Text = "?? - " + item.name;
                }
                lbl.Tag = item;
                if (Properties.Settings.Default.Theme == "light" || Properties.Settings.Default.Theme == "classic")
                    lbl.ForeColor = Color.Black;
                else
                    lbl.ForeColor = Color.White;
                lbl.AutoSize = false;
                lbl.AutoEllipsis = true;
                lbl.Size = new Size(pnlChannels.Width, lbl.Size.Height);

                lbl.Click += async delegate (object? sender, EventArgs e)
                 {
                     lblNoChannel.Visible = false;
                     prgMessageLoading.Visible = true;
                     pnlMemberList.Visible = true;
                     CurrentChannelID = item.id;
                     messagesPanel.Controls.Clear();
                     messagesPanel.Controls.Add(HomeView);
                     messagesPanel.Controls.Add(lblNoChannel);
                     pnlMemberList.Controls.Clear();
                     foreach (Control c in pnlChannels.Controls)
                     {
                         c.BackColor = Color.Transparent;
                     }
                     lbl.BackColor = Color.DodgerBlue;


                     ChannelDetails = await client.GetChannelDetails(((string)item.id));


                     foreach (var message in ChannelDetails.data.history)
                     {
                         AddMessage(message);
                     }
                     var groupInfo = ApiGet("https://api.plugify.cf/v2/groups/" + currentGroupID + "/members");

                     if (!(bool)groupInfo.success)
                     {
                         pnlMemberList.Visible = false;
                         MessageBox.Show("Error while loading member list: " + PlugifyErrorCode.Tostring((int)groupInfo.error));
                     }
                     else
                     {
                         foreach (var member in groupInfo.data.members)
                         {
                             var ctl2 = new MemberListItem();
                             ctl2.ApplyProperties((string)member.user, (string)member.nickname, (string)member.avatarURL);
                             ctl2.Size = new Size(pnlMemberList.Width - 50, ctl2.Height);
                             pnlMemberList.Controls.Add(ctl2);
                         }
                     }
                     prgMessageLoading.Visible = false;
                 };
                pnlChannels.Controls.Add(lbl);
            }
            pnlChannels.Controls.Add(btnCreateChannel);
            messageSendArea.Visible = true;
            pnlChannels.Visible = true;
            HomeView.Visible = false;

            messagesPanel.Visible = true;
        }
        private void AddMessage(dynamic message)
        {
            var pipeline = new MarkdownPipelineBuilder().UseListExtras().UseAutoLinks().UseTaskLists().Build();
            var ctl = new MessageControl();
            string dispname = message.author.displayName;
            string name = message.author.name;
            string content = message.content;
            var properString = name + " (@" + dispname + ")";

            var html = Markdown.ToHtml(content, pipeline);
            if (html.Length != 0)
                html = html.Remove(html.Length - 1); //remove \n



            var Emotes = lib.Parse(html);

            ctl.SetSettings(name, properString, Emotes, "WIP", (string)message.author.avatarURL);
            ctl.Size = new Size(messagesPanel.Width - 25, ctl.Height);
            messagesPanel.Controls.Add(ctl);
        }
        private void textboxControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMessage.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }
        private async void SendMessage()
        {
            string messageContents = txtMessage.Text;
            txtMessage.Text = "";


            await client.SendMessage(messageContents.TrimStart('{').TrimEnd('}'), CurrentChannelID);
            txtMessage.Clear();
        }
        private void tmrPing_Tick(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.SendPing();
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
                var json = ApiPost("https://api.plugify.cf/v2/channels/" + currentGroupID, "{\"name\": \"" + d.Result + "\", \"description\": null, \"type\": \"text\"}");
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
            ShowHomeView();
        }
        private void ShowHomeView()
        {
            ShowPage(new XAML.HomePG());
        }
        private void ShowPage(System.Windows.Controls.Page p, bool showChannelView = false)
        {
            HomeView = new ElementHost();
            HomeView.Dock = DockStyle.Fill;
            var f = new System.Windows.Controls.Frame();
            f.Navigate(p);
            HomeView.Child = f;

            messageSendArea.Visible = false;
            pnlChannels.Visible = showChannelView;
            pnlChannelTopBar.Visible = showChannelView;
            pnlMemberList.Visible = false;
            lblNoChannel.Visible = false;
            if (!showChannelView)
            {
                CurrentChannelID = "";
                currentGroupID = "";
            }

            //hide messages view
            messagesPanel.Visible = false;

            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(messagesPanel);
            pnlMainView.Controls.Add(HomeView);



            messagesPanel.Controls.Clear();
            messagesPanel.Controls.Add(lblNoChannel);
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
            //foreach (Control item in messagesPanel.Controls)
            //{
            //    if (item is MessageControl c)
            //    {
            //        c.Size = new Size(messagesPanel.Width - 25, c.Size.Height);
            //    }
            //}
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPing.Stop();
            client.Close();

            Application.Exit();
        }

        #region Utils
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
        public static dynamic ApiPost(string url, string content)
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
            WebResponse r;
            try
            {
                r = webRequest.GetResponse();
            }
            catch (WebException e)
            {
                r = e.Response;
            }

            using (Stream s = r.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    var jsonResponse = sr.ReadToEnd();
                    return JObject.Parse(jsonResponse);
                }
            }
        }
        public static dynamic ApiGet(string url)
        {
            var webRequest = System.Net.WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("Authorization", Properties.Settings.Default.token);

            WebResponse r;
            try
            {
                r = webRequest.GetResponse();
            }
            catch (WebException e)
            {
                r = e.Response;
            }

            using (Stream s = r.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    var jsonResponse = sr.ReadToEnd();
                    return JObject.Parse(jsonResponse);
                }
            }
        }
        public static dynamic ApiDelete(string url)
        {
            var webRequest = System.Net.WebRequest.Create(url);
            webRequest.Method = "DELETE";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("Authorization", Properties.Settings.Default.token);

            WebResponse r;
            try
            {
                r = webRequest.GetResponse();
            }
            catch (WebException e)
            {
                r = e.Response;
            }

            using (Stream s = r.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    var jsonResponse = sr.ReadToEnd();
                    return JObject.Parse(jsonResponse);
                }
            }
        }
        #endregion

        private async void btnCreateOrJoinGroup_Click(object sender, EventArgs e)
        {
            var dlg = new InviteDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.Result2)
                {
                    var result = ApiPost("https://api.plugify.cf/v2/invites/use/" + dlg.Result1, "{\"id\": \"" + dlg.Result1 + "\"}");
                    if (!(bool)result.success)
                    {
                        MessageBox.Show("Error: " + PlugifyErrorCode.Tostring((int)result.error), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var result = ApiPost("https://api.plugify.cf/v2/groups/", "{\"name\": \"" + dlg.Result1 + "\"}");
                    if (!(bool)result.success)
                    {
                        MessageBox.Show("Error: " + PlugifyErrorCode.Tostring((int)result.error), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Refresh server list
                        await client.RefreshGroupsArray();
                        LoggedIn();
                    }
                }
            }
        }

        private void btnLeaveGroup_Click(object sender, EventArgs e)
        {
            var h = MessageBox.Show("Are you sure you want to leave this group?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                var i = ApiDelete("https://api.plugify.cf/v2/members/" + currentGroupID + "/" + client.CurrentUser?.UserName);
                if (!(bool)i.success)
                {
                    MessageBox.Show("A error occured while leaving this group. Error Code: " + PlugifyErrorCode.Tostring((int)i.error), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGroupSettings_Click(object sender, EventArgs e)
        {

            DisplayServerSettings(currentGroupID);
        }

        private void lblGroupName_Click(object sender, EventArgs e)
        {
            Label btnSender = (Label)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }

        private void leaveGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLeaveGroup_Click(null, null);
        }

        private void serverSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayServerSettings(currentGroupID);
        }
        private void DisplayServerSettings(string GroupID)
        {
            if (Properties.Settings.Default.EnableXAML)
            {
                ShowPage(new XAML.ServerSettings(GroupID, this), true);
            }
            else
            {
                var dlg = new ServerSettingsDialog(GroupID, this);
                dlg.ShowDialog();
            }
        }

        private void invitePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EnableXAML)
            {
                new XAML.CreateInviteWindow(currentGroupID).ShowDialog();
            }
            else
            {
                new CreateInviteDialog(currentGroupID).ShowDialog();
            }
        }
    }
}
