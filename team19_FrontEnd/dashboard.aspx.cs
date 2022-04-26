using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class dashboard : System.Web.UI.Page
    {
        HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var id= await ((Task<Int64>)HttpContext.Session["LoggedInUserId"])

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            var UserID = Session["LoggedInUserID"];
       
            HttpResponseMessage respond = client.GetAsync("Style").Result;
            var userstyle = respond.Content.ReadAsAsync<List<SalonStyle>>().Result;

            HttpResponseMessage SalonItems = client.GetAsync("Stock").Result;
            var ItemInfo = SalonItems.Content.ReadAsAsync<List<Stock>>().Result;


           
            string display = "";
            string displayStock = "";

            foreach (var x in userstyle)
            {
                //var item = await client.GetStringAsync("https://typapi.azurewebsites.net/api/SalonItems?itemId="+x.Id);
                //var itemDetails = JsonConvert.DeserializeObject<List<SalonStyle>>(item);
                //itemDetails.

                if (x.status.Equals(1)) { 

                    // display += "<div class='row'>";
                    display += "<div class='col-md-4 col-lg-4 mt-2'>";
                display += "<div class='p-4 bg-white rounded'>";
                display += " <div class='d-flex flex-column'>";

                display += "<div class='d-flex flex-row justify-content-between align-items-center mb-2'><span class='item px-2 rounded'>Available</span>";
                display += "<div><i class='fa fa-heart-o ml-2'></i></div>";
                display += "</div>";

                display += "<div class='mb-2 p-image'>";
                display += "<a href ='Appointments.aspx?name=" + x.hairstyleName + "'>";
                display += "<img class='img-fluid img-responsive  width='150' height='150' rounded' src=" + x.img + " height='250'>";
                display += "</a>";
                display += "</div>";
                display += "<div class='text-center'><span class='p-name'>" + x.hairstyleName + "</span></div>";
                display += "<div class='d-flex flex-row justify-content-between align-items-center mt-4'>";

                display += "<div class='buttons'>";
                display += "<div class='btn-group btn-group-sm' role='group'><button class='btn btn-outline-primary text-dark border-dark price' type='button'>R" + x.price_ + "</button></div>";
                display += "</div>";
                display += "</div>";

                display += "<a href='PickStylist.aspx?styleName=" + x.hairstyleName + "&image=" + x.img + "&styleID=" + x.Id + "'>";
                display += "<button type ='button' class='btn mr-2 mb-2 btn-primary' data-toggle='modal' onserverclick='Clicked' data-target='#exampleModal'>Book Appointment</button>";
                display += "</a>";

                // display += "<button class='mt-2 btn btn-primary' type='submit' formaction='Appointments.aspx?styleName='" + x.hairstyleName + " runat='server'>Book Appointment</button>";
                display += "</div> </div> </div>";
            }
                

            }
            display += "<div class='container-fluid mt-5 mb-5'>";
            display += "<div class='p-2 bg-white px-4 rounded'>";
            display += "<div class='d-flex flex-row justify-content-between align-items-center'>";
            display += "<div class='d-flex flex-row align-items-center filters'>";

            display += "<span class='ml-2'>All types</span><i class='fa fa-angle-down ml-1'></i></div>";
            display += "<div class='d-flex flex-row align-items-center filters mt-2'>";
            display += "<div class='sub-cat' style='border-bottom: 2px solid blue;'>";
            display += "<h3>Product Available now</h3>";
            display += "</div></div>";
            display += "<div class='d-flex flex-row align-items-center filters'>";
            display += "<div class='d-flex flex-row align-items-center'>";
            display += "<span class='ml-2'>our price</span><i class='fa fa-angle-down ml-1'></i></div>";
            display += "</div> </div> </div>";




            foreach (var x in ItemInfo)
            {
                if (x.status.Equals(1))
                {
                    // display += "<div class='row'>";
                    displayStock += "<div class='col-md-4 col-lg-4 mt-2'>";
                    displayStock += "<div class='p-4 bg-white rounded'>";
                    displayStock += "<div class='d-flex flex-column'>";

                    displayStock += "<div><i class='fa fa-heart-o ml-2'></i></div>";
                    displayStock += "</div>";
                    displayStock += "<div class='mb-2 p-image'>";
                    displayStock += "<a href = 'Appointments.aspx'>";
                    displayStock += "<img class='img-fluid img-responsive rounded'  src=" + x.Img + " height='200'>";
                    displayStock += "</a>";
                    displayStock += "</div>";
                    displayStock += "<div class='text-center'><span class='p-name'>" + x.Name + "</span></div>";
                    displayStock += "<div class='d-flex flex-row justify-content-between align-items-center mt-4'>";

                    displayStock += "<div class='buttons'>";
                    displayStock += "<div class='btn-group btn-group-sm' role='group'><button class='btn btn-outline-primary text-dark border-dark price' type='button'>R" + x.Price + "</button>";
                    displayStock += "</button>";

                    displayStock += "</div>";
                    displayStock += "</div>";
                    displayStock += "</div>";
                    displayStock += "<div class='col'>";
                    displayStock += "<button class='mt-2 btn btn-primary' type='submit' formaction='AddToCart.aspx?itemId=" + x.Id + "' runat='server'>ADD TO CART</button>";
                    displayStock += "</div>";
                    displayStock += "<div class='col'>";
                    displayStock += "<button class='mt-2 btn btn-primary' type='submit' formaction='Checkout.aspx?Price="+ x.Price + "' runat='server'>Purchase</button>";
                    displayStock += "</div>";
                    displayStock += "</div>";
                    displayStock += "</div>";
                }
                }
               // display += "</div>";
            
            treport.InnerHtml = display;
            stock.InnerHtml = displayStock;
        }
    }
}