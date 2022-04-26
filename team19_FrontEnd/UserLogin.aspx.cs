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
    public partial class UserLogin : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginClicked(object sender, EventArgs e)
        {
            
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            
            HttpResponseMessage response = client.GetAsync("Users?email=" + email.Value + "&password=" + pass.Value).Result;
            HttpResponseMessage getUser = client.GetAsync("Users?email=" + email.Value).Result;

            if (response.IsSuccessStatusCode && getUser.IsSuccessStatusCode)
            {
                var user = response.Content.ReadAsAsync<int>().Result;
                var userDetails = getUser.Content.ReadAsAsync<Users>().Result;
                if(user == -1)
                {
                    return;
                }

                Session["LoggedInUserID"] = userDetails.Id;
                Session["UserType"] = userDetails.UserType;
                Session["UserCredentials"] = userDetails.Name + " " + userDetails.Surname;

                if (userDetails.UserType.Equals("employee"))
                {

                    Response.Redirect("appointment-page.aspx");

                    return;
                }
                else if(userDetails.UserType.Equals("admin"))
                {

                    Response.Redirect("adminDashboard.aspx");

                    return;
                }else if (userDetails.UserType.Equals("supplier"))
                {
                    Response.Redirect("supplier.aspx");
                }

                Response.Redirect("dashboard.aspx"); 
            }

        }
    }
}