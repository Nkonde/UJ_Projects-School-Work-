using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TYPWebApplication
{
    public partial class RemoveCart : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            string id = Request.QueryString["userID"];
        
            HttpResponseMessage respond = client.GetAsync("CartItem?ItemCartID="+ id).Result;
            Boolean count = respond.Content.ReadAsAsync<Boolean>().Result;
            Response.Redirect("Cart.aspx");
            if (count == true)
            {
                Response.Redirect("Cart.aspx");
            }
        }
    }
}