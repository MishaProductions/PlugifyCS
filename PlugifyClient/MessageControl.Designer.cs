
namespace PlugifyClient
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
            this.lblMessageContent = new System.Windows.Forms.Label();
            this.pfp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(3, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(153, 20);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Loading (@Loading)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblTime.Location = new System.Drawing.Point(162, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Tommorow at 3:00 AM";
            // 
            // lblMessageContent
            // 
            this.lblMessageContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageContent.ForeColor = System.Drawing.Color.White;
            this.lblMessageContent.Location = new System.Drawing.Point(74, 35);
            this.lblMessageContent.Name = "lblMessageContent";
            this.lblMessageContent.Size = new System.Drawing.Size(379, 40);
            this.lblMessageContent.TabIndex = 3;
            this.lblMessageContent.Text = "Loading the message content";
            // 
            // pfp
            // 
            this.pfp.InitialImage = global::PlugifyClient.Properties.Resources.plug;
            this.pfp.Location = new System.Drawing.Point(4, 4);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(64, 64);
            this.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfp.TabIndex = 0;
            this.pfp.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAuthor);
            this.flowLayoutPanel1.Controls.Add(this.lblTime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 23);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblMessageContent);
            this.Controls.Add(this.pfp);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(461, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pfp;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMessageContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
