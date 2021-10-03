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
        public RoundPicture()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }
        public void SetURL(string avatorName)
        {
            string cachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\temp\PlugifyCS";
            string cacheImage = cachePath + @"\" + avatorName + ".png";

            if (!Directory.Exists(cachePath))
            {
                Directory.CreateDirectory(cachePath);
            }
            if (File.Exists(cacheImage))
            {
                BackgroundImage = Bitmap.FromFile(cacheImage);
                return;
            }


            var request = WebRequest.Create("https://cds.plugify.cf/defaultAvatars/" + avatorName);

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
        }
    }
}
