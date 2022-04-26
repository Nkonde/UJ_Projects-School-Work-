using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using Xamarin.Forms;

namespace TYPMobileApp.Helpers
{
    public class AddPolishItemData
    {
        public List<PolishItem> PolishItems { get; set;  }
        private readonly HttpClient client = new HttpClient(); 
        public AddPolishItemData()
        {
            PolishItems = new List<PolishItem>()
            {
                new PolishItem
                {
                    CategoryId = 3,
                    ImageUrl = "sl1.jpg",
                    Name = "Magxolo",
                    Description = "1",
                    Rating = " 4.8",
                    RatingDetails = " (121 ratings)",
                    HomeSelected = "Compl",
                    Price = 45,
                    ItemQTY = 45
                }
            };
        }

        public async Task AddPolishItemAsync()
        {
            try
            {
                foreach (var item in PolishItems)
                {
                    var addProducts = JsonConvert.DeserializeObject<int>(
                                    await client.GetStringAsync($"https://typapi.azurewebsites.net/api/PolishItem?image={item.ImageUrl}&name={item.Name}&description={item.Description}&rating={item.Rating}&ratingdetails={item.RatingDetails}&homeselected={item.HomeSelected}&price={item.Price}&categoryId={item.CategoryId}&itemQTY={item.ItemQTY}"));
                    
                    if(addProducts == 1)
                        await Application.Current.MainPage.DisplayAlert("Success", "Products Successfully Added", "OK");
                    else if(addProducts == 0)
                        await Application.Current.MainPage.DisplayAlert("Error", "Products Already exists, Add quantity!", "OK");
                    else
                        await Application.Current.MainPage.DisplayAlert("Error", "Error occured while adding products", "OK");
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
