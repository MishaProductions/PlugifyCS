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
    public partial class ServerSettingsDialog : Form
    {
        frmMain instance;
        string groupid;
        public ServerSettingsDialog(string groupid, frmMain m)
        {
            InitializeComponent();
            this.instance = m;
            this.groupid = groupid;

            if (Properties.Settings.Default.Theme == "light")
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
            if (Properties.Settings.Default.Theme == "classic")
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
            }
        }

        private void ServerSettingsDialog_Shown(object sender, EventArgs e)
        {
            var invites = frmMain.ApiGet("https://api.plugify.cf/v2/invites/group/" + groupid);
            foreach (var item in invites.data.invites)
            {
                var panel = new Panel();
                panel.Size = new Size(455, 20);

                var inviteIDLbl = new Label();
                inviteIDLbl.Text = (string)item.id;
                inviteIDLbl.Location = new Point(4, 4);
                panel.Controls.Add(inviteIDLbl);

                var usesLbl = new Label();
                if (item.uses == null)
                {
                    usesLbl.Text = "0";
                }
                else
                {
                    usesLbl.Text = ((int)item.uses).ToString();
                }
                usesLbl.Location = new Point(144, 4);
                panel.Controls.Add(usesLbl);

                var expiresInLbl = new Label();
                if (item.expires == null)
                {
                    expiresInLbl.Text = "Never";
                }
                else
                {
                    expiresInLbl.Text = item.expires.ToString();
                }

                expiresInLbl.Location = new Point(299, 4);
                panel.Controls.Add(expiresInLbl);

                flowLayoutPanel1.Controls.Add(panel);
            }
            ;
        }
    }
}
