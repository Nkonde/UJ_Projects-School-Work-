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
    public partial class PickStylist : System.Web.UI.Page
    {

        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            string styleID = Request.QueryString["styleID"];
            string name = Request.QueryString["styleName"];
            string image = Request.QueryString["image"];

            

            String display = "";
            HttpResponseMessage assinged = client.GetAsync("Style?styleListID=" + styleID).Result;
            var Well = assinged.Content.ReadAsAsync<List<Assignn>>().Result;
            foreach (var book in Well)
            {
                HttpResponseMessage StylistStyle = client.GetAsync("Style?UserStylistID=" + book.UserID).Result;
                var temp = StylistStyle.Content.ReadAsAsync<Users>().Result;

                HttpResponseMessage rating = client.GetAsync("Rating?count=1&countt=1&stylistID=" + book.UserID).Result;
                var rate = rating.Content.ReadAsAsync<double?>().Result;

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
                display += "<div class='widget-heading'>" + temp.Name + "</div>";
                display += "</div> </div> </div>";
                display += "</td>";

                display += "<td class='text-center'>" + name + "</td>";

               // display += "<label for='5'>☆☆☆☆☆</label>";
                 display += "<td class='text-center'><button class='mb-2 mr-2 btn btn-warning'>☆☆☆☆☆<span class='badge badge-pill badge-light'>" + rate + "</span></button></td>";
              //  display += "<td class='text-center'>☆☆☆☆☆" + rate + "</td>";
                display += "</td>";

                //display += "<td class='text-center'>";
                //display += "<a href='DeleteItem.aspx?BookingID=" + book.BookingId + "'>";
                //display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Cancel</button>";
                //display += "</a>";

                display += "<td class='text-center'>";
                display += "<a href='TimeSlot.aspx?StylistID="+temp.Id+"&StylName="+ name +"&image="+image+"'>";
                display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>View Time</button>";
                display += "</a>";


                display += "</td>";
                display += "</tr>";
                display += "<tr>";
            }
            slot.InnerHtml = display;
        }
    }
}