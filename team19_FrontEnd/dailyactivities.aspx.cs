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
    public partial class dailyactivities : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            //HttpClient client = new HttpClient();


            //client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


          //  HttpResponseMessage response = client.GetAsync("Users").Result;
           // var user = response.Content.ReadAsAsync<List<Users>>().Result;
            string display = "";

            display += "         <table class='align-middle mb-0 table table-borderless table-striped table-hover'>                                                                      ";
            display += "                                        <thead>                                                                                                                  ";
            display += "                                        <tr>                                                                                                                     ";
            display += "                                            <th class='text-center'>#</th>                                                                                       ";
            display += "                                            <th>Name</th>                                                                                                        ";
            display += "                                            <th class='text-center'>Actions</th>                                                                                 ";
            display += "                                        </tr>                                                                                                                    ";
            display += "                                        </thead>                                                                                                                 ";
            display += "                                        <tbody>                                                                                                                  ";
            display += "                                        <tr>                                                                                                                     ";
            display += "                                            <td class='text-center text-muted'>#345</td>                                                                         ";
            display += "                                            <td>                                                                                                                 ";
            display += "                                                <div class='widget-content p-0'>                                                                                 ";
            display += "                                                    <div class='widget-content-wrapper'>                                                                         ";
            display += "                                                        <div class='widget-content-left mr-3'>                                                                   ";
            display += "                                                            <div class='widget-content-left'>                                                                    ";
            display += "                                                            </div>                                                                                               ";
            display += "                                                        </div>                                                                                                   ";
            display += "                                                        <div class='widget-content-left flex2'>                                                                  ";
            display += "                                                            <div class='widget-heading'>John Doe</div>                                                           ";
            display += "                                                            <div class='widget-subheading opacity-7'>Web Developer</div>                                         ";
            display += "                                                        </div>                                                                                                   ";
            display += "                                                    </div>                                                                                                       ";
            display += "                                                </div>                                                                                                           ";
            display += "                                            </td>                                                                                                                ";
            display += "                                            <td class='text-center'>                                                                                             ";
            display += "                                                <button type='button' id='PopoverCustomT-1' class='btn btn-primary btn-sm'>Details</button>                      ";
            display += "                                            </td>                                                                                                                ";
            display += "                                        </tr>                                                                                                                    ";
            display += "                                        </tbody>                                                                                                                 ";
            display += "                                    </table>                                                                                                            ";


            topemplo.InnerHtml = display;
        }


    }
}                                                                                                                                                                      