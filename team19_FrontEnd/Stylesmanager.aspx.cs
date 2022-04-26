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
    public partial class Stylesmanager : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
         

            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            string display = "";
           
            HttpResponseMessage response = client.GetAsync("Style").Result;
            var user = response.Content.ReadAsAsync<List<Packs>>().Result;
           
            display += "<table class='table table-bordered table-striped table-condensed'>";
            display += "<thead>";
            display += "<tr>";


            //Entry row

            display += "       <td><b>Name</b></td>";
            display += "       <td><b>Price</b></td>";
            display += "       <td><b>Description</b></td>";
            display += "       <td><b>Type</b></td>";
            display += "       <td><b>Images</b></td>";
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
                    display += $"       <td>{r.hairstyleName}</td>                   ";
                    display += $"       <td>R{r.price_}</td>                   ";
                    display += $"       <td>{r.hairstyledescription_}</td>                   ";
                    display += $"       <td>{r.hairsyleType}</td>                   ";
                    display += $"<td><img src =" + r.img + " alt = 'Bald Eagle' width='50' height='50' /></td>";
                    display += "<td>";
                    display += "<a href='Styleedit.aspx?Id=" + r.Id + "'>";
                    display += "<button type ='button' onserverclick='Clicked' data-toggle='modal' data-target ='#exampleModal'   class='mt-2 btn btn-primary'>Update</button>";
                    display += "</a>";
                    display += "</td>";




                    display += "<td>";
                    display += "<a href='Deletestyle.aspx?Id=" + r.Id + "'>";
                    display += "<button type ='button' onserverclick='Clicked' class='mt-2 btn btn-danger' >Delete</button>";
                    display += "</a>";
                    display += "</td>";
                    display += "</tr>";

                }


            }
            display += "</tbody>";
            display += "</table>";

            Active.InnerHtml = display;
        }
        protected  void addStyle_Clicked(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (ext == ".jpg" || ext == ".jpeg")
                {
                    string path = Server.MapPath("images//");
                    FileUpload1.SaveAs(path + FileUpload1.FileName);

                    HttpClient client = new HttpClient();
                    
                    client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

                 
                    HttpResponseMessage response = client.GetAsync("Style?name=" + name.Value + "&price=" + price.Value + "&descrip=" + descrip.Value + "&tyope=" + type.Value + "&images=/images/" + FileUpload1.FileName + "&stat=" + 1).Result;
                    var user = response.Content.ReadAsAsync<int>().Result;
                    if (user == 1)
                    {
                        Response.Redirect("Stylesmanager.aspx");
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