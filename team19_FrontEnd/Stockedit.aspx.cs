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
    public partial class Stockedit : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var syleID = Request.QueryString["Id"];
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


            HttpResponseMessage response = client.GetAsync("Stock/" + syleID).Result;
            var item = response.Content.ReadAsAsync<Stock>().Result;

            if (!IsPostBack)
            {
                name.Value = item.Name;
                price.Value = item.Price.ToString();
                description.Value = item.Description;
                StockPrice.Value = item.stockprice.ToString();
                supplier.Value = item.Supplier;
                Storage.Value = item.maxAmountStock.ToString();
            }
        }
        protected  void updateS_Clicked(object sender, EventArgs e)
        {

            string ext = System.IO.Path.GetExtension(FileUpload2.FileName);
            if (ext == ".jpg" || ext == ".jpeg")
            {
                string path = Server.MapPath("images//");
                FileUpload2.SaveAs(path + FileUpload2.FileName);

                var syleID = Request.QueryString["Id"];
                HttpClient client = new HttpClient();

              
                client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
                HttpResponseMessage response = client.GetAsync("Stock/" + syleID).Result;
                var item = response.Content.ReadAsAsync<Stock>().Result;

                if (item != null)
                {
                    HttpResponseMessage response1 = client.GetAsync("stock?name=" + item.Name + "&descrip=" + item.Description + "&price=" + item.Price + "&Sprice=" + item.stockprice + "&images=/images/" + FileUpload2.FileName + "&supplier=" + item.Supplier + "&Storage=" + item.maxAmountStock + "&Special=" + item.onSpecial + "&userID=" + item.Id).Result;
                    var edit = response1.Content.ReadAsAsync<int>().Result;
                 
                    if (edit == 1)
                    {
                        Response.Redirect("stockmanagement.aspx");
                    }
                }

            }
            else
            {
                error.Attributes.Add("style", "color:red;");
                error.Text = "You can only upload jpeg or jpg file";
                error.Visible = true;
            }




        }
    }
}