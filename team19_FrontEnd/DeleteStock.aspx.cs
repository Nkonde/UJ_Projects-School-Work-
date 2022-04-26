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
    public partial class DeleteStock : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected  void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            var syleID = Request.QueryString["Id"];


            HttpResponseMessage response = client.GetAsync("Stock/"+syleID).Result;
            var item = response.Content.ReadAsAsync<Stock>().Result;

            HttpResponseMessage response1 = client.GetAsync("stock?SId=" + item.Id + "&status=0&name=" + item.Name).Result;
            var edit = response1.Content.ReadAsAsync<int>().Result;
         
            if (edit == 1)
            {
                Response.Redirect("Stockmanagement.aspx");
            }
        }
    }
}