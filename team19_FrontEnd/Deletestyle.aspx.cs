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
    public partial class Deletestyle : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected  void Page_Load(object sender, EventArgs e)
        {


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            var syleID = Request.QueryString["Id"];


            HttpResponseMessage response = client.GetAsync("Style/" + syleID).Result;
            var item = response.Content.ReadAsAsync<Packs>().Result;


            HttpResponseMessage response1 = client.GetAsync("Style?name=" + item.hairstyleName + "&price=" + item.price_ + "&descrip=" + item.hairstyledescription_ + "&tyope=" + item.hairsyleType + "&images=/images/&stat=" + 0 + "&userID=" + item.Id).Result;
            var edit = response1.Content.ReadAsAsync<int>().Result;
            

            if (edit == 1)
            {
                Response.Redirect("Stylesmanager.aspx");
            }
        }
    }
}