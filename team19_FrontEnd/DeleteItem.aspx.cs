using Newtonsoft.Json;
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
    public partial class BookingDetails : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
      
        protected  void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            int bookingID = Convert.ToInt32(Request.QueryString["BookingID"]);

            HttpResponseMessage respond = client.GetAsync("Booking?appointmentID=" + bookingID).Result;
            Boolean count = respond.Content.ReadAsAsync<Boolean>().Result;

            Response.Redirect("AppointmentList.aspx");
            if (count == true)
            {
                return;
            }
            else
            {
                cancelAppointment();
            }

        }

        public  void cancelAppointment()
        {
           Response.Redirect("AppointmentList.aspx");

        }
    }
}