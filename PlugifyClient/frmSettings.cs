using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            if (Properties.Settings.Default.Theme == "light")
            {
                radLightTheme.Checked = true;
            }
            else if (Properties.Settings.Default.Theme == "dark")
            {
                radDarkTheme.Checked = true;
            }
            else if (Properties.Settings.Default.Theme == "classic")
            {
                radClassic.Checked = true;
            }
            lblVersion.Text = "Client version: " + Application.ProductVersion;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.token = "";
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Application.Restart();
        }

        private void radDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (radDarkTheme.Checked)
            {
                Properties.Settings.Default.Theme = "dark";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void radLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (radLightTheme.Checked)
            {
                Properties.Settings.Default.Theme = "light";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void radClassic_CheckedChanged(object sender, EventArgs e)
        {
            if (radClassic.Checked)
            {
                Properties.Settings.Default.Theme = "classic";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
