﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TYPWebApplication.Models
{
    public class Root
    {
        public int BookingId { get; set; }
        public string Service { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public int StylistID { get; set; }
    }


}