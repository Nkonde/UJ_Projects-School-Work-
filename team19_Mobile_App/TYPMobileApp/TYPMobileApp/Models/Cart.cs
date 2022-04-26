using System;
using System.Collections.Generic;
using System.Text;

namespace TYPMobileApp.Models
{
    public class Cart
    {
        public string Email { get; set; }
        public int CartId { get; set; }
        public List<CartItem> CartItems  { get; set; }
    }
}
