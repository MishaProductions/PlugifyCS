using LibPlugifyCS;
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
        private frmMain instance { get; set; }

        bool isOwner = false;
        dynamic? groupInfo;
        public ServerSettings(string groupId, frmMain instance)
        {
            this.GroupID = groupId;
            this.instance = instance;
            InitializeComponent();
            Loaded += ServerSettings_Loaded;
        }

        private void ServerSettings_Loaded(object sender, RoutedEventArgs e)
        {
            groupInfo = frmMain.ApiGet("https://api.impulse.chat/v2/groups/" + this.GroupID);

            if ((bool)groupInfo.success)
            {
                isOwner = groupInfo.data.owner == instance.client.CurrentUser?.UserName;
                if (!isOwner)
                {
                    btnDeleteServer.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error while getting group info: " + PlugifyErrorCode.Tostring((int)groupInfo.error));
            }
        }

        private void btnDeleteServer_Click(object sender, RoutedEventArgs e)
        {
            if (groupInfo != null)
            {
                if ((bool)groupInfo.success)
                {
                    var hr = System.Windows.Forms.MessageBox.Show("Are you sure you want to delete the group \"" + (string)groupInfo.data.name + "\". This operation cannot be ", "Question or and warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (hr == DialogResult.Yes)
                    {
                        var hResult = frmMain.ApiDelete("https://api.impulse.chat/v2/groups/" + this.GroupID);

                        if ((bool)hResult.success)
                        {

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Error while deleting group: " + PlugifyErrorCode.Tostring((int)hResult.error));
                        }
                    }
                }
            }

        }
    }
}
