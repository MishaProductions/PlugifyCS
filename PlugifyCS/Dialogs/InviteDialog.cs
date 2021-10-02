using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS.Dialogs
{
    public partial class InviteDialog : Form
    {
        /// <summary>
        /// If Result2 == true, this will be an invite code
        /// else If Result2 == false, this will be a string with new group name
        /// </summary>
        public string Result1;
        /// <summary>
        /// True: Join group
        /// False: Create group
        /// </summary>
        public bool Result2;
        public InviteDialog()
        {
            InitializeComponent();
            MaximumSize = Size;
            MaximumSize = Size;
            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = SystemColors.Control;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            pnlCreateGroup.Visible = true;
            pnlJoinGroup.Visible = false;
        }

        private void btnJoinGroup_Click(object sender, EventArgs e)
        {
            pnlCreateGroup.Visible = false;
            pnlJoinGroup.Visible = true;
        }

        private void btnDoJoinGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInviteCode.Text))
            {
                MessageBox.Show("Invite code cannot be empty.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result2 = true;
            Result1 = txtInviteCode.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnDoCreateNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGroupName.Text))
            {
                MessageBox.Show("Group name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result2 = false;
            Result1 = txtGroupName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
