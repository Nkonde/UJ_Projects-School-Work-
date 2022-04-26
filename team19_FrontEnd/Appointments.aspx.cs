using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class Appointments : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            string image = Request.QueryString["image"];

            string date = Request.QueryString["Date"];
            string time = Request.QueryString["Time"];
            string name = Request.QueryString["Name"];
             string styleID= Request.QueryString["StylistID"]; 

            fname.Value = name;
            fdate.Value = date;
            ftime.Value = time;
            

            string display = "";
            display += "<img src='" + image + "' alt='' />";
            Section1.InnerHtml = display;

          

            //String Pickdisplay = "";
            //HttpResponseMessage assinged = client.GetAsync("Style?styleListID="+ styleID).Result;
            //var Well = assinged.Content.ReadAsAsync<List<Assignn>>().Result;

            //Pickdisplay += "<datalist id='zoo'>";
            //foreach (var x in Well)
            //{
               
               HttpResponseMessage StylistStyle = client.GetAsync("Style?UserStylistID="+ styleID).Result;
               var temp = StylistStyle.Content.ReadAsAsync<Users>().Result;
            stylist.Value = temp.Name;

            //    Pickdisplay += "<option>" + temp.Name+ "</option>";               


            //}
            //Pickdisplay += "</datalist>";

            //Section2.InnerHtml = Pickdisplay;

            //if()
        }

        protected   void Book_Clicked(object sender, EventArgs e)
        {
          //  client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            var UserID = Convert.ToInt32(Session["LoggedInUserID"]);

            string date = Request.QueryString["Date"];
            string time = Request.QueryString["Time"];
            string name = Request.QueryString["Name"];
            string styleID = Request.QueryString["StylistID"];

            HttpResponseMessage spec = client.GetAsync("Style?UserStylistName="+ stylist.Value).Result;
            var info = spec.Content.ReadAsAsync<Users>().Result;

            HttpResponseMessage respond = client.GetAsync("Booking?service="+name+"&date="+ date + "&time="+time+"&status="+"Waiting"+"&userId="+UserID+ "&stylistID="+ styleID).Result;
            var count = respond.Content.ReadAsAsync<int>().Result;

            

            if (count == -1)
            {
                lblStatus.Text = "Error occured while booking the client";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;

            }
            else if
                (count == 0)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "This time slot has already been occupied";
                return;
            }else if (count == 8)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Sorry we don't work on weekends";
                return;
            }
            else if (count == 11)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Sorry your out of the Office time range";
                return;
            }

            lblStatus.Text = "Your booking has been Success";
            lblStatus.ForeColor = System.Drawing.Color.Green;

           
            }

        }
    
}