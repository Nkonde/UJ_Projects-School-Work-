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
    public partial class AppointmentList : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
       // https://typapi.azurewebsites.net/api/Booking?bookingId=35

        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);

            HttpResponseMessage respond = client.GetAsync("Booking?bookingId="+ UserID + "&ClientBooking=" + 1).Result;
            var count = respond.Content.ReadAsAsync<List<Root>>().Result;

           string display = "";
                foreach (var book in count)
                {

                    display += "<tr>";
                    display += "<td>";
                    display += "<div class='widget-content p-0'>";
                    display += "<div class='widget-content-wrapper'>";
                    display += "<div class='widget-content-left mr-3'>";
                    display += "<div class='widget-content-left'>";
                    display += "<img width = '40' class='rounded-circle' src='' alt=''>";
                    display += "</div>";
                    display += "</div>";
                    display += "<div class='widget-content-left flex2'>";
                    display += "<div class='widget-heading'>" + book.BookingId + "</div>";
                    display += "</div> </div> </div>";
                    display += "</td>";

                    display += "<td class='text-center'>" + book.Service + "</td>";
                    display += "<td class='text-center'>" + book.Date.ToString("d") + " /" + book.Time + "</td>";
                    display += "</td>";

                    display += "<td class='text-center'>";
                    display += "<a href='DeleteItem.aspx?BookingID=" + book.BookingId + "'>";
                    display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Cancel</button>";
                    display += "</a>";

                    display += "<td class='text-center'>";
                    display += "<a href='UpdateAppointment.aspx?BookingID=" + book.BookingId + "&name=" + book.Service + "'>";
                    display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Update</button>";
                    display += "</a>";


                    display += "</td>";
                    display += "</tr>";
                    display += "<tr>";
                }

                display += "</tr>";
                display += "</tbody>";
                display += "</table>";
                display += "</div>";
                treport.InnerHtml = display;
            }

           
        }
    }
