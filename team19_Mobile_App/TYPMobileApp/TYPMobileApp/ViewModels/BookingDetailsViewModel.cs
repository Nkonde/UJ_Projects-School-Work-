using Newtonsoft.Json;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using Xamarin.Forms;

namespace TYPMobileApp.ViewModels
{
    public class BookingDetailsViewModel : BaseViewModel
    {
        private readonly HttpClient client = new HttpClient();

        private DateTime _Time;
        public DateTime Time
        {
            set
            {
                _Time = value;
                OnPropertyChanged();
            }

            get
            {
                return _Time;
            }
        }

        private DateTime _Date;
        public DateTime Date
        {
            set
            {
                _Date = value;
                OnPropertyChanged();
            }

            get
            {
                return _Date;
            }
        } 
        
        private string _Style;
        public string Style
        {
            set
            {
                _Style = value;
                OnPropertyChanged();
            }

            get
            {
                return _Style;
            }
        }


        private Styles _SelectedStyle;
        public Styles SelectedStyle
        {
            set
            {
                _SelectedStyle = value;
                OnPropertyChanged();
            }

            get
            {
                return _SelectedStyle;
            }
        }


       // public Command BookCommand { get; set; }
        public BookingDetailsViewModel(Styles styles)
        {
            SelectedStyle = styles;
        }
    }
}
