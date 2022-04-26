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
    
    public partial class employees : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");
            
            
            HttpResponseMessage response = client.GetAsync("Users").Result;
            var user = response.Content.ReadAsAsync<List<Users>>().Result;
            string display = "";
       




            display += "<table class='table table-bordered table-striped table-condensed'>";
            display += "<thead>";
            display += "<tr>";


            display += "       <td> Name</td>";
            display += "       <td> Eamil</td>";
            display += "       <td> Status</td>";
            display += "       <td> Occupation</td>";
            display += "       <td> Assign Style</td>";
            display += "</tr>";
            display += "   </thead>";
            display += "   <tbody>";


            foreach (var r in user)
            {
                if (r.UserType.Equals("employee")||r.UserType.Equals("supplier"))
                {
                    display += "<tr>";
                    display += $"       <td>{r.Name}</td>                   ";
                    display += $"       <td>{r.Email}</td>                   ";
                    if (r.status.Equals("1"))
                    {
                        display += $"       <td><div class='mb-2 mr-2 badge badge-success'>Active</div></td>           ";

                    }
                    else if (r.status.Equals("0"))
                    {

                        display += $"       <td><div class='mb-2 mr-2 badge badge-danger'>Deactivated</div></td>           ";
                    }
                    display += $"       <td>{r.UserType}</td>                   ";

                  

                    display += "<td>";
                    if (r.status.Equals("1"))
                    {
                        display += "<a href='assignStyleto.aspx?Id=" + r.Id + "'>";
                        display += "<button type ='button' onserverclick='Clicked' data-toggle='modal' data-target ='#exampleModal'   class='mt-2 btn btn-primary'>Assign</button>";
                        display += "</a>";
                    }else if (r.status.Equals("0"))
                    {
                        display += "<button disabled ='' class='mb-2 mr-2 btn btn-primary disabled'>Assign</button>";

                    }
                        
                   
                    display += "</tr>";
                }



            }
            display += "</tbody>";
            display += "</table>";

            employeess.InnerHtml = display;

          

      

        }
        protected  void search_Clicked(object sender, EventArgs e)
        {
            string display = "";
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage response = client.GetAsync("Users?email=" + search.Value).Result;

           
            //var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?email=" + search.Value);
            var user = response.Content.ReadAsAsync<Users>().Result;
            //var user = JsonConvert.DeserializeObject<Users>(response);

            if (user != null)
            {
                display += "<table class='table table-bordered table-striped table-condensed'>";
                display += "<thead>";
                display += "   </thead>";
                display += "   <tbody>";
                display += "<tr>";

                display += $"       <td>{user.Name}</td>                   ";
                display += $"       <td>{user.Surname}</td>                   ";
                display += $"       <td>{user.Email}</td>                   ";
                display += $"       <td>{user.Phonenumber}</td>                   ";
                display += "</tr>";
                display += "</tbody>";
                display += "</table>";


                emailS.InnerHtml = display;
                if (user.status.Equals("0"))
                {
                    noactive.Visible = true;
                }


                if (user.status.Equals("1"))
                {
                    active.Visible = true;
                }

            }
            else
            {
                wrong.Attributes.Add("style", "color:red;");
                wrong.Text = "User Does't exist";
                wrong.Visible = true;
            }



        }

        protected void addEmpoyee_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage response = client.GetAsync("Users?name=" + name.Value + "&surname=" + surname.Value + "&email=" + email.Value + "&password=" + password.Value + "&phone=" + phone.Value + "&adress="+1+"&usert=" + input.Value + "&Status=" + 1 + "&gender=male").Result;

            var user = response.Content.ReadAsAsync<int>().Result;
            //  var user = JsonConvert.DeserializeObject<int>(response);

            if (user == -1)
            {
                error.Attributes.Add("style", "color:red;");
                error.Text = "Something went wrong";
                error.Visible = true;
            }

            //error.Attributes.Add("style", "color:green;");
            //error.Text = "Employee Succefully Registerd";
            //error.Visible = true;
            Response.Redirect("employees.aspx");


        }

        protected  void activate_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");




           // var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?email=" + search.Value);
            HttpResponseMessage response = client.GetAsync("Users?email="+search.Value).Result;
       //     var user = JsonConvert.DeserializeObject<Users>(response);
            var user = response.Content.ReadAsAsync<Users>().Result;
            //  https://typapi.azurewebsites.net/api/Users?userID={userID}&email={email}&Status={Status}


            HttpResponseMessage response1 = client.GetAsync("Users?userID=" + user.Id + "&email=" + user.Email + "&Status=" + 1).Result;
            //var response1 = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?userID=" + user.Id + "&email=" + user.Email + "&Status=" + 1);
            var edit = response1.Content.ReadAsAsync<int>().Result;
           // var edit = JsonConvert.DeserializeObject<int>(response1);

            if (edit == 1)
            {
                //   error.Attributes.Add("style", "color:green;");
                //    error.Text = "Item Succefully updated";
                //error.Visible = true;
                Response.Redirect("employees.aspx");

            }
        }

        protected  void deactivate_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage response = client.GetAsync("Users?email="+search.Value).Result;
            //     var user = JsonConvert.DeserializeObject<Users>(response);
            var user = response.Content.ReadAsAsync<Users>().Result;

            //  https://typapi.azurewebsites.net/api/Users?userID={userID}&email={email}&Status={Status}

            HttpResponseMessage response1 = client.GetAsync("Users?userID=" + user.Id + "&email=" + user.Email + "&Status=" + 0).Result;
            //var response1 = await client.GetStringAsync("https://typapi.azurewebsites.net/api/Users?userID=" + user.Id + "&email=" + user.Email + "&Status=" + 1);
            var edit = response1.Content.ReadAsAsync<int>().Result;

            if (edit == 1)
            {
                //   error.Attributes.Add("style", "color:green;");
                //    error.Text = "Item Succefully updated";
                //error.Visible = true;
                Response.Redirect("employees.aspx");

            }


        }
    }
}