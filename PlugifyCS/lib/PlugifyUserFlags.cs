using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugifyCS.lib
{
    [Flags]
    public enum PlugifyUserFlags: int
    {
        Pro = 1,
        Dev = 2,
        Early = 3,
        ClosedBeta = 4,
        System = 5
    }
}
