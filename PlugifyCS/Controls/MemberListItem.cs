using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS.Controls
{
    public partial class MemberListItem : UserControl
    {
        public MemberListItem()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;

                lblUserDisplayName.ForeColor = Color.Black;
                lblUserName.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = System.Drawing.SystemColors.Control;

                lblUserDisplayName.ForeColor = Color.Black;
                lblUserName.ForeColor = Color.Black;
            }
        }

        public void ApplyProperties(string username, string displayname)
        {
            lblUserDisplayName.Text = displayname;
            lblUserName.Text = "@"+username;
            pfp.SetURL(username);
        }
    }
}
