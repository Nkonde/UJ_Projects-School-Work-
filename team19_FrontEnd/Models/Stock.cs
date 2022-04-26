using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TYPWebApplication.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Supplier { get; set; }
        public int AvaibleStock { get; set; }
        public int Sold { get; set; }
        public int onSpecial { get; set; }
        public string Img { get; set; }
        public int status { get; set; }
        public int maxAmountStock { get; set; }
        public double stockprice { get; set; }
    }
}