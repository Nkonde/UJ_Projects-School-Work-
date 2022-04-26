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
    public partial class RateStylist : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        Uri uri = new Uri("https://typapi.azurewebsites.net/api/");
        Users Info = null;

        protected void Page_Load(object sender, EventArgs e)
        {
           

            client.BaseAddress = uri;
           
            string display = "";
            
            var StylistID = Request.QueryString["StylID"];
            var styleName= Request.QueryString["styleName"];

            HttpResponseMessage stylist = client.GetAsync("Users?userId=" + StylistID).Result;
            Info = stylist.Content.ReadAsAsync<Users>().Result;

            display += "<h class='username'><b>Stylist Name: " + Info.Name +","+Info.Surname+ "</b></h><br>";
            display += "<h class='profession'><b>Phone Number : " + Info.Phonenumber + "</b></h><br>";

            display += "<h class='profession'><b>Style Name: " + styleName + "</b></h2>";
          
            display += "<h3 class='locationname'>";

            treport.InnerHtml = display;

           

        }

        protected void Rate_Stylist(object sender, EventArgs e)
        {
            // client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            // Style? rateNumber = 2 & StylistName = Zinhle
            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);
            var StylistID = Request.QueryString["StylID"];


            // var rate = star_1.Value;
            int starNo;
             if (star_1.Checked)
            {
                // Info.StylistRating =1;

                
                starNo = 1;
                HttpResponseMessage stylist = client.GetAsync("Rating?numberOfStart="+starNo+"&feedback="+ service.Value + "&UserId="+ UserID + "&stylistID="+ StylistID).Result;
                int rating = stylist.Content.ReadAsAsync<int>().Result;
              
                lblStatus.Text = "Thanks for using our system and Rating our Stylist";
                lblStatus.ForeColor = System.Drawing.Color.Green;

            }
            else if (star_4.Checked)
            {
                starNo = 2;
                HttpResponseMessage stylist = client.GetAsync("Rating?numberOfStart=" + starNo + "&feedback=" + service.Value + "&UserId=" + UserID + "&stylistID=" + StylistID).Result;
                int rating = stylist.Content.ReadAsAsync<int>().Result;

                lblStatus.Text = "Thanks for using our system and Rating our Stylist";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else if (star_3.Checked)
            {
                starNo = 3;
                HttpResponseMessage stylist = client.GetAsync("Rating?numberOfStart=" + starNo + "&feedback=" + service.Value + "&UserId=" + UserID + "&stylistID=" + StylistID).Result;
                int rating = stylist.Content.ReadAsAsync<int>().Result;

                lblStatus.Text = "Thanks for using our system and Rating our Stylist";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else if (star_2.Checked)
            {
                starNo = 4;
                HttpResponseMessage stylist = client.GetAsync("Rating?numberOfStart=" + starNo + "&feedback=" + service.Value + "&UserId=" + UserID + "&stylistID=" + StylistID).Result;
                int rating = stylist.Content.ReadAsAsync<int>().Result;

                lblStatus.Text = "Thanks for using our system and Rating our Stylist";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else if (star_5.Checked)
            {
                starNo = 5;
                HttpResponseMessage stylist = client.GetAsync("Rating?numberOfStart=" + starNo + "&feedback=" + service.Value + "&UserId=" + UserID + "&stylistID=" + StylistID).Result;
                int rating = stylist.Content.ReadAsAsync<int>().Result;

                lblStatus.Text = "Thanks for using our system and Rating our Stylist";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }



        }
    }
}