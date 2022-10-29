using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS.Controls
{
    public class RoundPicture : Control
    {
        private bool hover;
        private bool NiceButton = false;
        private Color btncolor = Color.FromArgb(44, 44, 57);
        private Color btnHover = Color.FromArgb(79, 79, 82);
        public Color ButtonColor
        {
            get { return btncolor; }
            set { btncolor = value; Invalidate(); }
        }
        public Color HoverColor
        {
            get { return btnHover; }
            set { btnHover = value; Invalidate(); }
        }
        public bool IsGoodLookingButton
        {
            get
            {
                return NiceButton;
            }
            set
            {
                NiceButton = value;
                Invalidate();
            }
        }
        public RoundPicture()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }
        public void SetURL(string channelID, string url = "")
        {
            channelID = channelID.Replace("{", "").Replace("}", "");

            string cachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\PlugifyCS";
            string cacheImage = cachePath + @"\" + channelID + ".png";

            if (!Directory.Exists(cachePath))
            {
                Directory.CreateDirectory(cachePath);
            }
            if (File.Exists(cacheImage))
            {
                BackgroundImage = Bitmap.FromFile(cacheImage);
                return;
            }

            string url2 = "https://cds.impulse.chat/defaultAvatars/" + channelID;
            //if (url != "https://cds.plugify.cf/avatars/default_avatar.png" && url != "" && url!=null)
            //    url2 = url;

            if (url == "https://cds.impulse.chat/avatars/default_avatar.png")
            {
                //impulse doesn't support https yet
                url = url2.Replace("https","http");
            }
            try
            {
                var request = WebRequest.Create(url2);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    var b = Bitmap.FromStream(stream);
                    BackgroundImage = b;
                    if (!cacheImage.Contains("|"))
                        b.Save(cacheImage, ImageFormat.Png);
                }
                request = null;
            }
            catch { }
        }
        public void SetURL(string url, string display, int a = 0)
        {
            string cachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\PlugifyCS";
            string cacheImage = cachePath + @"\" + display + ".png";

            if (!Directory.Exists(cachePath))
            {
                Directory.CreateDirectory(cachePath);
            }
            if (File.Exists(cacheImage))
            {
                BackgroundImage = Bitmap.FromFile(cacheImage);
                return;
            }

            var request = WebRequest.Create(url);

            try
            {
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    var b = Bitmap.FromStream(stream);
                    BackgroundImage = b;
                    if (!cacheImage.Contains("|"))
                        b.Save(cacheImage, ImageFormat.Png);
                }
                request = null;
            }
            catch
            {

            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                Region = new Region(gp);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
            }

            if (IsGoodLookingButton)
            {
                var rect = new Rectangle(0, 0, Width - 1, Height - 1);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                if (hover)
                {
                    e.Graphics.DrawEllipse(new Pen(this.HoverColor, 5f), rect);
                }
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            hover = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hover = false;
            Invalidate();
        }
    }
}
