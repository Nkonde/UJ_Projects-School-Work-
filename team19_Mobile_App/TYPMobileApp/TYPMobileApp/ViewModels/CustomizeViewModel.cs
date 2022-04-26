using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Views;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class CustomizeViewModel : BaseViewModel
    {
        public Command CustomizeCommand { get; set; }

        public CustomizeViewModel()
        {
            CustomizeCommand = new Command(async () => await CustomizeAsync());
        }

        private async Task CustomizeAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CustomizeView()));
        }
    }
}
