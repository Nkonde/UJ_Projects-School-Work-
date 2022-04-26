using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class EmployeeReport : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:44301/api/");
            var UserID = Session["LoggedInUserID"];

            HttpResponseMessage cartNumber = client.GetAsync("Booking?AllBookings=1&userID=" + UserID).Result;
            var count = cartNumber.Content.ReadAsAsync<List<Class1>>().Result;
            string display = "";
            foreach (var x in count)
            {

                if (x.Status == "Waiting")
                {
                    

                        
                    display += "<div class='text-center'>Waiting</div>";
                    display += "<div class='mb-3 progress'>";
                    display += "<div class='progress-bar' role='progressbar' aria-valuenow='0' aria-valuemin='0' aria-valuemax='50' style='width: 50%;'></div>";
                    display += "</div>";
                }
                if (x.Status == "Completed")
                {
                    HttpResponseMessage cart = client.GetAsync("Booking?power=1&tent=1&userID=" + UserID).Result;
                    var total = cart.Content.ReadAsAsync<int>().Result;

                    var ans = total / 25 * 100;

                    display += "<div class='text-center'>Completed</div>";
                    display += "<div class='mb-3 progress'>";
                    display += "<div class='progress-bar' role='progressbar' aria-valuenow='0' aria-valuemin='0' aria-valuemax='100' style='width: "+ ans + "%;'></div>";
                    display += "</div>";
                }

            }
            treport.InnerHtml = display;
        }
    }
}