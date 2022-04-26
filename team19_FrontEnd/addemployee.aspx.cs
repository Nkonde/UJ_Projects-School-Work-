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
    public partial class addemployee : System.Web.UI.Page
    {
        protected  void Page_Load(object sender, EventArgs e)
        {
        }
        protected async void addEmpoyee_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?name=" + name.Value + "&surname=" + surname.Value + "&email=" + email.Value + "&password=" + password.Value + "&phone=" + phone.Value + "&adress=" + input.Value + "&usert=Employee&Status="+1);
            // var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?name={name}&surname={surname}&email={email}&password={password}&phonenumber={phonenumber}&address={address}&usertype={usertype}");

            var user = JsonConvert.DeserializeObject<int>(response);

            if (user == -1)
            {
                return;
            }

            Response.Redirect("addemployee.aspx");
        }
    }
}