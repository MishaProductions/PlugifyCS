using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlugifyCS.XAML
{
    /// <summary>
    /// Interaction logic for ServerSettings.xaml
    /// </summary>
    public partial class ServerSettings : Page
    {
        public string GroupID { get; set; }
        public ServerSettings(string groupId)
        {
            this.GroupID= groupId;
            InitializeComponent();
        }
    }
}
