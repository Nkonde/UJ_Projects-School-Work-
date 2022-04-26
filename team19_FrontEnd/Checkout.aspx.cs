using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TYPWebApplication
{
    public partial class Checkout : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            string display = "";
=======
            client.BaseAddress = new Uri("https://localhost:44301/api/");
           // string display = "";
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);
            decimal CartTotal = Convert.ToDecimal(Session["CartTotalAmount"]);

            // double total=Convert.ToDouble(Request.QueryString["Price"]);
            service.Value =Convert.ToString( CartTotal);
            //display += "<a>";
            //display += "<input  href='Checkout.aspx? class='btn btn-success px - 3'>R" + CartTotal + "</input>";
            //display += "</a>";
           // QueryString();

<<<<<<< HEAD
            display += "<a>";
            display += "<button onclick='QueryString()' href='Checkout.aspx? class='btn btn-success px - 3'>R" + CartTotal + "</button>";
            display += "</a>";
            QueryString();

            Section1.InnerHtml = display;
=======
           // Section1.InnerHtml = display;
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
        }
        protected void Purchase(object sender, EventArgs e)
        {
            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);
            HttpResponseMessage cartNumber = client.GetAsync("CartItem?well=1&tell=1&userID=" + UserID).Result;
            bool count = cartNumber.Content.ReadAsAsync<Boolean>().Result;
            service.Value = Convert.ToString(0);
        }

    }
}