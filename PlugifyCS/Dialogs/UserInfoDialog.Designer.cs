
namespace PlugifyCS.Dialogs
{
    partial class UserInfoDialog
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
            this.roundPicture1 = new PlugifyCS.Controls.RoundPicture();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserFlags = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundPicture1
            // 
            this.roundPicture1.BackgroundImage = global::PlugifyCS.Properties.Resources.plug;
            this.roundPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPicture1.Location = new System.Drawing.Point(13, 13);
            this.roundPicture1.Name = "roundPicture1";
            this.roundPicture1.Size = new System.Drawing.Size(145, 145);
            this.roundPicture1.TabIndex = 0;
            this.roundPicture1.Text = "roundPicture1";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayName.Location = new System.Drawing.Point(181, 33);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(167, 40);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.Text = "mishaisakot";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(188, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "@misha";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(460, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserFlags
            // 
            this.lblUserFlags.AutoSize = true;
            this.lblUserFlags.ForeColor = System.Drawing.Color.White;
            this.lblUserFlags.Location = new System.Drawing.Point(13, 188);
            this.lblUserFlags.Name = "lblUserFlags";
            this.lblUserFlags.Size = new System.Drawing.Size(58, 13);
            this.lblUserFlags.TabIndex = 4;
            this.lblUserFlags.Text = "Loading...";
            // 
            // UserInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(547, 395);
            this.Controls.Add(this.lblUserFlags);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.roundPicture1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserInfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User information";
            this.Shown += new System.EventHandler(this.UserInfoDialog_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInfoDialog_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundPicture roundPicture1;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserFlags;
    }
}