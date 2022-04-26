using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;

namespace TYPMobileApp.Services
{
    public class StylesService
    {
        private readonly HttpClient client = new HttpClient();
       public async Task<List<Styles>> GetStyles()
        {
            var styles = JsonConvert.DeserializeObject<List<Styles>>(
                                   await client.GetStringAsync("https://typapi.azurewebsites.net/api/AppBooking"));

            return styles;
        }
    }
}
