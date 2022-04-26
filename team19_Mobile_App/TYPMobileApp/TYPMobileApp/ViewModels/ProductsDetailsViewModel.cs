﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using TYPMobileApp.Views;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class ProductsDetailsViewModel : BaseViewModel
    {
        private PolishItem _SelectedPolishItem;
        public PolishItem SelectedPolishItem
        {
            set
            {
                _SelectedPolishItem = value;
                OnPropertyChanged();
            }

            get
            {
                return _SelectedPolishItem;
            }
        }
        
        private int _TotalQuantity;
        public int TotalQuantity
        {
            set
            {
                _TotalQuantity = value;
                if(this._TotalQuantity < 0)
                {
                    this._TotalQuantity = 0;
                }

                if(this._TotalQuantity > 10)
                {
                    this._TotalQuantity -= 1;
                }
                OnPropertyChanged();
            }

            get
            {
                return _TotalQuantity;
            }
        }

        public Command IncrementOrderCommand { get; set; }
        public Command DecrementOrderCommand { get; set; }
        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }
        public Command HomeCommand { get; set; }

        public ProductsDetailsViewModel(PolishItem polishItem)
        {
            SelectedPolishItem = polishItem;
            TotalQuantity = 0;

            IncrementOrderCommand = new Command(() => IncrementOrder());
            DecrementOrderCommand = new Command(() => DecrementOrder());
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(async () => await ViewCartAsync());
            HomeCommand = new Command(async () => await GotoHomeAsync());
        }

        private async Task GotoHomeAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ProductsView()));
        }
        
        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new CartView()));
        }
        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductId = SelectedPolishItem.ItemId,
                    ProductName = SelectedPolishItem.Name,
                    Price = SelectedPolishItem.Price,
                    Quantity = TotalQuantity
                };
                var item = cn.Table<CartItem>().ToList().FirstOrDefault(c => c.ProductId == SelectedPolishItem.ItemId);
                if (item == null)
                {
                    cn.Insert(ci);
                }
                else
                {
                    item.Quantity += TotalQuantity;
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Selected Item Added to Cart", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
        }
        private void DecrementOrder()
        {
            TotalQuantity--;
        }

        private void IncrementOrder()
        {
            TotalQuantity++;
        }
    }
}
