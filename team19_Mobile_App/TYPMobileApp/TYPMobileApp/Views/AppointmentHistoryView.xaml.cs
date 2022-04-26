using TYPMobileApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TYPMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentHistoryView : ContentPage
    {
        public AppointmentHistoryView()
        {
            InitializeComponent();
            LabelName.Text = @"Appointment's History of " + Preferences.Get("Email", "Guest") + ",";
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}