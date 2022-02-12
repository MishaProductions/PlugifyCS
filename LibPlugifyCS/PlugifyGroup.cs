using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPlugifyCS
{
    public class PlugifyGroup
    {
        public string? Name { get; set; }
        public string? ImageURL { get; internal set; }
        public List<PlugifyUser> Members { get; internal set; } = new List<PlugifyUser>();
        public string? ID { get; internal set; }
        public string? OwnerUsername { get; internal set; }
    }
}
