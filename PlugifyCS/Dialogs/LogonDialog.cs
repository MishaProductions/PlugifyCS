using LibPlugifyCS;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace PlugifyCS.Dialogs
{
    public partial class LogonDialog : Form
    {
        public LogonDialog()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text))
            {
                lblToken.Text = "Token cannot be empty";
                lblToken.Visible = true;
            }
            else
            {
                var client = new PlugifyCSClient();
                progressBar1.Visible = true;
                try
                {
                    await client.Start(txtToken.Text);
                    progressBar1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Visible = false;

                    return;
                }

                Properties.Settings.Default.token = txtToken.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                client.Close();
                lblToken.Invoke((MethodInvoker)delegate ()
                {
                    Close();
                });
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
