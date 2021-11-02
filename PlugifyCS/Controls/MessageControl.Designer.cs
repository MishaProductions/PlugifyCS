
namespace PlugifyCS
{
    partial class MessageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.htmlLabel1 = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.pfp = new PlugifyCS.Controls.RoundPicture();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(3, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(165, 21);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Loading (@Loading)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblTime.Location = new System.Drawing.Point(174, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Tommorow at 3:00 AM";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAuthor);
            this.flowLayoutPanel1.Controls.Add(this.lblTime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 23);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.AutoSizeHeightOnly = true;
            this.htmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.htmlLabel1.BaseStylesheet = "*{color:white; margin:0;} body,html,h1,h2,h3,h4,p,figure,blockquote,dl,dd{ displa" +
    "y: block; margin: 0; } img{margin: 2px;}";
            this.htmlLabel1.Location = new System.Drawing.Point(58, 32);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(400, 20);
            this.htmlLabel1.TabIndex = 6;
            this.htmlLabel1.Text = "<p>Loading message</p>";
            // 
            // pfp
            // 
            this.pfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pfp.Location = new System.Drawing.Point(4, 4);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(48, 48);
            this.pfp.TabIndex = 5;
            this.pfp.Text = "roundPicture1";
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.pfp);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(461, 60);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.RoundPicture pfp;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlLabel1;
    }
}
