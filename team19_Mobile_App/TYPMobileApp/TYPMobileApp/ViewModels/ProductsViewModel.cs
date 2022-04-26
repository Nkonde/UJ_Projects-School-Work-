using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using TYPMobileApp.Services;
using TYPMobileApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class ProductsViewModel : BaseViewModel
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

        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            set
            {
                _UserCartItemsCount = value;
                OnPropertyChanged();
            }

            get
            {
                return _UserCartItemsCount;
            }
        }

        private string _SearchText;
        public string SearchText
        {
            set
            {
                _SearchText = value;
                OnPropertyChanged();
            }

            get
            {
                return _SearchText;
            }
        }

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<PolishItem> LatestItems { get; set; }

        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand { get; set; }
        public Command ViewOrdersHistoryCommand { get; set; }
        public Command SearchViewCommand { get; set; }

        public  ProductsViewModel()
        {
            var username = Preferences.Get("Email", String.Empty);
            if(String.IsNullOrEmpty(username))
            {
                Email = "Guest";
            }
            else
            {
                Email = username; 
            }

            UserCartItemsCount = new CartItemService().GetUserCartCount(); 

            Categories = new ObservableCollection<Category>();
            LatestItems = new ObservableCollection<PolishItem>();

            ViewCartCommand = new Command(async () => await ViewCartAsync());
            LogoutCommand = new Command(async () => await LogoutAsync());
            ViewOrdersHistoryCommand = new Command(async () => await ViewOrderHistoryAsync());
            SearchViewCommand = new Command(async () => await SearchViewAsync());

            GetCategories();
            GetLatestItmes();
        }

        private async Task SearchViewAsync()
        {
           await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new SearchResultsView(SearchText)));
        }

        private async Task ViewOrderHistoryAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new OrdersHistoryView()));
        }

        public async  void GetCategories()
        {
            var data = await new CategoryDataService().GetCategoriesAsync(); 
            Categories.Clear(); 
            foreach(var item in data)
            {
                Categories.Add(item);
            }
        }
        public async void GetLatestItmes()
        {
            var data = await new PolishItemService().GetLatestPolishItemsAsync(); 
            LatestItems.Clear(); 
            foreach(var item in data)
            {
                LatestItems.Add(item);
            }
        }

        public async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CartView()));
        }

        public async Task LogoutAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new LogoutView()));
        }
    }
}
