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
    public partial class CreateNewChannel : Form
    {
        public string Result;
        public CreateNewChannel()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = SystemColors.Control;
            }
            cmbType.SelectedIndex = 0;
        }

        private void txtChannelName_TextChanged(object sender, EventArgs e)
        {
            if (txtChannelName.Text.Length == 0)
            {
                btnCreate.Enabled = false;
            }
            else
            {
                btnCreate.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtChannelName.Text.Contains(" "))
            {
                lblError.Visible = true;
            }
            else
            {
                Result = txtChannelName.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void CreateNewChannel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
