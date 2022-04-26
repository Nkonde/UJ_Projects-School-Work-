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
    public partial class completed_appointments : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage completed = client.GetAsync("Booking?complete=Completed").Result;
            if (completed.IsSuccessStatusCode)
            {
                var details = completed.Content.ReadAsAsync<List<Models.CC>>().Result;
                string display = "";
                foreach (var d in details)
                {
                    HttpResponseMessage user = client.GetAsync("Users?userId="+ d.Id).Result;
                    if (user.IsSuccessStatusCode)
                    {
                        var u = user.Content.ReadAsAsync<Users>().Result;
                        
                        display += "<tr>";
                        display += "<td class='text-center text-muted'>#" + d.BookingId + "</td>";
                        display += "<td>";
                        display += "<div class='widget-content p-0'>";
                        display += "<div class='widget-content-wrapper'>";
                        display += "<div class='widget-content-left mr-3'>";
                        display += "<div class='widget-content-left'>";
                        display += "<img width = '40' class='rounded-circle' src='assets/images/avatars/4.jpg' alt=''>";
                        display += "</div>";
                        display += "</div>";
                        display += "<div class='widget-content-left flex2'>";
                        display += "<div class='widget-heading'>" + u.Name + "</div>";
                        //display += "<div class='widget-subheading opacity-7'>" + d.Date + "</div>";
                        display += "</div>";
                        display += "</div>";
                        display += "</div>";
                        display += "</td>";
                        display += "<td class='text-center'>" + d.Service + "</td>";
                        display += "<td class='text-center'>" + d.Date.ToShortDateString() + "</td>";
                        display += "<td class='text-center'>";
                        display += "<div class='badge badge-warning'>" + d.Time + "</div>";
                        display += "</td>";
                        display += "<td class='text-center'>";

                        //display += "<a class='btn btn-sm btn-danger' href='appointment-page.aspx?status=" + u.Status + "&bookingId=" + u.BookingId + "'>Update";
                        ////display += "<button type = 'button' id='PopoverCustomT-1' class='btn btn-primary btn-sm'>Update</button>";
                        //display += "</a>";

                        display += "</td>";
                        display += "</tr>";
                    }
                }
                reportCo.InnerHtml = display;
            }
        }
    }
}