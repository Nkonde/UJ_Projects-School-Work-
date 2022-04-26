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
    public partial class stockhistory : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage response = client.GetAsync("StockOrders").Result;
            //var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/stock");
            var user = response.Content.ReadAsAsync<List<StockOrder>>().Result;
            string display = "";

            foreach (var r in user)
            {
                if (r.Status.Equals(0))
                {

                    display += " <div class='col-md-4'>";
                    display += " <div class='card-shadow-primary border mb-3 card card-body border-primary'><h5 class='card-title'>"+r.Name_+" "+r.OderDate+"</h5> Supplier Name:"+r.Supplier+"</br> total Stock Recieved:"+r.QTY+"</br> Total Price: R"+(r.Price_*r.QTY)+"</div>     ";
                    display += " </div>";

                }

            }

            history.InnerHtml = display;
        }
    }
}