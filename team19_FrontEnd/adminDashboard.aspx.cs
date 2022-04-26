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
    public partial class adminDashboard : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
          

            //    api/StockOrders
            string display = "";
            string display1 = "";
            string display2 = "";
            string display4 = "";
            string display5 = "";

            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");

            HttpResponseMessage response = client.GetAsync("stock").Result;
            //var response = await client.GetStringAsync("https://typapi.azurewebsites.net/api/stock");
            var user = response.Content.ReadAsAsync<List<Stock>>().Result;
           // var user = JsonConvert.DeserializeObject<List<Stock>>(response);

            double sum = 0;
            int sum1 = 0;
            double sum3 = 0;
            double profit1 = 0;
            foreach (var r in user)
            {
                if (r.status.Equals(1))
                {
                    sum1 += Convert.ToInt32(r.AvaibleStock);
                    sum += Convert.ToDouble(r.Sold);
                    sum3 += Convert.ToDouble(r.Price) - Convert.ToDouble(r.stockprice);
                    profit1 += sum3 * sum;
                }

            }

            display += "<div class='widget-numbers text-white'><span>" + sum + "</span></div>";
            totalorders.InnerHtml = display;
            display1 += "<div class='widget-numbers text-white'>" + sum1 + "</div>";
            stock.InnerHtml = display1;
            display4 += "<div class='widget - numbers text - white'><span>R" + profit1 + "</span></div>";
            profit.InnerHtml = display4;

            display2 += "<table class='table table-bordered table-striped table-condensed'>";
            display2 += "<thead>";
            display2 += "<tr>";

            display2 += "       <td>Item ID</td>";
            display2 += "       <td>Item Name</td>";
            display2 += "       <td>Item Price</td>";
            display2 += "       <td>Stock Aval</td>";
            display2 += "       <td>Sold</td>";
            display2 += "       <td>Max Space</td>";
            display2 += "       <td>Status</td>";
            display2 += "       <td>Add Stock</td>";

            display2 += "</tr>";
            display2 += "   </thead>";
            display2 += "   <tbody>";

            foreach (var r in user)
            {
                if (r.status.Equals(1))
                {
                    display2 += "<tr>";
                    display2 += $"       <td>{r.Id}</td>                   ";
                    display2 += $"       <td>{r.Name}</td>                   ";
                    display2 += $"       <td>R{r.Price}</td>                   ";
                    display2 += $"       <td>{r.AvaibleStock}</td>                   ";
                    display2 += $"       <td>{r.Sold}</td>                   ";
                    display2 += $"       <td>{r.maxAmountStock}</td>                   ";

                    if ((double)r.AvaibleStock <= (double)r.maxAmountStock * 0.4)
                    {
                        display2 += $"       <td> <div class='badge badge-danger'>Low Stock</div></td>                   ";
                    }
                    else if ((double)r.AvaibleStock <= (double)r.maxAmountStock * 0.6)
                    {
                        display2 += $"       <td> <div class='badge badge-warning'> Balanced Stock </div></td>                   ";
                    }
                    else if ((double)r.AvaibleStock <= (double)r.maxAmountStock * 1)
                    {
                        display2 += $"       <td> <div class='badge badge-success'>High Stock</div></td>                   ";
                    }

                    display2 += " <td>";
                    display2 += "<a href='PlaceOrder.aspx?ID=" + r.Id + "'>";
                    display2 += "<button type ='button' onserverclick='Clicked' class='mt-2 btn btn-primary'  onserverclick='addStyle_Clicked'>Buy Stock</button>";
                    display2 += "</a>";
                    display2 += "</td > ";
                    display2 += "</tr>";
                }
            }
            display2 += "</tbody>";
            display2 += "</table>";

            Active.InnerHtml = display2;

            //int totaltaking = 0;

            //var response1 = await client.GetStringAsync("https://typapi.azurewebsites.net/api/StockOrders");
            //var btn = JsonConvert.DeserializeObject<List<StockOrder>>(response1);

            //foreach (var r in btn)
            //{
            //    totaltaking += Convert.ToInt32(r.Status);


            //}

            //display5 += "<a href ='notifications.aspx'>";
            //display5 += "<li class='nav-item'>";
            //display5 += "<button class='mb-2 mr-2 btn btn-info'>Stock Taking<span class='badge badge-pill badge-light'>" + totaltaking + "</span></button>";
            //display5 += "</li>";
            //display5 += "</a>";

            //takings.InnerHtml = display5;
        }
    }
}