
namespace PlugifyClient
{
    partial class frmSettings
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radClassic = new System.Windows.Forms.RadioButton();
            this.radLightTheme = new System.Windows.Forms.RadioButton();
            this.radDarkTheme = new System.Windows.Forms.RadioButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(16, 465);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(464, 465);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radClassic);
            this.groupBox1.Controls.Add(this.radLightTheme);
            this.groupBox1.Controls.Add(this.radDarkTheme);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(548, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theme settings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note: you have to restart the client for the changes to take affect";
            // 
            // radClassic
            // 
            this.radClassic.AutoSize = true;
            this.radClassic.Location = new System.Drawing.Point(8, 81);
            this.radClassic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radClassic.Name = "radClassic";
            this.radClassic.Size = new System.Drawing.Size(126, 20);
            this.radClassic.TabIndex = 3;
            this.radClassic.TabStop = true;
            this.radClassic.Text = "Windows classic";
            this.radClassic.UseVisualStyleBackColor = true;
            this.radClassic.CheckedChanged += new System.EventHandler(this.radClassic_CheckedChanged);
            // 
            // radLightTheme
            // 
            this.radLightTheme.AutoSize = true;
            this.radLightTheme.Location = new System.Drawing.Point(8, 53);
            this.radLightTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLightTheme.Name = "radLightTheme";
            this.radLightTheme.Size = new System.Drawing.Size(54, 20);
            this.radLightTheme.TabIndex = 2;
            this.radLightTheme.TabStop = true;
            this.radLightTheme.Text = "Light";
            this.radLightTheme.UseVisualStyleBackColor = true;
            this.radLightTheme.CheckedChanged += new System.EventHandler(this.radLightTheme_CheckedChanged);
            // 
            // radDarkTheme
            // 
            this.radDarkTheme.AutoSize = true;
            this.radDarkTheme.Checked = true;
            this.radDarkTheme.Location = new System.Drawing.Point(8, 23);
            this.radDarkTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDarkTheme.Name = "radDarkTheme";
            this.radDarkTheme.Size = new System.Drawing.Size(55, 20);
            this.radDarkTheme.TabIndex = 0;
            this.radDarkTheme.TabStop = true;
            this.radDarkTheme.Text = "Dark";
            this.radDarkTheme.UseVisualStyleBackColor = true;
            this.radDarkTheme.CheckedChanged += new System.EventHandler(this.radDarkTheme_CheckedChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(13, 445);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(111, 16);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Client version: 1.1";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 508);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDarkTheme;
        private System.Windows.Forms.RadioButton radClassic;
        private System.Windows.Forms.RadioButton radLightTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
    }
}