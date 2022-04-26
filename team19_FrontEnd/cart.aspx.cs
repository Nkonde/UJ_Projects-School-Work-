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
    public partial class cart : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected  void Page_Load(object sender, EventArgs e)
        {
     
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            var UserID = Session["LoggedInUserID"];

            //https://typapi.azurewebsites.net/api/CartItem?userID=35&ItemID=1

            HttpResponseMessage respond = client.GetAsync("CartItem?cartUserID=" + UserID).Result;
            var itemInfo = respond.Content.ReadAsAsync<List<CartItem>>().Result;
          
            String display = "";
            string dsiplayButton = "";
            double Amount=0;
            double total;
            foreach (var x in itemInfo)
            {
                HttpResponseMessage item = client.GetAsync("CartItem?itemID=" + x.Item_ID).Result;
                var Info = item.Content.ReadAsAsync<Items>().Result;




                display += "<div class='row d-flex justify-content-center border-top'>";
                display += "<div class='col-5'>";
                display += "<div class='row d-flex'>";
                display += "<div class='book'> <img src = '" + Info.Img + "' class='book-img'> </div>";
                display += "<div class='my-auto flex-column d-flex pad-left'>";
                display += "<h6 class='mob-text'>" + Info.Name + "</h6>";
                display += "<p class='mob -text'>Daniel Kahneman</p>";
                display += "</div> </div> </div>";

                display += "<div class='my -auto col-7'>";
                display += "<div class='row text-right'>";
                display += "<div class='col -4'>";
                display += "<p class='mob -text'>R" + Info.Price + "</p>";
                display += "</div>";

                display += "<div class='col-4'>";
                display += "<div class='row d-flex justify-content-end px-3'>";


                display += "<input type='text' id='itemquantity" + Info.Id + "' placeholder='' value=" + x.ItemQuality + " name='qty' runat='server' maxlength='4' size='4'>";

                display += "<a class='mt-2 btn btn-primary' style='color:white' id='btnid" + Info.Id + "' onclick='sendQuant" + Info.Id + "()' type='submit' >Update</a>";

                display += "<script type='text/javascript'>";
                display += "function sendQuant" + Info.Id + "(){";
                display += "var quant = document.getElementById('itemquantity" + Info.Id + "').value;";
                display += "document.getElementById('btnid" + Info.Id + "').href='Quality.aspx?QItem='+quant+ '&itemID=" + Info.Id + "'; ";
                display += "}";
                display += "</script>";

                display += "<div class='col'>";
                display += "<a class='mt-2 btn btn-primary' id='' href='RemoveCart.aspx?userID=" + Info.Id + "' style='color:white' type='submit' >Remove</a>";
                display += "</div>";
                //display += "<a href='DeleteCartItem.aspx?userID="+x.U_ID+ "'>";
                //display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Remove</button>";
                //display += "</a>";
                total = Info.Price * x.ItemQuality;

                display += "</div>";
                display += "</div>";
                display += "<div class='col-4'>";
                // display += "<input type='text' value='"+ total + "' readonly>";
                display += "<h6 class='mob-text' readonly>R" + total + "</h6>";
                display += "</div></div></div></div>";

                Amount = Amount + total;
                //x.C_Amount = Amount;
                Session["CartTotalAmount"] = Amount;

                amount.Value = Convert.ToString("R" + Amount);
            }

            dsiplayButton += "<div class='form-row'>";
            dsiplayButton += "<div class='container-login100-form-btn'>";
            dsiplayButton += "<a class='mt-2 btn btn-primary' type='submit' href='Checkout.aspx?'  runat='server'> Checkout </a>";
            dsiplayButton += "<asp:Label ID='lblStatus' runat='server'></asp:Label>";
            dsiplayButton += "</div></div>";

            treport.InnerHtml = display;
            Section1.InnerHtml = dsiplayButton;


        }
    }
 }