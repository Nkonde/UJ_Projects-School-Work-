using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TYPWebApplication.Models
{
    public class CartItem
    {
        public int Cart_Id { get; set; }
        public double C_Amount { get; set; }
        public DateTime C_Date { get; set; }
        public int U_ID { get; set; }
        public int Item_ID { get; set; }
        public string C_Status { get; set; }
        public int ItemQuality { get; set; }


    }
}