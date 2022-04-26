using System.Collections.ObjectModel;
using TYPMobileApp.Models;
using TYPMobileApp.Services;

namespace TYPMobileApp.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        private Category _SelectedCategory; 
        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged(); 
            }

            get
            {
                return _SelectedCategory;
            }
        }

        public ObservableCollection<PolishItem> PolishItemsByCategory { get; set; }

        private int _TotalPolishItems;
        public int TotalPolishItems
        {
            set
            {
                _TotalPolishItems = value;
                OnPropertyChanged();
            }

            get
            {
                return _TotalPolishItems;
            }
        }

        public CategoryViewModel(Category category)
        {
            SelectedCategory = category;
            PolishItemsByCategory = new ObservableCollection<PolishItem>();
            GetPolishItems(category.CategoryId);
        }

        private async void GetPolishItems(int categoryId)
        {
            var data = await new PolishItemService().GetPolishItemsByCategoryAsync(categoryId);
            
            PolishItemsByCategory.Clear();
            foreach (var item in data)
            {
                PolishItemsByCategory.Add(item);
            }
            TotalPolishItems = PolishItemsByCategory.Count;
        }
    }
}
