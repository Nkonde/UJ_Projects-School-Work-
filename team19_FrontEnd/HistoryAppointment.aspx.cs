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
    public partial class HistoryAppointment : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
      //  https://typapi.azurewebsites.net/api/Booking?zoo=1&zaa=1&bookingId=35
        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            string display = "";
            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);


            //int userID = Convert.ToInt32(Request.QueryString["UserID"]);
           // string name = Request.QueryString["styleName"];

            HttpResponseMessage respond = client.GetAsync("Booking?zoo=1&zaa=1&bookingId="+ UserID).Result;
            var count = respond.Content.ReadAsAsync<List<Root>>().Result;


                foreach (var book in count)
                {
                   
                   HttpResponseMessage stylist = client.GetAsync("Users?userId="+book.StylistID).Result;
                   var Info = stylist.Content.ReadAsAsync<Users>().Result;
                if (stylist.IsSuccessStatusCode)
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


                    display += "<td class='text-center'>" + Info.Name  + "</td>";
                    display += "<td class='text-center'>" + book.Service + "</td>";
                    display += "</td>";

                    display += "<td class='text-center'>";
                    display += "<a href='RateStylist.aspx?StylID=" +Info.Id +"&styleName="+book.Service+"'>";
                    display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Rate Stylist</button>";
                    display += "</a>";

                    //display += "<td class='text-center'>";
                    //display += " <span class='fa fa-star checked'></span>";
                    //display += " <span class='fa fa-star checked'></span>";
                    //display += " <span class='fa fa-star checked'></span>";
                    //display += "<span class='fa fa-star'></span>";
                    //display += "<span class='fa fa-star'></span>";
                    //display += "</a>";


                    display += "</td>";
                    display += "</tr>";
                    display += "<tr>";
                }
                }
            display += "</tr>";
            display += "</tbody>";
            display += "</table>";
            display += "</div>";

            treport.InnerHtml = display;
        }
           
        }
    }
