using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;

namespace TYPMobileApp.Services
{
    public class PolishItemService
    {
        private readonly HttpClient client = new HttpClient();
    
        public async Task<List<PolishItem>> GetPolishItemsAsync()
        {
            var products = JsonConvert.DeserializeObject<List<PolishItem>>(
                                   await client.GetStringAsync("https://typapi.azurewebsites.net/api/PolishItem"));

            return products; 
        }

        public async Task<ObservableCollection<PolishItem>> GetPolishItemsByCategoryAsync(int categoryID)
        {
            var polishItemsByCategory = new ObservableCollection<PolishItem>();
            var items = (await GetPolishItemsAsync()).Where(p => p.CategoryId == categoryID).ToList();
            foreach(var item in items)
            {
                polishItemsByCategory.Add(item);
            }
            return polishItemsByCategory;
        }

        public async Task<ObservableCollection<PolishItem>> GetLatestPolishItemsAsync()
        {
            var latestPolishItems = new ObservableCollection<PolishItem>();
            var items = (await GetPolishItemsAsync()).OrderByDescending(f => f.ItemId).Take(3); 
            foreach(var item in items)
            {
                latestPolishItems.Add(item); 
            }
            return latestPolishItems; 
        }

        public async Task<ObservableCollection<PolishItem>> GetPolishItemsByQueryAsync(string searchText)
        {
            var polishItemsByQuery = new ObservableCollection<PolishItem>();
            var items = (await GetPolishItemsAsync()).Where(p => p.Name.Contains(searchText)).ToList();
            foreach (var item in items)
            {
                polishItemsByQuery.Add(item);
            }
            return polishItemsByQuery;
        }
    }
}
