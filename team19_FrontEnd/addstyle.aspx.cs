using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TYPWebApplication
{
    public partial class addstyle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void addStyle_Clicked(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (ext == ".png" || ext == ".jpeg")
                {
                    string path = Server.MapPath("images//");
                    FileUpload1.SaveAs(path + FileUpload1.FileName);

                    HttpClient client = new HttpClient();
                    var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Style?name=" + name.Value + "&price=" + price.Value + "&descrip=" + descrip.Value + "&tyope=" + type.Value + "&images=/images/" + FileUpload1.FileName + "&stat=" + 1);
                    var user = JsonConvert.DeserializeObject<int>(response);
                    if (user == 1)
                    {
                        error.Attributes.Add("style", "color:green;");
                        error.Text = "Package Added.";
                        error.Visible = true;
                    }
                }
                else
                {
                    error.Attributes.Add("style", "color:red;");
                    error.Text = "You can only upload jpeg file";
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