using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TYPWebApplication
{
    public partial class Quality : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            // var email = Session["newQTY"].ToString();
            var UserID = Session["LoggedInUserID"];
            string name = Request.QueryString["QItem"];
            string itemID = Request.QueryString["itemID"]; 

            HttpResponseMessage respond = client.GetAsync("CartItem?quality="+ name + "&itemIdentity="+ itemID+ "&userCartId=" + UserID).Result;
            int count = respond.Content.ReadAsAsync<int>().Result;
            if (count == 1)
            {
                Response.Redirect("cart.aspx");
            }


       
        }
    }
}