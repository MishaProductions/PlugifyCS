using PlugifyCS.Dialogs;
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
        private Color MemberlistItem_Dark_Color_Normal = Color.FromArgb(34, 34, 44);
        private Color MemberlistItem_Dark_Color_Hover = Color.FromArgb(65, 65, 72);
        private string UserName;
        private string DisplayName;
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

            pfp.Click += delegate { HandleClick(); };
            lblUserDisplayName.Click += delegate { HandleClick(); };
            lblUserName.Click += delegate { HandleClick(); };
        }

        public void ApplyProperties(string username, string displayname, string pfpUrl)
        {
            this.UserName = username;
            this.DisplayName = displayname;

            lblUserDisplayName.Text = displayname;
            lblUserName.Text = "@"+username;
            pfp.SetURL(username, pfpUrl);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (Properties.Settings.Default.Theme == "dark")
                this.BackColor = MemberlistItem_Dark_Color_Hover;
            else if (Properties.Settings.Default.Theme == "light")
                this.BackColor = Color.Gray;
            else
                this.BackColor = SystemColors.ControlDark;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (Properties.Settings.Default.Theme == "dark")
                this.BackColor = MemberlistItem_Dark_Color_Normal;
            else if (Properties.Settings.Default.Theme == "light")
                this.BackColor = Color.White;
            else
                this.BackColor = SystemColors.Control;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            HandleClick();
        }
        private void HandleClick()
        {
            var dlg = new UserInfoDialog(UserName);
            dlg.ShowDialog();
        }
    }
}
