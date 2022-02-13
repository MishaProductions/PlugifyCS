
namespace PlugifyCS
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
            this.label1 = new System.Windows.Forms.Label();
            this.radEnableXAML = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(14, 436);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 27);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(406, 436);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 27);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(479, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theme settings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note: you have to restart the client for the changes to take affect";
            // 
            // radClassic
            // 
            this.radClassic.AutoSize = true;
            this.radClassic.Location = new System.Drawing.Point(7, 76);
            this.radClassic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radClassic.Name = "radClassic";
            this.radClassic.Size = new System.Drawing.Size(111, 19);
            this.radClassic.TabIndex = 3;
            this.radClassic.TabStop = true;
            this.radClassic.Text = "Windows classic";
            this.radClassic.UseVisualStyleBackColor = true;
            this.radClassic.CheckedChanged += new System.EventHandler(this.radClassic_CheckedChanged);
            // 
            // radLightTheme
            // 
            this.radLightTheme.AutoSize = true;
            this.radLightTheme.Location = new System.Drawing.Point(7, 50);
            this.radLightTheme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLightTheme.Name = "radLightTheme";
            this.radLightTheme.Size = new System.Drawing.Size(52, 19);
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
            this.radDarkTheme.Location = new System.Drawing.Point(7, 22);
            this.radDarkTheme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radDarkTheme.Name = "radDarkTheme";
            this.radDarkTheme.Size = new System.Drawing.Size(49, 19);
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
            this.lblVersion.Location = new System.Drawing.Point(12, 418);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 15);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Client version: 1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note: Once moving to XAML is complete, the classic theme will be removed\r\nPlease " +
    "note that the classic theme may not apply to all areas\r\n";
            // 
            // radEnableXAML
            // 
            this.radEnableXAML.AutoSize = true;
            this.radEnableXAML.Location = new System.Drawing.Point(14, 211);
            this.radEnableXAML.Name = "radEnableXAML";
            this.radEnableXAML.Size = new System.Drawing.Size(96, 19);
            this.radEnableXAML.TabIndex = 5;
            this.radEnableXAML.Text = "Enable XAML";
            this.radEnableXAML.UseVisualStyleBackColor = true;
            this.radEnableXAML.CheckedChanged += new System.EventHandler(this.radEnableXAML_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 477);
            this.Controls.Add(this.radEnableXAML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private Label label1;
        private CheckBox radEnableXAML;
    }
}