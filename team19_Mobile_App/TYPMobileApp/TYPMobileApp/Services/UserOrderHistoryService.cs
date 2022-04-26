using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using Xamarin.Essentials;

namespace TYPMobileApp.Services
{
    public class UserOrderHistoryService
    {
        List<UserOrdersHistory> UserOrders;
        private readonly HttpClient client = new HttpClient(); 

        public UserOrderHistoryService()
        {
            UserOrders = new List<UserOrdersHistory>();
        }

        public async Task<List<UserOrdersHistory>> GetOrderDetailsAsync()
        {
            var email = Preferences.Get("Email", "Guest");

            var listOrders = JsonConvert.DeserializeObject<List<Order>>(
                                     await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Order?email={email}")); 
            
            foreach(var order in listOrders)
            {
                UserOrdersHistory uoh = new UserOrdersHistory();
                uoh.OrderId = order.OrderId;
                uoh.ReceiptId = order.ReceiptId;
                uoh.TotalCost = order.TotalCosts;
                
                var orderDetails = JsonConvert.DeserializeObject<List<OrderDetails>>(
                                    await client.GetStringAsync($"https://typapi.azurewebsites.net/api/OrderDetails?orderId={order.OrderId}"));

                uoh.AddRange(orderDetails);
                UserOrders.Add(uoh);
            }

            return UserOrders;
        }
    }
}
