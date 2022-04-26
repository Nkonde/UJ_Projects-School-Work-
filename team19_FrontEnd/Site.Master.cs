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
    public partial class Site : System.Web.UI.MasterPage
    {
        private readonly HttpClient client = new HttpClient();
  
        protected void Page_Load(object sender, EventArgs e)
        {
            string cartIcon = "";
            string display = "";
          
            display += "<a href='UserLogin.aspx'>";
            display += "<i class='metismenu-icon pe-7s pe-7s-power'>logout</i>";
            display += "</a>";
            
            lg.InnerHtml = display;

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            

            var userID = Session["LoggedInUserID"].ToString();

            HttpResponseMessage cartNumber = client.GetAsync("CartItem?value1=1&value2=1&UserID=" + userID).Result;
            int count = cartNumber.Content.ReadAsAsync<int>().Result;

            cartIcon += "<span class='cart-basket d-flex align-items-center justify-content-center' id='lblCartCount'>" + count + "</span>";

            treport.InnerHtml = cartIcon;


            if (Session["LoggedInUserID"] != null)
            {
                int ID = Convert.ToInt32(Session["LoggedInUserID"]);
                HttpResponseMessage loggedInUser = client.GetAsync("Users?userId="+ ID).Result;
                if (loggedInUser.IsSuccessStatusCode)
                {
                    /* username.Text = loggedInUser.Username;
                     user.Visible = true;
                     logout.Visible = true;
                     started.Visible = false;*/

                   

                   
                    var userDetails = loggedInUser.Content.ReadAsAsync<Users>().Result;

                    string text = userDetails.Name;
                    string firstLetters = "";

                    foreach (var part in text.Split(' '))
                    {
                        firstLetters += part.Substring(0, 1);
                    }

                    string text1 = userDetails.Surname;
                    string firstLetters1 = "";

                    foreach (var part in text.Split(' '))
                    {
                        firstLetters += part.Substring(0, 1);
                    }


                    username.Text = firstLetters.ToUpper() + " " + firstLetters1.ToUpper();
                    title.Text = "";
                    if (userDetails.UserType.Equals("employee"))
                    {
                        completed.Visible = true;
                        newapp.Visible = false;
                        list.Visible = false;
                        history.Visible = false;
                      //  treport.Visible = false;
                        carticon.Visible = false;
                        style.Visible = false;
                        rep.Visible = false;
                    }
                    else if(userDetails.UserType.Equals("Client") || userDetails.UserType.Equals("client"))
                    {
                        completed.Visible = false;
                        newapp.Visible = true;
                        list.Visible = true;
                        history.Visible = true;
                        //  treport.Visible = true;
                        style.Visible = true;
                        rep.Visible = false;
                    }
                    else  
                    {
                        completed.Visible = false;
                        style.Visible = false;
                        rep.Visible = false;
                    }




                    HttpResponseMessage response = client.GetAsync("StockOrders").Result;
                    var item = response.Content.ReadAsAsync<List<StockOrder>>().Result;


                    int pendingStock = 0;

                    foreach (var r in item)
                    {
                        if (r.Status.Equals(1))
                        {
                            pendingStock += Convert.ToInt32(r.userNotif);

                        }

                    }



                    string display1 = "";
                    if (userDetails.UserType.Equals("admin"))
                    {
                        sidebar.Visible = true;
                        list.Visible = false;
                        history.Visible = false;
                       // stocktaking.Visible = true;
                        newapp.Visible = false;
                        carticon.Visible = false;
                        display1 += "<a href='notification.aspx?ID=" +1+ "'>";
                        display1 += "<button runat ='server' id='stocktaking' visible='false' type='button' onserverclick='search_Clicked' class='mb-2 mr-2 btn btn-primary'>Recieve Stock<span class='badge badge-pill badge-light'>"+pendingStock+ "</span></button>";
                        display1 += "</a>";
                    }
                    Li1.InnerHtml = display1;



                    if (userDetails.UserType.Equals("supplier"))
                    {

                        
                        list.Visible = false;
                        history.Visible = false;
                        newapp.Visible = false;
                    }
                }
            }

        }
    }
}