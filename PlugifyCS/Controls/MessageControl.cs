using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;

namespace PlugifyCS
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
                htmlLabel1.BackColor = Color.White;

                lblAuthor.ForeColor = Color.Black;
                htmlLabel1.BackColor = Color.White;
            }

            if (Properties.Settings.Default.Theme == "classic")
            {
                this.ForeColor = Color.Black;
                this.BackColor = System.Drawing.SystemColors.Control;
                htmlLabel1.BackColor = System.Drawing.SystemColors.Control;

                htmlLabel1.ForeColor = Color.Black;
                lblAuthor.ForeColor = Color.Black;
            }
        }

        public void SetSettings(string AuthorPFP, string MessageTitle, string Content, string TimeString)
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                htmlLabel1.BaseStylesheet = @"*{color:white; margin:0;} body,html,h1,h2,h3,h4,p,figure,blockquote,dl,dd{ margin: 0; } img{margin: 2px;}";
            }
            else
            {
                htmlLabel1.BaseStylesheet = @"*{color:black; margin:0;} body,html,h1,h2,h3,h4,p,figure,blockquote,dl,dd{ margin: 0; } img{margin: 2px;}";
            }
            pfp.SetURL(AuthorPFP);
            lblAuthor.Text = MessageTitle;
            htmlLabel1.Text = Content.Replace("\n", "<br>");
            lblTime.Text = TimeString;

            var h = htmlLabel1.Height;
            if (h > this.Height - 30)
            {
                this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + (htmlLabel1.Height - 30));
            }
        }
    }
}
