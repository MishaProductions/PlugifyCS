
namespace PlugifyCS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlServerArea = new System.Windows.Forms.Panel();
            this.pnlServers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateOrJoinGroup = new PlugifyCS.Controls.RoundButton();
            this.pnlUserArea = new System.Windows.Forms.Panel();
            this.lblUserPFP = new PlugifyCS.Controls.RoundPicture();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblPing = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ServerContent = new System.Windows.Forms.Panel();
            this.pnlMessageContainer = new System.Windows.Forms.Panel();
            this.messagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblNoChannel = new System.Windows.Forms.Label();
            this.pnlChannelTopBar = new System.Windows.Forms.Panel();
            this.messageSendArea = new System.Windows.Forms.Panel();
            this.btnSendMSG = new System.Windows.Forms.Button();
            this.txtMessage = new PlugifyCS.TextboxControl();
            this.prgMessageLoading = new System.Windows.Forms.ProgressBar();
            this.pnlMemberList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMembersListTitle = new System.Windows.Forms.Label();
            this.pnlChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGroupInfo = new System.Windows.Forms.Panel();
            this.btnLeaveGroup = new System.Windows.Forms.Button();
            this.btnGroupSettings = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.btnCreateChannel = new System.Windows.Forms.Button();
            this.pnlError = new System.Windows.Forms.Panel();
            this.btnErrorClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrPing = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlServerArea.SuspendLayout();
            this.pnlServers.SuspendLayout();
            this.pnlUserArea.SuspendLayout();
            this.ServerContent.SuspendLayout();
            this.pnlMessageContainer.SuspendLayout();
            this.messagesPanel.SuspendLayout();
            this.messageSendArea.SuspendLayout();
            this.pnlMemberList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlChannels.SuspendLayout();
            this.pnlGroupInfo.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // pnlServerArea
            // 
            this.pnlServerArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.pnlServerArea.Controls.Add(this.pnlServers);
            this.pnlServerArea.Controls.Add(this.pnlUserArea);
            this.pnlServerArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServerArea.Location = new System.Drawing.Point(0, 57);
            this.pnlServerArea.Name = "pnlServerArea";
            this.pnlServerArea.Size = new System.Drawing.Size(800, 62);
            this.pnlServerArea.TabIndex = 1;
            // 
            // pnlServers
            // 
            this.pnlServers.Controls.Add(this.btnCreateOrJoinGroup);
            this.pnlServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServers.Location = new System.Drawing.Point(0, 0);
            this.pnlServers.Name = "pnlServers";
            this.pnlServers.Size = new System.Drawing.Size(545, 62);
            this.pnlServers.TabIndex = 0;
            // 
            // btnCreateOrJoinGroup
            // 
            this.btnCreateOrJoinGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateOrJoinGroup.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.btnCreateOrJoinGroup.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrJoinGroup.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrJoinGroup.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.btnCreateOrJoinGroup.Location = new System.Drawing.Point(3, 3);
            this.btnCreateOrJoinGroup.Name = "btnCreateOrJoinGroup";
            this.btnCreateOrJoinGroup.Size = new System.Drawing.Size(58, 58);
            this.btnCreateOrJoinGroup.TabIndex = 2;
            this.btnCreateOrJoinGroup.Text = "+";
            this.btnCreateOrJoinGroup.Click += new System.EventHandler(this.btnCreateOrJoinGroup_Click);
            // 
            // pnlUserArea
            // 
            this.pnlUserArea.Controls.Add(this.lblUserPFP);
            this.pnlUserArea.Controls.Add(this.btnHome);
            this.pnlUserArea.Controls.Add(this.btnSettings);
            this.pnlUserArea.Controls.Add(this.lblPing);
            this.pnlUserArea.Controls.Add(this.lblUserName);
            this.pnlUserArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserArea.Location = new System.Drawing.Point(545, 0);
            this.pnlUserArea.Name = "pnlUserArea";
            this.pnlUserArea.Size = new System.Drawing.Size(255, 62);
            this.pnlUserArea.TabIndex = 1;
            // 
            // lblUserPFP
            // 
            this.lblUserPFP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblUserPFP.Location = new System.Drawing.Point(7, 0);
            this.lblUserPFP.Name = "lblUserPFP";
            this.lblUserPFP.Size = new System.Drawing.Size(56, 56);
            this.lblUserPFP.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackgroundImage = global::PlugifyCS.Properties.Resources.house_1f3e0;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(226, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(24, 24);
            this.btnHome.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnHome, "Home");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackgroundImage = global::PlugifyCS.Properties.Resources.gear_2699_fe0f;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(196, 22);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPing.ForeColor = System.Drawing.Color.White;
            this.lblPing.Location = new System.Drawing.Point(70, 27);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(58, 13);
            this.lblPing.TabIndex = 2;
            this.lblPing.Text = "@loading";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(69, 3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Loading....";
            // 
            // ServerContent
            // 
            this.ServerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.ServerContent.Controls.Add(this.pnlMessageContainer);
            this.ServerContent.Controls.Add(this.pnlMemberList);
            this.ServerContent.Controls.Add(this.pnlChannels);
            this.ServerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerContent.Location = new System.Drawing.Point(0, 119);
            this.ServerContent.Name = "ServerContent";
            this.ServerContent.Size = new System.Drawing.Size(800, 331);
            this.ServerContent.TabIndex = 2;
            // 
            // pnlMessageContainer
            // 
            this.pnlMessageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.pnlMessageContainer.Controls.Add(this.messagesPanel);
            this.pnlMessageContainer.Controls.Add(this.pnlChannelTopBar);
            this.pnlMessageContainer.Controls.Add(this.messageSendArea);
            this.pnlMessageContainer.Controls.Add(this.prgMessageLoading);
            this.pnlMessageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessageContainer.Location = new System.Drawing.Point(149, 0);
            this.pnlMessageContainer.Name = "pnlMessageContainer";
            this.pnlMessageContainer.Size = new System.Drawing.Size(439, 331);
            this.pnlMessageContainer.TabIndex = 2;
            // 
            // messagesPanel
            // 
            this.messagesPanel.AutoScroll = true;
            this.messagesPanel.Controls.Add(this.lblHome);
            this.messagesPanel.Controls.Add(this.lblNoChannel);
            this.messagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messagesPanel.Location = new System.Drawing.Point(0, 75);
            this.messagesPanel.Name = "messagesPanel";
            this.messagesPanel.Size = new System.Drawing.Size(439, 191);
            this.messagesPanel.TabIndex = 6;
            this.messagesPanel.WrapContents = false;
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(3, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(349, 32);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home page under construction";
            // 
            // lblNoChannel
            // 
            this.lblNoChannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoChannel.AutoSize = true;
            this.lblNoChannel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChannel.ForeColor = System.Drawing.Color.White;
            this.lblNoChannel.Location = new System.Drawing.Point(61, 32);
            this.lblNoChannel.Name = "lblNoChannel";
            this.lblNoChannel.Size = new System.Drawing.Size(233, 32);
            this.lblNoChannel.TabIndex = 1;
            this.lblNoChannel.Text = "No channel selected";
            this.lblNoChannel.Visible = false;
            // 
            // pnlChannelTopBar
            // 
            this.pnlChannelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlChannelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChannelTopBar.Location = new System.Drawing.Point(0, 23);
            this.pnlChannelTopBar.Name = "pnlChannelTopBar";
            this.pnlChannelTopBar.Size = new System.Drawing.Size(439, 52);
            this.pnlChannelTopBar.TabIndex = 5;
            this.pnlChannelTopBar.Visible = false;
            // 
            // messageSendArea
            // 
            this.messageSendArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.messageSendArea.Controls.Add(this.btnSendMSG);
            this.messageSendArea.Controls.Add(this.txtMessage);
            this.messageSendArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageSendArea.Location = new System.Drawing.Point(0, 266);
            this.messageSendArea.Name = "messageSendArea";
            this.messageSendArea.Size = new System.Drawing.Size(439, 65);
            this.messageSendArea.TabIndex = 4;
            // 
            // btnSendMSG
            // 
            this.btnSendMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMSG.FlatAppearance.BorderSize = 0;
            this.btnSendMSG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMSG.ForeColor = System.Drawing.Color.White;
            this.btnSendMSG.Location = new System.Drawing.Point(348, 7);
            this.btnSendMSG.Name = "btnSendMSG";
            this.btnSendMSG.Size = new System.Drawing.Size(88, 46);
            this.btnSendMSG.TabIndex = 1;
            this.btnSendMSG.Text = "Send";
            this.btnSendMSG.UseVisualStyleBackColor = true;
            this.btnSendMSG.Click += new System.EventHandler(this.btnSendMSG_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Cue = "Enter a message...";
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(9, 7);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(332, 46);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxControl1_KeyDown);
            // 
            // prgMessageLoading
            // 
            this.prgMessageLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgMessageLoading.Location = new System.Drawing.Point(0, 0);
            this.prgMessageLoading.MarqueeAnimationSpeed = 10;
            this.prgMessageLoading.Name = "prgMessageLoading";
            this.prgMessageLoading.Size = new System.Drawing.Size(439, 23);
            this.prgMessageLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMessageLoading.TabIndex = 2;
            this.prgMessageLoading.Visible = false;
            // 
            // pnlMemberList
            // 
            this.pnlMemberList.AutoScroll = true;
            this.pnlMemberList.Controls.Add(this.panel1);
            this.pnlMemberList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMemberList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMemberList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMemberList.Location = new System.Drawing.Point(588, 0);
            this.pnlMemberList.Name = "pnlMemberList";
            this.pnlMemberList.Size = new System.Drawing.Size(212, 331);
            this.pnlMemberList.TabIndex = 3;
            this.pnlMemberList.Visible = false;
            this.pnlMemberList.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMembersListTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 25);
            this.panel1.TabIndex = 1;
            // 
            // lblMembersListTitle
            // 
            this.lblMembersListTitle.AutoEllipsis = true;
            this.lblMembersListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMembersListTitle.ForeColor = System.Drawing.Color.White;
            this.lblMembersListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMembersListTitle.Name = "lblMembersListTitle";
            this.lblMembersListTitle.Size = new System.Drawing.Size(155, 17);
            this.lblMembersListTitle.TabIndex = 0;
            this.lblMembersListTitle.Text = "Members";
            // 
            // pnlChannels
            // 
            this.pnlChannels.Controls.Add(this.pnlGroupInfo);
            this.pnlChannels.Controls.Add(this.btnCreateChannel);
            this.pnlChannels.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChannels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChannels.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChannels.Location = new System.Drawing.Point(0, 0);
            this.pnlChannels.Name = "pnlChannels";
            this.pnlChannels.Size = new System.Drawing.Size(149, 331);
            this.pnlChannels.TabIndex = 1;
            // 
            // pnlGroupInfo
            // 
            this.pnlGroupInfo.Controls.Add(this.btnLeaveGroup);
            this.pnlGroupInfo.Controls.Add(this.btnGroupSettings);
            this.pnlGroupInfo.Controls.Add(this.lblGroupName);
            this.pnlGroupInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlGroupInfo.Name = "pnlGroupInfo";
            this.pnlGroupInfo.Size = new System.Drawing.Size(146, 52);
            this.pnlGroupInfo.TabIndex = 1;
            // 
            // btnLeaveGroup
            // 
            this.btnLeaveGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeaveGroup.BackgroundImage = global::PlugifyCS.Properties.Resources.door_1f6aa;
            this.btnLeaveGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeaveGroup.FlatAppearance.BorderSize = 0;
            this.btnLeaveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveGroup.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveGroup.Location = new System.Drawing.Point(86, 21);
            this.btnLeaveGroup.Name = "btnLeaveGroup";
            this.btnLeaveGroup.Size = new System.Drawing.Size(24, 24);
            this.btnLeaveGroup.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLeaveGroup, "Leave group");
            this.btnLeaveGroup.UseVisualStyleBackColor = true;
            this.btnLeaveGroup.Click += new System.EventHandler(this.btnLeaveGroup_Click);
            // 
            // btnGroupSettings
            // 
            this.btnGroupSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupSettings.BackgroundImage = global::PlugifyCS.Properties.Resources.gear_2699_fe0f;
            this.btnGroupSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroupSettings.FlatAppearance.BorderSize = 0;
            this.btnGroupSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupSettings.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupSettings.Location = new System.Drawing.Point(116, 21);
            this.btnGroupSettings.Name = "btnGroupSettings";
            this.btnGroupSettings.Size = new System.Drawing.Size(24, 24);
            this.btnGroupSettings.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnGroupSettings, "Settings");
            this.btnGroupSettings.UseVisualStyleBackColor = true;
            this.btnGroupSettings.Click += new System.EventHandler(this.btnGroupSettings_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoEllipsis = true;
            this.lblGroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGroupName.ForeColor = System.Drawing.Color.White;
            this.lblGroupName.Location = new System.Drawing.Point(0, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(146, 17);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Group name";
            // 
            // btnCreateChannel
            // 
            this.btnCreateChannel.FlatAppearance.BorderSize = 0;
            this.btnCreateChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateChannel.ForeColor = System.Drawing.Color.White;
            this.btnCreateChannel.Location = new System.Drawing.Point(3, 61);
            this.btnCreateChannel.Name = "btnCreateChannel";
            this.btnCreateChannel.Size = new System.Drawing.Size(140, 26);
            this.btnCreateChannel.TabIndex = 0;
            this.btnCreateChannel.Text = "Create channel";
            this.btnCreateChannel.UseVisualStyleBackColor = true;
            this.btnCreateChannel.Click += new System.EventHandler(this.btnCreateChannel_Click);
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Red;
            this.pnlError.Controls.Add(this.btnErrorClose);
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlError.Location = new System.Drawing.Point(0, 23);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(800, 34);
            this.pnlError.TabIndex = 3;
            this.pnlError.Visible = false;
            // 
            // btnErrorClose
            // 
            this.btnErrorClose.Location = new System.Drawing.Point(757, 3);
            this.btnErrorClose.Name = "btnErrorClose";
            this.btnErrorClose.Size = new System.Drawing.Size(40, 28);
            this.btnErrorClose.TabIndex = 1;
            this.btnErrorClose.Text = "X";
            this.btnErrorClose.UseVisualStyleBackColor = true;
            this.btnErrorClose.Click += new System.EventHandler(this.btnErrorClose_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(13, 7);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(32, 13);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Error";
            // 
            // tmrPing
            // 
            this.tmrPing.Enabled = true;
            this.tmrPing.Interval = 10000;
            this.tmrPing.Tick += new System.EventHandler(this.tmrPing_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServerContent);
            this.Controls.Add(this.pnlServerArea);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlugifyCS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlServerArea.ResumeLayout(false);
            this.pnlServers.ResumeLayout(false);
            this.pnlUserArea.ResumeLayout(false);
            this.pnlUserArea.PerformLayout();
            this.ServerContent.ResumeLayout(false);
            this.pnlMessageContainer.ResumeLayout(false);
            this.messagesPanel.ResumeLayout(false);
            this.messagesPanel.PerformLayout();
            this.messageSendArea.ResumeLayout(false);
            this.messageSendArea.PerformLayout();
            this.pnlMemberList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlChannels.ResumeLayout(false);
            this.pnlGroupInfo.ResumeLayout(false);
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlServerArea;
        private System.Windows.Forms.Panel ServerContent;
        private System.Windows.Forms.FlowLayoutPanel pnlServers;
        private System.Windows.Forms.Panel pnlUserArea;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnErrorClose;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel pnlMessageContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlChannels;
        private System.Windows.Forms.Label lblNoChannel;
        private System.Windows.Forms.ProgressBar prgMessageLoading;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel messageSendArea;
        private TextboxControl txtMessage;
        private System.Windows.Forms.Button btnSendMSG;
        private System.Windows.Forms.Timer tmrPing;
        private System.Windows.Forms.Button btnCreateChannel;
        private System.Windows.Forms.Panel pnlGroupInfo;
        private System.Windows.Forms.Label lblGroupName;
        private Controls.RoundButton btnCreateOrJoinGroup;
        private Controls.RoundPicture lblUserPFP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGroupSettings;
        private System.Windows.Forms.Button btnLeaveGroup;
        private System.Windows.Forms.Panel pnlChannelTopBar;
        private System.Windows.Forms.FlowLayoutPanel messagesPanel;
        private System.Windows.Forms.FlowLayoutPanel pnlMemberList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMembersListTitle;
    }
}

