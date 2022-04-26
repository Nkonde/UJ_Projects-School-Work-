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
    public partial class Styleedit : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {


            var syleID = Request.QueryString["Id"];

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


            HttpResponseMessage response = client.GetAsync("Style/" + syleID).Result;
            var item = response.Content.ReadAsAsync<Packs>().Result;
        


            if (!IsPostBack)
            {
                name.Value = item.hairstyleName;
                price.Value = item.price_.ToString();
                description.Value = item.hairstyledescription_;

            }
        }

        protected void update_Clicked(object sender, EventArgs e)
        {


            string ext = System.IO.Path.GetExtension(FileUpload2.FileName);
            if (ext == ".jpg" || ext == ".jpeg")
            {
                string path = Server.MapPath("images//");
                FileUpload2.SaveAs(path + FileUpload2.FileName);

                var syleID = Request.QueryString["Id"];
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


                HttpResponseMessage response = client.GetAsync("Style/" + syleID).Result;
                var item = response.Content.ReadAsAsync<Packs>().Result;


                if (item != null)
                {
                    HttpResponseMessage response1 = client.GetAsync("Style?name=" + name.Value + "&price=" + price.Value + "&descrip=" + description.Value + "&tyope=" + type.Value + "&images=/images/" + FileUpload2.FileName + "&stat=1&userID=" + item.Id).Result;
                    var edit = response1.Content.ReadAsAsync<int>().Result;
                  

                    if (edit == 1)
                    {


                        Response.Redirect("Stylesmanager.aspx");
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