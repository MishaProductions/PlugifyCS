
namespace PlugifyCS.Controls
{
    partial class MemberListItem
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
            this.lblUserDisplayName = new System.Windows.Forms.Label();
            this.pfp = new PlugifyCS.Controls.RoundPicture();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.AutoSize = true;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblUserDisplayName.Location = new System.Drawing.Point(41, 0);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(82, 20);
            this.lblUserDisplayName.TabIndex = 0;
            this.lblUserDisplayName.Text = "@misha     ";
            // 
            // pfp
            // 
            this.pfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pfp.Location = new System.Drawing.Point(3, 3);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(32, 32);
            this.pfp.TabIndex = 6;
            this.pfp.Text = "roundPicture1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(41, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(42, 15);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Object";
            // 
            // MemberListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pfp);
            this.Controls.Add(this.lblUserDisplayName);
            this.Name = "MemberListItem";
            this.Size = new System.Drawing.Size(207, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDisplayName;
        private RoundPicture pfp;
        private System.Windows.Forms.Label lblUserName;
    }
}
