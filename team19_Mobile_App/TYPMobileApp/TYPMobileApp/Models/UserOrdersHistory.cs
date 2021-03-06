using System;
using System.Collections.Generic;
using System.Text;

namespace TYPMobileApp.Models
{
    public class UserOrdersHistory : List<OrderDetails>
    {
        public string OrderId { get; set; }
        public string Username { get; set; }
        public decimal TotalCost { get; set; }
        public string ReceiptId { get; set; }
    }
}
