using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;

namespace TYPMobileApp.Services
{
    public class CategoryDataService
    {
        private readonly HttpClient client = new HttpClient(); 
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = JsonConvert.DeserializeObject<List<Category>>(
                                     await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Catergory"));

            return categories;  
        }
    }
}
