using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            string display = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            var stockID = Request.QueryString["Id"];
            HttpResponseMessage response = client.GetAsync("stock/" + stockID).Result;
            var list = response.Content.ReadAsAsync<Stock>().Result;


            HttpResponseMessage response1 = client.GetAsync("StockOrders/").Result;
            var btn = response1.Content.ReadAsAsync<List<StockOrder>>().Result;
      
            btnPlaceOder.Visible = true;


            if (list != null)
            {
                display += "<li class='nav-item'><a disabled= '' href='javascript:void(0);' class='nav-link disabled'>" + list.Supplier + "</a></li>";
                display += "<li class='nav-item'><a disabled= '' href='javascript:void(0);' class='nav-link disabled'>" + list.Name + "</a></li>";
                display += "<li class='nav-item'><a disabled= '' href='javascript:void(0);' class='nav-link disabled'>R" + list.Price + "</a></li>";

                int QTY = 0;
                QTY = list.maxAmountStock - list.AvaibleStock;
                display += "<li class='nav-item'><a disabled= '' href='javascript:void(0);' class='nav-link disabled'>+" + QTY + "</a></li>";

                double total = 0;
                total = QTY * list.stockprice;
                display += "<li class='nav-item'><a disabled= '' href='javascript:void(0);' class='nav-link disabled'>R" + total + "</a></li>";
            }
            invoice.InnerHtml = display;

        }

        protected  void StockOrder_Clicked(object sender, EventArgs e)
        {
          


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            var stockID = Request.QueryString["Id"];
            HttpResponseMessage response = client.GetAsync("stock/" + stockID).Result;
            var list = response.Content.ReadAsAsync<Stock>().Result;

            
        


            int QTY = 0;
            QTY = list.maxAmountStock - list.AvaibleStock;

            HttpResponseMessage response1 = client.GetAsync("StockOrders?name="+list.Name+"&supplier="+list.Supplier+"&price="+list.Price+"&qty="+QTY+ "&status="+1+"&IDstock="+ stockID+ "&notify="+1+"&adminNoti="+0).Result;
            var user = response1.Content.ReadAsAsync<int>().Result;
           
            if (user == -1)
            {
                return;
            }

            try
            {
                var mailMessage = new MimeMessage();
                mailMessage.From.Add(new MailboxAddress("nailssaloon@", "nkondethabani@gmail.com"));
                mailMessage.To.Add(new MailboxAddress("thabani", "nkondethabani@gmail.com"));
                mailMessage.Subject = "Dear Supplier";
                mailMessage.Body = new TextPart("plain")
                {
                    Text = "Nails Soloon request order of  " + QTY + " of " + list.Name 


                };

                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("smtp.gmail.com", 465, true);
                    smtpClient.Authenticate("typnailssalon@gmail.com", "ovmcnihnlwditdzr");
                    smtpClient.Send(mailMessage);
                    smtpClient.Disconnect(true);
                }


            }
            catch (Exception)
            {

            }

            error.Attributes.Add("style", "color:green;");
            error.Text = "You have succefully orderd " + QTY + " of " + list.Name + " from supplier " + list.Supplier;
            error.Visible = true;

           
        }
    }
}