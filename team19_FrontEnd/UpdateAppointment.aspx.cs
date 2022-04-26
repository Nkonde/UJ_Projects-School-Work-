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
    public partial class UpdateAppointment : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected async void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            fname.Value = name;

        }
        protected async void Book_Clicked(object sender, EventArgs e)
        {
            var email = Request.QueryString["BookingID"];
            string name = Request.QueryString["name"];

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage respond = client.GetAsync("Booking/"+ email + "?date="+date.Value+"&time="+time.Value+"&service="+name).Result;
            var count = respond.Content.ReadAsAsync<int>().Result;


            if (count == 1)
			{
				lblStatus.Text = "Appointment Updated!";
				lblStatus.ForeColor = System.Drawing.Color.Green;
                //Response.Redirect("AppointmentList.aspx?Date=" + date.Value + "&time=" + time.Value + "&service=" + Service.Value+"&update="+1);
            }
			else if(count == -1)
			{

				lblStatus.Text = "Appointment does'nt exist!";
				lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if(count == -2)
            {
                lblStatus.Text = "Error occured while Updating!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }


            
           // Response.Redirect("BookingDetails.aspx");
        }
    }
}