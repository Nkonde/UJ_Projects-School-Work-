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
    public partial class appointment_page : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        private readonly Uri uri = new Uri("https://typapi.azurewebsites.net/api/");

        protected  void Page_Load(object sender, EventArgs e)
        {

            client.BaseAddress = uri;

            HttpResponseMessage countBooking = client.GetAsync("Booking?count=6&countt=6").Result;
            if (countBooking.IsSuccessStatusCode)
            {
                var booking = countBooking.Content.ReadAsAsync<int>().Result;
                TotalBooking.InnerHtml = String.Format("Total Number of Bookings: " + booking);
            }

            HttpResponseMessage getCompleted = client.GetAsync("Booking?status=Completed").Result;
            if (getCompleted.IsSuccessStatusCode)
            {
                var countCompleted = getCompleted.Content.ReadAsAsync<int>().Result;
                completed.InnerHtml = String.Format("<div class='widget - numbers text - white'><span>" + countCompleted + "</span></div>");
            }

            HttpResponseMessage getInProgress = client.GetAsync("Booking?status=InProgress").Result;
            if (getInProgress.IsSuccessStatusCode)
            {
                var countProgress = getInProgress.Content.ReadAsAsync<int>().Result;
                inprogess.InnerHtml = String.Format("<div class='widget - numbers text - white'><span>" + countProgress + "</span></div>");

            }

            HttpResponseMessage getWaiting = client.GetAsync("Booking?status=Waiting").Result;
            if (getWaiting.IsSuccessStatusCode)
            {
                var countWaiting = getWaiting.Content.ReadAsAsync<int>().Result;

                inwaiting.InnerHtml = String.Format("<div class='widget - numbers text - white'><span>" + countWaiting + "</span></div>");
            }

            QueryString();


            HttpResponseMessage response = client.GetAsync("https://typapi.azurewebsites.net/api/Booking").Result;
            if (response.IsSuccessStatusCode)
            {
                var user = response.Content.ReadAsAsync<List<Class1>>().Result;

                string display = "";



                foreach (var u in user)
                {
                    HttpResponseMessage getUser = client.GetAsync("https://typapi.azurewebsites.net/api/Users?userId=" + u.Id).Result;
                    if (getUser.IsSuccessStatusCode)
                    {
                        var UserInfo = getUser.Content.ReadAsAsync<Users>().Result;

                    // foreach (var v in UserInfo)
                    // {
                    display += "<tr>";
                    display += "<td class='text-center text-muted'>#" + u.Id + "</td>";
                    display += "<td>";
                    display += "<div class='widget-content p-0'>";
                    display += "<div class='widget-content-wrapper'>";
                    display += "<div class='widget-content-left mr-3'>";


                        //< div class="col-md-2">
                        //                                <div class="font-icon-wrapper"><i class="pe-7s-users"> </i>
                        //                                    <p>pe-7s-users</p></div>
                        //                            </div>
                    display += "<div class='col-md-2'>";
                    display += "<div class='font-icon-wrapper'><i class='pe-7s-users'></i></div>";
                       // display += "</div>";
                        display += "</div>";
                    display += "</div>";
                    display += "<div class='widget-content-left flex2'>";
                    display += "<div class='widget-heading'>" + UserInfo.Name + "</div>";
                    display += "<div class='widget-subheading opacity-7'>" + u.Date + "</div>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    display += "</td>";
                    display += "<td class='text-center'>" + u.Service + "</td>";
                    display += "<td class='text-center'>";
                    display += "<div class='badge badge-warning'>" + u.Status + "</div>";
                    display += "</td>";
                    display += "<td class='text-center'>";

                    display += "<a class='btn btn-sm btn-danger' href='appointment-page.aspx?status=" + u.Status + "&bookingId=" + u.BookingId + "'>Update";
                        
                        display += "</a>"; 
                        
                  

                    display += "</td>";
                    display += "</tr>";

                    }
                }
                listClients.InnerHtml = display;

                
            }  
        }

        public void QueryString()
        {
            string QueryStatus = Request.QueryString["status"];
            int QueryBookingId = Convert.ToInt32(Request.QueryString["bookingId"]);
            string display = "";
            switch (QueryStatus)
            {
                case "Completed":
                    display += "<button type = 'button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' data-target='.bd-example-modal-sm'>Small modal</button>";
                    QueryString();
                   
                    break;

                case "InProgress":
                    {
                       

                        HttpResponseMessage countBooking = client.GetAsync("Booking?status=Completed&bookingId=" + QueryBookingId).Result;
                        if (countBooking.IsSuccessStatusCode)
                        {
                            var booking = countBooking.Content.ReadAsAsync<int>().Result;
                          }
                    }
                    break;

                case "Waiting":
                    {
                        HttpResponseMessage countBooking = client.GetAsync("Booking?status=InProgress&bookingId=" + QueryBookingId).Result;
                        if (countBooking.IsSuccessStatusCode)
                        {
                            var booking = countBooking.Content.ReadAsAsync<int>().Result;
                        }
                    }
                    break;
            }
        }
    }
}