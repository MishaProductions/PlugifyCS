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
        private static TwemojiSharp.TwemojiLib lib = new TwemojiSharp.TwemojiLib();
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
            pfp.SetURL(AuthorPFP);
            lblAuthor.Text = MessageTitle;
            if (Properties.Settings.Default.Theme == "dark")
                htmlLabel1.Text = "<html><head><style>body{color:white;}</style></head><body>" + Content + "</body></html>";
            else
                htmlLabel1.Text = "<html><head><style>body{color:black;}</style></head><body>" + Content + "</body></html>";
            lblTime.Text = TimeString;

            var h = htmlLabel1.Height;
            if (h > this.Height - 31)
            {
                this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + (htmlLabel1.Height - 31));
            }
        }
    }
}
