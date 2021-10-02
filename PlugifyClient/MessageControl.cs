using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyClient
{
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            if (Properties.Settings.Default.Theme == "light")
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;
                lblMessageContent.ForeColor = Color.Black;
                lblAuthor.ForeColor = Color.Black;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = SystemColors.Control;
                lblMessageContent.ForeColor = Color.Black;
                lblAuthor.ForeColor = Color.Black;
            }
        }

        public void SetSettings(string AuthorPFPURL, string MessageTitle, string Content, string TimeString)
        {
            pfp.ImageLocation = AuthorPFPURL;
            lblAuthor.Text = MessageTitle;
            lblMessageContent.Text = Content;
            lblTime.Text = TimeString;
            var h = TextRenderer.MeasureText(Content, lblMessageContent.Font).Height;
            if (h > 40)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + (h - 20));
            }
        }
    }
}
