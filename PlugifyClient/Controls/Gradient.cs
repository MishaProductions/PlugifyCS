using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyClient
{
    public class Gradient : UserControl
    {
        private Color col1 = Color.Red;
        private Color col2 = Color.Green;
        public Color Color1 { get { return col1; } set { col1 = value; Invalidate(); } } 
        public Color Color2 { get { return col2; } set { col2 = value; Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            LinearGradientBrush linearGradientBrush =
   new LinearGradientBrush(this.ClientRectangle, Color1, Color2, 0f);

            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors = new Color[2] { col1, col2 };
            cblend.Positions = new float[2] { 0f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }
    }
}
