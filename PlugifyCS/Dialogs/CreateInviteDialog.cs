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
    public partial class CreateInviteDialog : Form
    {
        string groupid;
        public CreateInviteDialog(string groupID)
        {
            InitializeComponent();
            MaximumSize = Size;
            MaximumSize = Size;
            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;

                label1.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = SystemColors.Control;

                label1.ForeColor = Color.Black;
            }
            this.groupid = groupID;
        }

        private void CreateInviteDialog_Shown(object sender, EventArgs e)
        {
            var invites = frmMain.ApiPost("https://api.plugify.cf/v2/invites/" + groupid,
               "{\"uses\": null, \"expires\": null}");

            textBox1.Text = (string)invites.data.id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
