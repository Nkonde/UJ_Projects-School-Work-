using Newtonsoft.Json;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using TYPMobileApp.Services;
using TYPMobileApp.ViewModels;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TYPMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingDetailsView : ContentPage
    {
        private readonly HttpClient client = new HttpClient();

        BookingDetailsViewModel bvm;
        private string styleType = "";
        public BookingDetailsView(Styles styles)
        {
            tenNames();
            styleType = styles.Name; 
            InitializeComponent();
            bvm = new BookingDetailsViewModel(styles);
            this.BindingContext = bvm;

           // NotificationCenter.Current.NotificationReceived += Current_NotificationReceived;
            NotificationCenter.Current.NotificationTapped += Current_NotificationTapped;
        }


        private async void tenNames()
        {
            var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/TimeSlot");
            var Timeslot = JsonConvert.DeserializeObject<List<TimeSlot>>(response);

            foreach (var t in Timeslot)
            {
                PickerCustomer.Items.Add(t.A_TIME);
            }
        }
        async void ImageButtom_CLicked(Object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void Current_NotificationTapped(NotificationTappedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Navigation.ShowPopup(new RatingView()); 
            }); 
        }
        private void Current_NotificationReceived(NotificationReceivedEventArgs e)
        {
            /*Device.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert(e.Title, e.Description, "OK");
            });*/
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var getUser = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?email=" + Application.Current.Properties["LoggedIn"]);
            var userDetails = JsonConvert.DeserializeObject<User>(getUser);

            //; ;

            var response = await client.GetStringAsync($"https://typapi.azurewebsites.net/api/AppBooking?service={styleType}&date={TheDatePicker.Date.ToLongDateString()}&time={PickerCustomer.SelectedItem}&status=Waiting&userId={userDetails.Id}&s={2}");
            var user = JsonConvert.DeserializeObject<int>(response);

            if (user == 1)
            {
                await DisplayAlert("Success", "Appointment Booked", "OK");

                var notification = new NotificationRequest
                {
                    BadgeNumber = 1,
                    Description = "Please rate our employee",
                    Title = "Notification!",
                    ReturningData = "Rate employee",
                    NotificationId = 1337, 
                    NotifyTime = DateTime.Now.AddSeconds(5)
                };

                NotificationCenter.Current.Show(notification); 
            }
            else if (user == 0)
            {
                await DisplayAlert("Error", "Spotted Already Taken", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Occured While Booking Appointment", "OK");
            }

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

        //https://typapi.azurewebsites.net/api/AppBooking?service={service}&date={date}&time={time}&status={status}&userId={userId}&s={s}
    }
}