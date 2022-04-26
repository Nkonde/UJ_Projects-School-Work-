using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TYPWebApplication
{
    public partial class AddToCart : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            int ItemID = Convert.ToInt32(Request.QueryString["itemId"]);
            var UserID = Session["LoggedInUserID"];

       
            HttpResponseMessage respond = client.GetAsync("CartItem?userID="+ UserID + "&ItemID=" +ItemID).Result;
            int count = respond.Content.ReadAsAsync<int>().Result;
            if (count == 1)
            {
                Response.Redirect("dashboard.aspx");
            }else if (count == -3)
            {
                Response.Redirect("dashboard.aspx");
            }

        }
    }
}