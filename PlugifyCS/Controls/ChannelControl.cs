using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlugifyCS.Controls
{
    public class ChannelControl : Button
    {
        public ChannelControl()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }
    }
}
