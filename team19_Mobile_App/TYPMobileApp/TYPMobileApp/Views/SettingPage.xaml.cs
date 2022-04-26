using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TYPMobileApp.Salon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        async void ButtonCategories_Clicked(object sender, EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }
        async  void ButtonProducts_Clicked(object sender, EventArgs e)
        {
            var afd = new AddPolishItemData();
            await afd.AddPolishItemAsync();
        }

        void ButtonCart_Clicked(object sender, EventArgs e)
        {
            var cct = new CreateCartTable();
            if(cct.CreateTable())
            {
                DisplayAlert("Success", "Cart Table Created", "Ok");
            }
            else
            {
                DisplayAlert("Error", "Error while creating table", "Ok");
            }
        }
    }
}