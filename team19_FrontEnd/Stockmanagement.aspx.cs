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
    public partial class Stockmanagement : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


            string display = "";
            HttpResponseMessage response = client.GetAsync("stock").Result;
            var user = response.Content.ReadAsAsync<List<Stock>>().Result;
        


            display += "<table class='table table-bordered table-striped table-condensed'>";
            display += "<thead>";
            display += "<tr>";

            display += "       <td><b>Name</b></td>";
            display += "       <td><b>Price</b></td>";
            display += "       <td><b>Stock Price</b></td>";
            display += "       <td><b>Storage Capacity</b></td>";
            display += "       <td><b>Description</b></td>";
            display += "       <td><b>Supplier</b></td>";
            display += "       <td><b>Image</b></td>";
            display += "       <td><b>Update</b></td>";
            display += "       <td><b>Delete</b></td>";


            display += "</tr>";
            display += "   </thead>";
            display += "   <tbody>";


            foreach (var r in user)
            {
                if (r.status.Equals(1))
                {

                    display += "<tr>";
                    display += $"       <td>{r.Name}</td>                   ";
                    display += $"       <td>R{r.Price}</td>                   ";
                    display += $"       <td>R{r.stockprice}</td>                   ";
                    display += $"       <td>R{r.maxAmountStock}</td>                   ";
                    display += $"       <td>{r.Description}</td>                   ";
                    display += $"       <td>{r.Supplier}</td>                   ";
                    display += $"<td><img src =" + r.Img + " alt = 'Bald Eagle' width='50' height='50' /></td>";
                    display += "<td>";
                    display += "<a href='Stockedit.aspx?Id=" + r.Id + "'>";
                    display += "<button type ='button' onserverclick='Clicked' data-toggle='modal'    class='mt-2 btn btn-primary'>Update</button>";
                    display += "</a>";
                    display += "</td>";

                    display += "<td>";
                    //
                    display += "<a href='DeleteStock.aspx?Id=" + r.Id + "'>";
                    display += "<button type ='button' onserverclick='Clicked' class='mt-2 btn btn-danger' >Delete</button>";
                    display += "</a>";
                    display += "</td>";
                    display += "</tr>";

                }


            }
            display += "</tbody>";
            display += "</table>";

            Active.InnerHtml = display;



            string display1 = "";
            HttpResponseMessage response5 = client.GetAsync("Users").Result;
            var check = response5.Content.ReadAsAsync<List<Users>>().Result;


            display1 += "<datalist id='cars'>";
          
            foreach (var r in check)
            {
                if (r.UserType.Equals("supplier"))
                {
                    display1 += "<option>" + r.Name + "</option>";
                }

            }
            display1 += "</datalist>";

            Section2.InnerHtml = display1;

        }

        protected  void addStock_Clicked(object sender, EventArgs e)
        {

            if (FileUpload2.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload2.FileName);
                if (ext == ".jpg" || ext == ".jpeg")
                {
                    string path = Server.MapPath("images//");
                    FileUpload2.SaveAs(path + FileUpload2.FileName);

                    HttpClient client = new HttpClient();

                    client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


                  
                    HttpResponseMessage response = client.GetAsync("stock?name=" + name.Value + "&description=" + description.Value + "&price=" + price.Value + "&supplier=" + supp.Value + "&avaiblestock=" + AvailableStock.Value + "&soldstock=" + 0 + "&onspecial=" + input.Value + "&image=/images/" + FileUpload2.FileName + "&Status=" + 1 + "&capacity=" + Storage.Value + "&stockPrice=" + StockPrice.Value).Result;
                    var item = response.Content.ReadAsAsync<int>().Result;

       

                    if (item == 1)
                    {
                        Response.Redirect("stockmanagement.aspx");
                    }
                }
                else
                {
                    error.Attributes.Add("style", "color:red;");
                    error.Text = "You can only upload jpeg or jpg file";
                    error.Visible = true;
                }
            }
            else
            {
                error.Attributes.Add("style", "color:red;");
                error.Text = "No file Selected";
                error.Visible = true;
            }



        }
    }
}