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
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }

        private readonly HttpClient client = new HttpClient();
             
        public AddCategoryData()
        {
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryName = "Maxolo",
                    CategoryPoster = "Maxolo",
                    ImageUrl = "sl2.jpg",
                }
            }; 
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    var addCategory = JsonConvert.DeserializeObject<int>(
                                     await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Catergory?name={category.CategoryName}&poster={category.CategoryPoster}&image={category.ImageUrl}"));
                    if (addCategory == 1)
                        await Application.Current.MainPage.DisplayAlert("Success", "Category Successfully Added", "OK");
                    else if (addCategory == 0)
                        await Application.Current.MainPage.DisplayAlert("Error", "Category Already exists, Add quantity!", "OK");
                    else
                        await Application.Current.MainPage.DisplayAlert("Error", "Error occured while adding csategory", "OK");
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK"); 
            }
        }
    }
}
