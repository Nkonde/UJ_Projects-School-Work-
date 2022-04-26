using System;
using TYPMobileApp.Salon;
using TYPMobileApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TYPMobileApp.Repositories;
using TYPMobileApp.Services;
using Plugin.SharedTransitions;
using Plugin.FirebasePushNotification;

[assembly: ExportFont("materialdesignicon.ttf")]
[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias = "MyIcon")]

namespace TYPMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] {
                "AppTheme_Experimental",
                "MediaElement_Experimental"
                });

            InitializeComponent();  


            //MainPage = new NavigationPage(new SettingPage());
           MainPage = new NavigationPage(new LoginView());

            /* string email = Preferences.Get("Email", String.Empty);
             if(String.IsNullOrEmpty(email))
             {
                 MainPage = new NavigationPage(new LoginView());
             }
             else
             {
                 MainPage = new NavigationPage(new ProductsView());
             }*/
            CrossFirebasePushNotification.Current.OnTokenRefresh += Current_OnTokenRefresh;
        }

        private void Current_OnTokenRefresh(object source, FirebasePushNotificationTokenEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Token: {e.Token}");
        }

        protected override void OnStart()
        { 
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
           // MainPage = new BookingsView();
        }
    }
}
