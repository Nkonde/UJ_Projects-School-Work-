﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TYPMobileApp.Models
{
    public class PolishItem
    {
        public int ItemId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string RatingDetails { get; set; }
        public string HomeSelected { get; set; }
        public decimal Price { get; set; }
        public int ItemQTY { get; set; }
        public int CategoryId { get; set; }
    }
}
