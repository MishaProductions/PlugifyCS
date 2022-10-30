﻿using LibPlugifyCS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

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
            this.ContentDialog.PrimaryButtonClick += ContentDialog_CloseButtonClick;
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
                return;
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
                Console.WriteLine("image: w=" + bitmap.PixelWidth + ",h=" + bitmap.PixelHeight);

                ServersList.Items.Add(new ServerListClass() { ServerName = item.Name, ServerImage = bitmap });
            }

            var fullfFilePath = @"http://cds.impulse.chat/defaultAvatars/" + client.CurrentUser.PFPUrl;

            BitmapImage bitmap2 = new BitmapImage();
            bitmap2.UriSource = new Uri(fullfFilePath, UriKind.Absolute);
            UserProfilePicture.ImageSource = bitmap2;
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
        }
        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            DoLogout();
        }


        private void DoLogout()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values.Remove("token");
            Frame.Navigate(typeof(LogonUI));
        }

        private void OpenSettings()
        {
            Frame.Navigate(typeof(Settings), null, new DrillInNavigationTransitionInfo());
        }
    }
    public class ServerListClass
    {
        public ImageSource ServerImage { get; set; }
        public string ServerName { get; set; }
    }
}
