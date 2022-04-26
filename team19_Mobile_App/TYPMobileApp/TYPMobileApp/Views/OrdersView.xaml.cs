using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TYPMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersView : ContentPage
    {
        public OrdersView(string id)
        {
            InitializeComponent();
            LabelName.Text = "Welcome " + Preferences.Get("Email", "Guest") + ",";
            LabelOrderID.Text = id; 
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ProductsView()));
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