using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Helpers;
using TYPMobileApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TYPMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomizeView : ContentPage
    {
        public CustomizeView()
        {
            InitializeComponent();
        }

        int ratingPoint = 0;
        void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.StarOutline;
            MyStar3.Text = IconFont.StarOutline;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 1;
        }

        void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.StarOutline;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 2;
        }

        void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.Star;
            MyStar4.Text = IconFont.StarOutline;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 3;
        }

        void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.Star;
            MyStar4.Text = IconFont.Star;
            MyStar5.Text = IconFont.StarOutline;
            ratingPoint = 4;
        }

        void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            MyStar1.Text = IconFont.Star;
            MyStar2.Text = IconFont.Star;
            MyStar3.Text = IconFont.Star;
            MyStar4.Text = IconFont.Star;
            MyStar5.Text = IconFont.Star;
            ratingPoint = 5;
        }
        private async void Booking_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new BookingsView()));
        }

        private async void Customize_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CustomizeView()));
        }

        private async void Shoping_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ProductsView()));
        }

        private async void Profile_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ProfileView()));
        }

        private async void Logout_Clicked(object sender, EventArgs e)
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
            Preferences.Remove("Email");
            Application.Current.Properties["LoggedIn"] = null;
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView());
        }
    }
}