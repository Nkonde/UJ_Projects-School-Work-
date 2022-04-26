using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using Xamarin.Forms;

namespace TYPMobileApp.Services
{
    public class AppHistoryService
    {
        private readonly HttpClient client = new HttpClient();
        public async Task<List<AppHistory>> GetHistory()
        {
            var user = JsonConvert.DeserializeObject<User>(
                                   await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Users?email={Application.Current.Properties["LoggedIn"]}"));
            
            var list = JsonConvert.DeserializeObject<List<AppHistory>>(
                                   await client.GetStringAsync($"https://typapi.azurewebsites.net/api/AppBooking?bookingId={user.Id}"));

            return list;
        }
    }
}
