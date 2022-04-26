using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TYPWebApplication
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void Book_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            if (password.Value != Confirm.Value)
            {
                lblStatus.Text = "Password don't match please try again!!!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?name="+name.Value+"}&surname="+surname.Value+"&email="+email.Value+"&password="+password.Value+"&phonenumber="+phone.Value+"&gender="+gender.Value+"&address="+address.Value+"&usertype=client");
            var user = JsonConvert.DeserializeObject<int>(response);
            if (user == 1)
            {
                Response.Redirect("UserLogin.aspx");
                
                return;
            }else if(user== -1)
            {
                lblStatus.Text = "Error occured!!!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;

            }else if (user==0)
            {
                lblStatus.Text = "Account already exist!!!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }
    }
}