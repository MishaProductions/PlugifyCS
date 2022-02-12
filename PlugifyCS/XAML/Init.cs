using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugifyCS.XAML
{
    public static class Init
    {
        public static System.Windows.Application? App;
        public static void InitXAMLUI()
        {
            App = new System.Windows.Application();

            var resources = System.Windows.Application.LoadComponent(
             new Uri("XAML/Styles.xaml", UriKind.Relative))
             as System.Windows.ResourceDictionary;

            // Merge it on application level
            App.Resources.MergedDictionaries.Add(resources);
        }
    }
}
