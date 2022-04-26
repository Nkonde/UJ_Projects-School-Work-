using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using TYPMobileApp.Services;
using TYPMobileApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class BookingsViewModel : BaseViewModel
    {
        private string _Email;
        public string Email
        {
            set
            {
                _Email = value;
                OnPropertyChanged();
            }

            get
            {
                return _Email;
            }
        }

        public ObservableCollection<Styles> OCStyles { get; set; }
        public Command ViewAppointmentHistoryCommand { get; set; }

        public BookingsViewModel()
        {
             var email = Preferences.Get("Email", String.Empty);
            if(String.IsNullOrEmpty(email))
            {
                Email = "Guest";
            }
            else
            {
                Email = email; 
            }

            OCStyles = new ObservableCollection<Styles>();

            GetStyles();

            ViewAppointmentHistoryCommand = new Command(async () => await ViewAppointmentHistoryCommandAsync());
        }

        private async Task ViewAppointmentHistoryCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AppointmentHistoryView()));
        }

        public async void GetStyles()
        {
            var data = await new StylesService().GetStyles();
            OCStyles.Clear();
            foreach (var item in data)
            {
                OCStyles.Add(item);
            }
        }
    }
}
