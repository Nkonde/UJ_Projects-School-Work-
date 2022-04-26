using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class notification : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();

            string Display = "";

            client.BaseAddress = new Uri("https://localhost:44301/api/");


            HttpResponseMessage response = client.GetAsync("StockOrders").Result;
            var btn = response.Content.ReadAsAsync<List<StockOrder>>().Result;




            // 
            foreach (var r in btn)
            {
                HttpResponseMessage response1 = client.GetAsync("stock/" + r.stockID).Result;
                var stock = response1.Content.ReadAsAsync<Stock>().Result;




                if (r.Status.Equals(1) && r.userNotif.Equals(1))
                {


                    Display += "<li class='list-group-item'>";
                    Display += "<div class='mb-2 mr-2 badge badge-dark'>Order Date: " + r.OderDate + "</div>";
                    Display += "<br>";
                    Display += "<br>";
                    Display += $"<img src =" + stock.Img + " alt = 'Bald Eagle' width='150' height='150' />";
                    Display += "<p class='list-group-item-text'>Item Name: " + stock.Name + "</p>";
                    Display += "<p class='list-group-item-text'>Description</p>";
                    Display += "<small class='form-text text-muted'>" + stock.Description + "</small>";
                    Display += "<br>";
                    //Display += "<li class='nav-item'><a href = 'javascript:void(0);' class='nav-link disabled'>Total Stock Recieved:";
                    Display += "<p class='list-group-item-text'>Total Stock Recieved</p>";
                    Display += "<div class='ml-auto badge badge-success'>+" + r.QTY + "</div>";
                    // Display += "</li>";
                    Display += "<br>";
                    Display += "<br>";
                    //Display += "<a href='confirmnewstock.aspx?Id="+r.Id+ "'>";
                    //Display += "<button type='button' onserverclick='Clicked'  class='btn mr-2 mb-2 btn-primary' data-toggle='modal' data-target='.bd-example-modal-sm'>Recieve Stock</button>";
                    //Display += "<a>";
                    Display += "<a href='confirmnewstock.aspx?ID=" + r.Id +"'>";
                    Display += "<button type ='button' onserverclick='Clicked' class='mt-2 btn btn-primary'  onserverclick='addStyle_Clicked'>Recieve Stock</button>";
                    Display += "</a>";


                    Display += "</li>";

                    



                }


                notifications.InnerHtml = Display;

            }
        }
    }
}