using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TYPWebApplication.Models
{
    public class Rating
    {
         
        public int ratingId { get; set; }
        public int NumberOfStar { get; set; }
        public string Feedback { get; set; }
        public int userId { get; set; }
        public int stylistID { get; set; }
 

}
}