using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class supplierconfirm : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            var eID = Request.QueryString["Id"];
            HttpResponseMessage response1 = client.GetAsync("StockOrders?SId="+eID+ "&status="+1+"&notify="+0+"&adminNoti="+1).Result;
            var edit = response1.Content.ReadAsAsync<int>().Result;
          
            if (edit == 1)
            {
                Response.Redirect("supplier.aspx");
            }
        }
    }
}