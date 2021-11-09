using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS.Controls
{
    public class RoundButton : Control
    {
        private bool hover = false;
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

        public RoundButton()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            var rect = new Rectangle(0, 0, Width - 3, Height - 3);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.FillEllipse(new SolidBrush(this.ButtonColor), rect);
            if (hover)
            {
                e.Graphics.DrawEllipse(new Pen(this.HoverColor, 2.5f), rect);
            }

            //Draw string
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(Text, Font, new SolidBrush(this.ForeColor), rect, stringFormat);
            base.OnPaint(e);
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
