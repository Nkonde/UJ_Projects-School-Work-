using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TYPMobileApp.Models;
using TYPMobileApp.Services;

namespace TYPMobileApp.ViewModels
{
    public class SearchResultsViewModel : BaseViewModel
    {
        public ObservableCollection<PolishItem> PolishItemsByQuery { get; set; }

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

        public SearchResultsViewModel(string searchText)
        {
            PolishItemsByQuery = new ObservableCollection<PolishItem>();
            GetPolishItemsByQuery(searchText);
        }

        private async void GetPolishItemsByQuery(string searchText)
        {
            var data = await new PolishItemService().GetPolishItemsByQueryAsync(searchText);
            PolishItemsByQuery.Clear();
            foreach (var item in data)
            {
                PolishItemsByQuery.Add(item);
            }
            TotalPolishItems = PolishItemsByQuery.Count;
        }
    }
}
