using System;
using System.Threading.Tasks;
using TYPMobileApp.Services;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        private string _CardNumber;
        public string CardNumber
        {
            get => _CardNumber;
            set
            {
                this._CardNumber = value;
                OnPropertyChanged();
            }
        }

        private long _Expiry;
        public long Expiry
        {
            get => _Expiry;
            set
            {
                this._Expiry = value;
                OnPropertyChanged();
            }
        }

        private string _Cvc;
        public string Cvc
        {
            get => _Cvc;
            set
            {
                this._Cvc = value;
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

        private bool _IsBusy;
        public bool IsBusy
        {
            get => _IsBusy;
            set
            {
                this._IsBusy = value;
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

        public Command PaymentCommand { get; set; }

        public PaymentViewModel()
        {
            PaymentCommand = new Command(async () => await PaymentCommandAsync());
        }

        private async Task PaymentCommandAsync()
        {
            try
            {
                var card = new OrderService();
                var t =  card.ProcessPayment(CardNumber, Expiry, Cvc);
                await Application.Current.MainPage.DisplayAlert("Success", "Payment was successful", "OK");

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