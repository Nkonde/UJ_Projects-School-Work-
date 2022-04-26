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
  
    public partial class supplier : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";


            
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage response = client.GetAsync("StockOrders").Result;
            var item = response.Content.ReadAsAsync<List<StockOrder>>().Result;


            int pendingOrders = 0;
            
            foreach (var r in item)
            {
                if (r.Status.Equals(1))
                {
                    pendingOrders += Convert.ToInt32(r.notification);
                 
                }

            }






            foreach (var r in item)
            {

                if (r.notification.Equals(1))
                {
                    display += "<div class='col-md-4'>";
                    display += "<div class='mb-3 card card-body'><h5 class='card-title'>Order Request</h5>";
                    display += " <small class='text-muted'>" + r.OderDate + "</small>";
                    display += "<br/>";
                    display += "<p class='list-group-item-text'>Item Name: " + r.Name_+ "</p>";
                    display += "<p class='list-group-item-text'>Total Items:+ "+r.QTY+"</p>";
                    display += "<p class='list-group-item-text'>Total Price: R" + (r.Price_*r.QTY) + "</p>";
                    display += "<br/>";
                    display += "<a href='supplierconfirm.aspx?Id=" + r.Id + "'>";
                    display += "<button type ='button' onserverclick='Clicked' class='btn btn-primary'>Confirm Order</button>";
                    display += "</a>";
                    display += "</div>";
                    display += "</div>";

                }
               


            }


            string display1 = "";
            display1 = " <button class='mb - 2 mr - 2 btn btn-link'>Pending Orders<span class='badge badge-pill badge-primary'>"+pendingOrders+"</span></button>";






            checl.InnerHtml = display1;
            orders.InnerHtml = display;
        }
    }
}