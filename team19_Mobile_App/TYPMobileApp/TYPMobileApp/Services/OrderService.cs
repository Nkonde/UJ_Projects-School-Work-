using Newtonsoft.Json;
using System;
using Stripe;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using TYPMobileApp.Views;
using TYPMobileApp.ViewModels;

namespace TYPMobileApp.Services
{
    public class OrderService
    {
        private readonly HttpClient client = new HttpClient(); 
        public string OrderId { get; set;  }
        public decimal TotalCost { get; set;  }
        public List<CartItem> Data { get; set;  }

        public OrderService()
        {
            OrderId = Guid.NewGuid().ToString();
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            Data = cn.Table<CartItem>().ToList();
            TotalCost = Data.Sum(d => d.Quantity * d.Price);
        }

        public async Task ProcessPayment(string number, long expiry, string cvc)
        {
            try
            {              
                StripeConfiguration.SetApiKey("sk_test_51JdZS0JDcwy48DVwXPK1ndh559JEt9spWQQVyKXe5U5Z0iHZlH0PG9hACcJBWyXymoy2OOhRYTHzyzwvGsEsNi1n004BoPlz0a");

                Stripe.CreditCardOptions stripecard = new CreditCardOptions();
                stripecard.Number = number;
                stripecard.ExpYear = expiry;
                stripecard.ExpMonth = 08;
                stripecard.Cvc = cvc;

                Stripe.TokenCreateOptions token = new Stripe.TokenCreateOptions();
                token.Card = stripecard;
                Stripe.TokenService tokenService = new Stripe.TokenService();
                Stripe.Token newToken = tokenService.Create(token);

                var options = new SourceCreateOptions
                {
                    Type = SourceType.Card,
                    Currency = "usd",
                    Token = newToken.Id
                };

                var service = new SourceService();
                Source source = service.Create(options);

                Stripe.CustomerCreateOptions myCutsomer = new Stripe.CustomerCreateOptions()
                {
                    Name = "Nsikayezwe Xhwatha",
                    Email = "Client@typ.com",
                    Description = "TYP Salon"
                };

                var customerSerice = new Stripe.CustomerService();
                Stripe.Customer stripeCustomer = customerSerice.Create(myCutsomer);


                var chargeOptions = new Stripe.ChargeCreateOptions
                {
                    Amount = (long)TotalCost,
                    Currency = "USD",
                    ReceiptEmail = "Client@typ.com",
                    Customer = stripeCustomer.Id,
                    Source = source.Id,
                };

                var service1 = new Stripe.ChargeService();
                Stripe.Charge charge = service1.Create(chargeOptions);

             
                var receiptId = charge.Id;
                await ProcessOrderAsync(receiptId);
                RemoveItemsFromCart();
                await Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new OrdersView(receiptId)));
          
           
                //getChargedId = charge.Id;*/
            }
            catch(Exception e)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", "Error ooccured processing the payment", "OK");
                await Xamarin.Forms.Application.Current.MainPage.Navigation.PopModalAsync();
            }
        }

        public async Task ProcessOrderAsync(string receiptId)
        {                 
            var email = Preferences.Get("Email", "Guest");

            foreach(var item in Data)
            {              
                var od = JsonConvert.DeserializeObject<int>(
                                       await client.GetStringAsync($"https://typapi.azurewebsites.net/api/OrderDetails?orderDetailId={Guid.NewGuid().ToString()}&orderId={OrderId}&productId={item.ProductId}&productName={item.ProductName}&quantity={item.Quantity}&price={item.Price}"));

            }
            var o = JsonConvert.DeserializeObject<int>(
                                      await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Order?orderId={OrderId}&email={email}&totalCosts={TotalCost}&receiptId={receiptId}"));
        }

        private void RemoveItemsFromCart()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart(); 
        }

        public async Task PlaceOrderAsync()
        {
            //   await ProcessPayment();
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new PaymentView()));
        }
    }
}
