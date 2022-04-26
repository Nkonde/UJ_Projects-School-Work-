using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class assignStyleto : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        private string assignSt ="";
        protected void Page_Load(object sender, EventArgs e)
        {
            var userid = Request.QueryString["Id"];
            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


            HttpResponseMessage response5 = client.GetAsync("Style").Result;
            var check = response5.Content.ReadAsAsync<List<SalonStyle>>().Result;


            string display = "";
            //display += "<datalist id='cars'>";
            //foreach (var r in check)
            //{
            //    if (r.status.Equals(1))
            //    {
            //        display +="<option>"+r.hairstyleName+"</option>"; 
            //    }

            //}
            //display += "</datalist>";
            //Section2.InnerHtml = display;







            display += "<div class='divider'></div>";
            display += " <select class='mb-2 form-control-lg form-control'>";
            foreach (var r in check)
            {
                if (r.status.Equals(1))
                {
                    
                    display += "<option>" + r.hairstyleName + "</option>";
                    assignSt = r.hairstyleName;
                }

            }
            display += "  </select>";

            inputas.InnerHtml = display;

            //HttpResponseMessage response1 = client.GetAsync("Assign/"+userid + "ecx=" + 1).Result;
            //var we = response1.Content.ReadAsAsync<Assignn>().Result;


            //if (we.status.Equals(1))
            //{
            //  display += display += "<button disabled ='' class='mb-2 mr-2 btn btn-primary disabled'>Assign</button>";
            //}
        }
        protected void assign_Clicked(object sender, EventArgs e) {
            var userid = Request.QueryString["Id"];
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage res = client.GetAsync("Assign?styleName="+ assignSt).Result;
            var styleInfo = res.Content.ReadAsAsync<Items>().Result;


            HttpResponseMessage response = client.GetAsync("Assign?userID="+ userid + "&styleID="+ styleInfo.Id + "&state="+1).Result;
            var check = response.Content.ReadAsAsync<int>().Result;
            
              if (check == -1)
            {
                lblStatus.Text = "Error occured while booking the client";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (check == -3)
            {
                lblStatus.Text = "Already Assigned to this Style";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }
              
            
            Response.Redirect("employees.aspx");

        }

        
    }
}