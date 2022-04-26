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
    public partial class TimeSlot : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            Session["PickDate"] = date.Value;
        }

        protected void Book_Clicked(object sender, EventArgs e)
        {
            string styleID = Request.QueryString["StylistID"];
            string name = Request.QueryString["StylName"];
            string image = Request.QueryString["image"];
            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);


            String display = "";
            HttpResponseMessage assinged = client.GetAsync("Booking?allTime=" + 1).Result;
            var Well = assinged.Content.ReadAsAsync<List<slot>>().Result;


            foreach (var me in Well)
            {
               
                var appDate = Session["PickDate"].ToString();
                

                HttpResponseMessage appoint = client.GetAsync("Booking?bookingId="+ styleID + "&time="+me.A_TIME+"&date="+ appDate + "&robet="+1).Result;
                var details = appoint.Content.ReadAsAsync<Root>().Result;



                display += "<tr>";
                display += "<td><b>" + me.A_TIME + "</b></td>";

                if (details != null)
                {
                    display += "<td><div class='mb-2 mr-2 badge badge-danger'>Booked</div></td>";
                    display += "<td class='text-left'>";
                    display += "<a href='TimeSlot.aspx'>";
                    display += "<button type ='button' class='btn mr-2 mb-2 btn-primary'  data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal' disabled>Book Appointment</button>";
                    display += "</a>";
                    display += "</tr>";

                   
                }
                else if (details == null)
                {
                    display += "<td><div class='mb-2 mr-2 badge badge-success'>Available</div></td>";
                    display += "<td class='text-left'>";
                    display += "<a href='Appointments.aspx?Date="+ appDate +"&Time="+ me.A_TIME +"&Name="+ name +"&StylistID="+ styleID +"&image="+image + "'>";
                    display += "<button type ='button' class='btn mr-2 mb-2 btn-primary'  data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Book Appointment</button>";
                    display += "</a>";
                    display += "</tr>";
                   
                }
            }
            slot.InnerHtml = display;
        }
    }
}
