using LibPlugifyCS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ImpulseCS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogonUI : Page
    {
        public LogonUI()
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
            string password = txtToken.Password;
            if (string.IsNullOrEmpty(password))
            {
                await this.ContentDialog.ShowAsync();
                LoadingThingy.Visibility = Visibility.Collapsed;
                txtToken.IsEnabled = true;
                btnQuit.IsEnabled = true;
                btnLogin.IsEnabled = true;
                return;
            }
            try
            {
                await c.Start(password, true);
            }
            catch (Exception ex)
            {
                LoadingThingy.Visibility = Visibility.Collapsed;
                txtToken.IsEnabled = true;
                btnQuit.IsEnabled = true;
                btnLogin.IsEnabled = true;
                lblLoginStatus.Text = ex.ToString();
                return;
            }

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["token"] = password;
            c.Close();
            this.Frame.Navigate(typeof(ShellUI));

        }

        private void QuitButton()
        {
            Application.Current.Exit();
        }
    }
}
