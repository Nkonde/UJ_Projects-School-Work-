using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TYPWebApplication.Models
{
    public class StockOrder
    {
        /*
                public int Id { get; set; }
                public string Name_ { get; set; }
                public double Price_ { get; set; }
                public DateTime OderDate { get; set; }
                public int QTY { get; set; }
                public string Supplier { get; set; }
                public int Status { get; set; }
                public int stockID { get; set; */

        public int Id { get; set; }
        public string Name_ { get; set; }
        public double Price_ { get; set; }
        public DateTime OderDate { get; set; }
        public int QTY { get; set; }
        public string Supplier { get; set; }
        public int Status { get; set; }
        public int stockID { get; set; }
        public int notification { get; set; }
        public int userNotif { get; set; }
    }
}