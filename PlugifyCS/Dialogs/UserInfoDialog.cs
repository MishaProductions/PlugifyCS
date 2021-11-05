using PlugifyCS.lib;
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
    public partial class UserInfoDialog : Form
    {
        string username;
        public UserInfoDialog(string username)
        {
            InitializeComponent();
            this.username = username;
            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;

                lblDisplayName.ForeColor = Color.Black;
                lblUserName.ForeColor = Color.Black;
                lblUserFlags.ForeColor = Color.Black;
                btnClose.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = SystemColors.Control;

                lblDisplayName.ForeColor = Color.Black;
                lblUserName.ForeColor = Color.Black;
                lblUserFlags.ForeColor = Color.Black;
                btnClose.ForeColor = Color.Black;
            }
        }

        private void UserInfoDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserInfoDialog_Shown(object sender, EventArgs e)
        {
            var d = frmMain.ApiGet("https://api.plugify.cf/v2/users/info/" + username);
            var user = d.data;
            var displayName = (string)user.displayName;
            var flags = (PlugifyUserFlags)user.flags;
            var flags2 = (int)user.flags;
            if (string.IsNullOrEmpty(displayName))
            {
                lblDisplayName.Text = (string)user.name;
            }
            else
            {
                lblDisplayName.Text = (string)user.displayName;
            }
            lblUserName.Text = (string)"@" + user.name;
            roundPicture1.SetURL(username);

            StringBuilder sb = new StringBuilder();
            if ((flags2 & (1 << 0)) == (1 << 0))
            {
                sb.AppendLine("Plugify Pro subscriber");
            }
            if ((flags2 & (1 << 1)) == (1 << 1))
            {
                sb.AppendLine("Plugify Developer");
            }
            if ((flags2 & (1 << 3)) == (1 << 3))
            {
                sb.AppendLine("Private Beta Tester");
            }
            if ((flags2 & (1 << 3)) == (1 << 2))
            {
                sb.AppendLine("Public Beta Tester");
            }
            if ((flags2 & (1 << 4)) == (1 << 4))
            {
                sb.AppendLine("Plugify Managed account");
            }
            lblUserFlags.Text = sb.ToString();
        }
    }
}
