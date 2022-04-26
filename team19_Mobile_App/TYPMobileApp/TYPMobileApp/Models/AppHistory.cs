using System;
using System.Collections.Generic;
using System.Text;

namespace TYPMobileApp.Models
{
    public class AppHistory
    {
        public int BookingId { get; set; }
        public string Service { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public int StylistID { get; set; }
    }
}
