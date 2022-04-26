using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using TYPMobileApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TYPMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingsView : ContentPage
    {
        public BookingsView()
        {
            InitializeComponent();
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

        async void CV_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var selectedStyle = e.CurrentSelection.FirstOrDefault() as Styles;
            if (selectedStyle == null)
                return;
            await Navigation.PushModalAsync(new NavigationPage(new BookingDetailsView(selectedStyle)));
            ((CollectionView)sender).SelectedItem = null;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ProductsView()));
        }
    }
}