using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TYPMobileApp.Models;
using TYPMobileApp.Services;

namespace TYPMobileApp.ViewModels
{
    public class AppointmentHistoryViewModel : BaseViewModel
    {
        public ObservableCollection<AppHistory> Histories { get; set; }

        public AppointmentHistoryViewModel()
        {
            Histories = new ObservableCollection<AppHistory>();
            GetHistories();
        }

        public async void GetHistories()
        {
            var data = await new AppHistoryService().GetHistory();
           // Histories.Clear();
            foreach (var item in data)
            {
                Histories.Add(item);
            }
        }
    }
}
