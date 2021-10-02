
namespace PlugifyClient
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
            this.ServerArea = new System.Windows.Forms.Panel();
            this.Severs = new System.Windows.Forms.FlowLayoutPanel();
            this.UserArea = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblPing = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPFP = new System.Windows.Forms.PictureBox();
            this.ServerContent = new System.Windows.Forms.Panel();
            this.pnlMessageContainer = new System.Windows.Forms.Panel();
            this.messagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblNoChannel = new System.Windows.Forms.Label();
            this.messageSendArea = new System.Windows.Forms.Panel();
            this.btnSendMSG = new System.Windows.Forms.Button();
            this.textboxControl1 = new PlugifyClient.TextboxControl();
            this.prgMessageLoading = new System.Windows.Forms.ProgressBar();
            this.pnlChannels = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateChannel = new System.Windows.Forms.Button();
            this.pnlError = new System.Windows.Forms.Panel();
            this.btnErrorClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrPing = new System.Windows.Forms.Timer(this.components);
            this.ServerArea.SuspendLayout();
            this.UserArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserPFP)).BeginInit();
            this.ServerContent.SuspendLayout();
            this.pnlMessageContainer.SuspendLayout();
            this.messagesPanel.SuspendLayout();
            this.messageSendArea.SuspendLayout();
            this.pnlChannels.SuspendLayout();
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
            // ServerArea
            // 
            this.ServerArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ServerArea.Controls.Add(this.Severs);
            this.ServerArea.Controls.Add(this.UserArea);
            this.ServerArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerArea.Location = new System.Drawing.Point(0, 57);
            this.ServerArea.Name = "ServerArea";
            this.ServerArea.Size = new System.Drawing.Size(800, 84);
            this.ServerArea.TabIndex = 1;
            // 
            // Severs
            // 
            this.Severs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Severs.Location = new System.Drawing.Point(0, 0);
            this.Severs.Name = "Severs";
            this.Severs.Size = new System.Drawing.Size(545, 84);
            this.Severs.TabIndex = 0;
            // 
            // UserArea
            // 
            this.UserArea.Controls.Add(this.btnHome);
            this.UserArea.Controls.Add(this.btnSettings);
            this.UserArea.Controls.Add(this.lblPing);
            this.UserArea.Controls.Add(this.lblUserName);
            this.UserArea.Controls.Add(this.lblUserPFP);
            this.UserArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserArea.Location = new System.Drawing.Point(545, 0);
            this.UserArea.Name = "UserArea";
            this.UserArea.Size = new System.Drawing.Size(255, 84);
            this.UserArea.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Location = new System.Drawing.Point(115, 55);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(61, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(182, 55);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(61, 23);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPing.ForeColor = System.Drawing.Color.White;
            this.lblPing.Location = new System.Drawing.Point(70, 35);
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
            this.lblUserName.Location = new System.Drawing.Point(70, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Loading....";
            // 
            // lblUserPFP
            // 
            this.lblUserPFP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblUserPFP.ImageLocation = "http://cds.plugify.cf/defaultAvatars/addictedtree";
            this.lblUserPFP.Location = new System.Drawing.Point(0, 14);
            this.lblUserPFP.Name = "lblUserPFP";
            this.lblUserPFP.Size = new System.Drawing.Size(64, 64);
            this.lblUserPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblUserPFP.TabIndex = 0;
            this.lblUserPFP.TabStop = false;
            // 
            // ServerContent
            // 
            this.ServerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.ServerContent.Controls.Add(this.pnlMessageContainer);
            this.ServerContent.Controls.Add(this.pnlChannels);
            this.ServerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerContent.Location = new System.Drawing.Point(0, 141);
            this.ServerContent.Name = "ServerContent";
            this.ServerContent.Size = new System.Drawing.Size(800, 309);
            this.ServerContent.TabIndex = 2;
            // 
            // pnlMessageContainer
            // 
            this.pnlMessageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.pnlMessageContainer.Controls.Add(this.messagesPanel);
            this.pnlMessageContainer.Controls.Add(this.messageSendArea);
            this.pnlMessageContainer.Controls.Add(this.prgMessageLoading);
            this.pnlMessageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessageContainer.Location = new System.Drawing.Point(149, 0);
            this.pnlMessageContainer.Name = "pnlMessageContainer";
            this.pnlMessageContainer.Size = new System.Drawing.Size(651, 309);
            this.pnlMessageContainer.TabIndex = 2;
            // 
            // messagesPanel
            // 
            this.messagesPanel.AutoScroll = true;
            this.messagesPanel.Controls.Add(this.lblHome);
            this.messagesPanel.Controls.Add(this.lblNoChannel);
            this.messagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messagesPanel.Location = new System.Drawing.Point(0, 23);
            this.messagesPanel.Name = "messagesPanel";
            this.messagesPanel.Size = new System.Drawing.Size(651, 221);
            this.messagesPanel.TabIndex = 3;
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
            this.lblHome.Size = new System.Drawing.Size(436, 64);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Under construction.\r\n(Psst, check out the groups on the top!)";
            // 
            // lblNoChannel
            // 
            this.lblNoChannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoChannel.AutoSize = true;
            this.lblNoChannel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoChannel.ForeColor = System.Drawing.Color.White;
            this.lblNoChannel.Location = new System.Drawing.Point(104, 64);
            this.lblNoChannel.Name = "lblNoChannel";
            this.lblNoChannel.Size = new System.Drawing.Size(233, 32);
            this.lblNoChannel.TabIndex = 1;
            this.lblNoChannel.Text = "No channel selected";
            this.lblNoChannel.Visible = false;
            // 
            // messageSendArea
            // 
            this.messageSendArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.messageSendArea.Controls.Add(this.btnSendMSG);
            this.messageSendArea.Controls.Add(this.textboxControl1);
            this.messageSendArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageSendArea.Location = new System.Drawing.Point(0, 244);
            this.messageSendArea.Name = "messageSendArea";
            this.messageSendArea.Size = new System.Drawing.Size(651, 65);
            this.messageSendArea.TabIndex = 4;
            // 
            // btnSendMSG
            // 
            this.btnSendMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMSG.Location = new System.Drawing.Point(560, 7);
            this.btnSendMSG.Name = "btnSendMSG";
            this.btnSendMSG.Size = new System.Drawing.Size(88, 46);
            this.btnSendMSG.TabIndex = 1;
            this.btnSendMSG.Text = "Send";
            this.btnSendMSG.UseVisualStyleBackColor = true;
            this.btnSendMSG.Click += new System.EventHandler(this.btnSendMSG_Click);
            // 
            // textboxControl1
            // 
            this.textboxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.textboxControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxControl1.Cue = "Enter a message...";
            this.textboxControl1.ForeColor = System.Drawing.Color.White;
            this.textboxControl1.Location = new System.Drawing.Point(9, 7);
            this.textboxControl1.Multiline = true;
            this.textboxControl1.Name = "textboxControl1";
            this.textboxControl1.Size = new System.Drawing.Size(544, 46);
            this.textboxControl1.TabIndex = 0;
            this.textboxControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxControl1_KeyDown);
            // 
            // prgMessageLoading
            // 
            this.prgMessageLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgMessageLoading.Location = new System.Drawing.Point(0, 0);
            this.prgMessageLoading.MarqueeAnimationSpeed = 10;
            this.prgMessageLoading.Name = "prgMessageLoading";
            this.prgMessageLoading.Size = new System.Drawing.Size(651, 23);
            this.prgMessageLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMessageLoading.TabIndex = 2;
            this.prgMessageLoading.Visible = false;
            // 
            // pnlChannels
            // 
            this.pnlChannels.Controls.Add(this.btnCreateChannel);
            this.pnlChannels.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChannels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlChannels.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChannels.Location = new System.Drawing.Point(0, 0);
            this.pnlChannels.Name = "pnlChannels";
            this.pnlChannels.Size = new System.Drawing.Size(149, 309);
            this.pnlChannels.TabIndex = 1;
            // 
            // btnCreateChannel
            // 
            this.btnCreateChannel.Location = new System.Drawing.Point(3, 3);
            this.btnCreateChannel.Name = "btnCreateChannel";
            this.btnCreateChannel.Size = new System.Drawing.Size(140, 23);
            this.btnCreateChannel.TabIndex = 0;
            this.btnCreateChannel.Text = "+";
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
            this.Controls.Add(this.ServerArea);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "PlugifyCS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ServerArea.ResumeLayout(false);
            this.UserArea.ResumeLayout(false);
            this.UserArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserPFP)).EndInit();
            this.ServerContent.ResumeLayout(false);
            this.pnlMessageContainer.ResumeLayout(false);
            this.messagesPanel.ResumeLayout(false);
            this.messagesPanel.PerformLayout();
            this.messageSendArea.ResumeLayout(false);
            this.messageSendArea.PerformLayout();
            this.pnlChannels.ResumeLayout(false);
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel ServerArea;
        private System.Windows.Forms.Panel ServerContent;
        private System.Windows.Forms.FlowLayoutPanel Severs;
        private System.Windows.Forms.Panel UserArea;
        private System.Windows.Forms.PictureBox lblUserPFP;
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
        private System.Windows.Forms.FlowLayoutPanel messagesPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel messageSendArea;
        private TextboxControl textboxControl1;
        private System.Windows.Forms.Button btnSendMSG;
        private System.Windows.Forms.Timer tmrPing;
        private System.Windows.Forms.Button btnCreateChannel;
    }
}

