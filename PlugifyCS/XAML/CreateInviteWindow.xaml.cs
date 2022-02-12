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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlugifyCS.XAML
{
    /// <summary>
    /// Interaction logic for InviteWindow.xaml
    /// </summary>
    public partial class CreateInviteWindow : Window
    {
        public string GroupID { get; set; }
        public CreateInviteWindow(string groupID)
        {
            InitializeComponent();
            this.GroupID = groupID;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IntPtr windowHandle = new WindowInteropHelper(this).Handle;
            WPFUI.Background.Manager.Apply(WPFUI.Background.BackgroundType.Tabbed, windowHandle);

            var invites = frmMain.ApiPost("https://api.plugify.cf/v2/invites/" + GroupID,
                "{\"uses\": null, \"expires\": null}");

            txtInvite.Text = (string)invites.data.id;
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtInvite.Text);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
