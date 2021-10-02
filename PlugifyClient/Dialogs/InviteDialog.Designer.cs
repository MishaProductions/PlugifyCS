
namespace PlugifyClient.Dialogs
{
    partial class InviteDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoCreateNew = new System.Windows.Forms.Button();
            this.pnlCreateGroup = new System.Windows.Forms.Panel();
            this.pnlJoinGroup = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoJoinGroup = new System.Windows.Forms.Button();
            this.txtInviteCode = new System.Windows.Forms.TextBox();
            this.btnJoinGroup = new PlugifyClient.CommandLink();
            this.btnCreateNew = new PlugifyClient.CommandLink();
            this.pnlCreateGroup.SuspendLayout();
            this.pnlJoinGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Join or create a new group";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(97, 11);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(216, 25);
            this.txtGroupName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group name: ";
            // 
            // btnDoCreateNew
            // 
            this.btnDoCreateNew.Location = new System.Drawing.Point(238, 42);
            this.btnDoCreateNew.Name = "btnDoCreateNew";
            this.btnDoCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnDoCreateNew.TabIndex = 5;
            this.btnDoCreateNew.Text = "Create";
            this.btnDoCreateNew.UseVisualStyleBackColor = true;
            this.btnDoCreateNew.Click += new System.EventHandler(this.btnDoCreateNew_Click);
            // 
            // pnlCreateGroup
            // 
            this.pnlCreateGroup.Controls.Add(this.label2);
            this.pnlCreateGroup.Controls.Add(this.btnDoCreateNew);
            this.pnlCreateGroup.Controls.Add(this.txtGroupName);
            this.pnlCreateGroup.Location = new System.Drawing.Point(12, 107);
            this.pnlCreateGroup.Name = "pnlCreateGroup";
            this.pnlCreateGroup.Size = new System.Drawing.Size(317, 109);
            this.pnlCreateGroup.TabIndex = 6;
            this.pnlCreateGroup.Visible = false;
            // 
            // pnlJoinGroup
            // 
            this.pnlJoinGroup.Controls.Add(this.label3);
            this.pnlJoinGroup.Controls.Add(this.btnDoJoinGroup);
            this.pnlJoinGroup.Controls.Add(this.txtInviteCode);
            this.pnlJoinGroup.Location = new System.Drawing.Point(12, 285);
            this.pnlJoinGroup.Name = "pnlJoinGroup";
            this.pnlJoinGroup.Size = new System.Drawing.Size(317, 109);
            this.pnlJoinGroup.TabIndex = 7;
            this.pnlJoinGroup.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invite code:";
            // 
            // btnDoJoinGroup
            // 
            this.btnDoJoinGroup.Location = new System.Drawing.Point(238, 42);
            this.btnDoJoinGroup.Name = "btnDoJoinGroup";
            this.btnDoJoinGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDoJoinGroup.TabIndex = 5;
            this.btnDoJoinGroup.Text = "Join";
            this.btnDoJoinGroup.UseVisualStyleBackColor = true;
            this.btnDoJoinGroup.Click += new System.EventHandler(this.btnDoJoinGroup_Click);
            // 
            // txtInviteCode
            // 
            this.txtInviteCode.Location = new System.Drawing.Point(97, 11);
            this.txtInviteCode.Name = "txtInviteCode";
            this.txtInviteCode.Size = new System.Drawing.Size(216, 25);
            this.txtInviteCode.TabIndex = 3;
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJoinGroup.Location = new System.Drawing.Point(12, 222);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(317, 57);
            this.btnJoinGroup.TabIndex = 2;
            this.btnJoinGroup.Text = "Join an existing group";
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateNew.Location = new System.Drawing.Point(12, 44);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(317, 57);
            this.btnCreateNew.TabIndex = 0;
            this.btnCreateNew.Text = "Create a new group";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // InviteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(334, 396);
            this.Controls.Add(this.pnlJoinGroup);
            this.Controls.Add(this.pnlCreateGroup);
            this.Controls.Add(this.btnJoinGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateNew);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InviteDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invite dialog";
            this.pnlCreateGroup.ResumeLayout(false);
            this.pnlCreateGroup.PerformLayout();
            this.pnlJoinGroup.ResumeLayout(false);
            this.pnlJoinGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommandLink btnCreateNew;
        private System.Windows.Forms.Label label1;
        private CommandLink btnJoinGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoCreateNew;
        private System.Windows.Forms.Panel pnlCreateGroup;
        private System.Windows.Forms.Panel pnlJoinGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoJoinGroup;
        private System.Windows.Forms.TextBox txtInviteCode;
    }
}