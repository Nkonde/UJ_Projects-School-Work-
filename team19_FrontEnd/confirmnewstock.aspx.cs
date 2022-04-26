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
    public partial class confirmnewstock : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            HttpClient client = new HttpClient();

            var syleID = Request.QueryString["Id"];

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            HttpResponseMessage response2 = client.GetAsync("StockOrders/" + syleID).Result;
            var oders = response2.Content.ReadAsAsync<StockOrder>().Result;


            HttpResponseMessage response = client.GetAsync("stock/"+oders.stockID).Result;
            var stock = response.Content.ReadAsAsync<Stock>().Result;
           

             HttpResponseMessage response1 = client.GetAsync("stock?SId="+stock.Id+"&quantity="+stock.maxAmountStock).Result;
            var edit = response1.Content.ReadAsAsync<int>().Result;



            HttpResponseMessage response3 = client.GetAsync("StockOrders?SId=" + syleID + "&status=" + 0 + "&notify=" + 0 + "&adminNoti=" + 0).Result;
            var check = response3.Content.ReadAsAsync<int>().Result;

            Response.Redirect("adminDashboard.aspx");
        }
    }
}

