using System;
using System.Threading.Tasks;
using TYPMobileApp.Repositories;
using TYPMobileApp.Services;

using TYPMobileApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Name; 
        public string Name
        {
            get => _Name;
            set
            {
                this._Name = value;
                OnPropertyChanged();
            }
        }

        private string _Surname;
        public string Surname
        {
            get => _Surname;
            set
            {
                this._Surname = value;
                OnPropertyChanged();
            }
        }

        private string _Email;
        public string Email
        {
            get => _Email; 
            set
            {
                this._Email = value;
                OnPropertyChanged(); 
            }
        }

        private string _Password;
        public string Password
        {
            get =>_Password;
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
        }


        private string _Phonenumber;
        public string Phonenumber
        {
            get => _Phonenumber;
            set
            {
                this._Phonenumber = value;
                OnPropertyChanged();
            }
        }

        private string _Address;
        public string Address
        {
            get => _Address;
            set
            {
                this._Address = value;
                OnPropertyChanged();
            }
        }

        private string _Gender;
        public string Gender
        {
            get => _Gender;
            set
            {
                this._Gender = value;
                OnPropertyChanged();
            }
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            get =>_IsBusy;
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
        }


        private bool _Result;
        public bool Result
        {
            get => _Result;
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
        }

        private bool _Disable;
        public bool Disable
        {
            get => _Disable;
            set
            {
                _Disable = value;
                OnPropertyChanged();
            }
        }
        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }
        public Command SubmitCommand { get; set; }
        public LoginViewModel()
        {
            Disable = false;

            LoginCommand = new Command(async() => await LoginCommandAsync());
            RegisterCommand = new Command(async() => await RegisterCommandAsync());
            SubmitCommand = new Command(async() => await SubmitCommandAsync()); 
        }

        private async Task SubmitCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Register());
        }

        private async Task RegisterCommandAsync()
        {
            if(IsBusy)
                return;

            try
            {
                IsBusy = true;
                var userService = DependencyService.Get<IUserService>(); 
                Result = await userService.RegisterUser(Name, Surname, Email, Password, Phonenumber, Address, Gender = "Female");
                if(Result)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "User Registered", "OK");
                    await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "User already exists with this credentials", "OK");
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK"); 
            }
            finally
            {
                IsBusy = false; 
            }
        }

        private async Task LoginCommandAsync()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;
               // var userService = new UserService();
                var userService = DependencyService.Get<IUserService>();
                Result = await userService.LoginUser(Email, Password); 
                if(Result)
                {
                    Preferences.Set("Email", Email);
                    Application.Current.Properties["LoggedIn"] = Email; 
                    await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new BookingsView())); 
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid Email or Password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
