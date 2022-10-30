using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using LibPlugifyCS;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ImpulseCS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginUI : Page
    {
        public LoginUI()
        {
            this.InitializeComponent();
        }

        private async void LoginButtonClicked()
        {
            LoadingThingy.Visibility = Visibility.Visible;
            txtToken.IsEnabled = false;
            btnQuit.IsEnabled = false;
            btnLogin.IsEnabled = false;
            lblLoginStatus.Text = "";
            PlugifyCSClient c = new PlugifyCSClient();
            try
            {
                await c.Start(txtToken.Password, true);
            }
            catch(Exception ex)
            {
                LoadingThingy.Visibility = Visibility.Collapsed;
                txtToken.IsEnabled = true;
                btnQuit.IsEnabled = true;
                btnLogin.IsEnabled = true;
                lblLoginStatus.Text = ex.ToString();
                return;
            }

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["token"] = txtToken.Password;
            c.Close();
            this.Frame.Navigate(typeof(ShellUI));

        }
    }
}
