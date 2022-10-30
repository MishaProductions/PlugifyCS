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
using Windows.Storage;
using LibPlugifyCS;
using Microsoft.UI.Xaml.Media.Imaging;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ImpulseCS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShellUI : Page
    {
        PlugifyCSClient client = new PlugifyCSClient();
        public ShellUI()
        {
            this.InitializeComponent();
        }

        private async void ShellUI_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            try
            {
                await client.Start((string)localSettings.Values["token"]);
            }
            catch (Exception ex)
            {
                //invaild token
                DoLogout();
            }

            var x = new DispatcherTimer();
            x.Interval = TimeSpan.FromSeconds(25);
            x.Tick += Timer_Tick;
            x.Start();
            Username.Text = client.CurrentUser.UserName;
            foreach (var item in client.Groups)
            {
                var image = new Image();
                var fullFilePath = @"http://cds.impulse.chat/defaultAvatars/" + item.ID;

                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);

                ServersList.Items.Add(new ServerListClass() { ServerName = item.Name, ServerImage = bitmap });
            }
            LoadingSplash.Visibility = Visibility.Collapsed;
        }

        private async void Timer_Tick(object sender, object e)
        {
            await client.SendPing();
        }
        //Logout button logic
        private async Task Logout()
        {
            await this.ContentDialog.ShowAsync();
            ContentDialog.PrimaryButtonClick += ContentDialog_CloseButtonClick;
        }
        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            DoLogout();
        }


        private void DoLogout()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values.Remove("token");
            Frame.Navigate(typeof(LoginUI));
        }

        
    }
    public class ServerListClass
    {
        public ImageSource ServerImage;
        public string ServerName;
    }
}
