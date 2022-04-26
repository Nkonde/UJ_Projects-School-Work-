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
    public partial class Stockreport : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


            HttpResponseMessage response = client.GetAsync("StockOrders").Result;
            var item = response.Content.ReadAsAsync<List<StockOrder>>().Result;
        


            double jan = 0;
            double feb = 0;
            double mar = 0;
            double aprl = 0;
            double may = 0;
            double jun = 0;
            double jul = 0;
            double aug = 0;
            double sep = 0;
            double oct = 0;
            double nov = 0;
            double dec = 0;
            double total = 0;

            foreach (var r in item)
            {

                total += Convert.ToDouble(r.Price_);
                if (r.OderDate >= Convert.ToDateTime("1/1/2021") && r.OderDate <= Convert.ToDateTime("1/31/2021"))
                {
                    jan += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("2/1/2021") && r.OderDate <= Convert.ToDateTime("2/28/2021"))
                {
                    feb += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("3/1/2021") && r.OderDate <= Convert.ToDateTime("3/31/2021"))
                {
                    mar += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("4/1/2021") && r.OderDate <= Convert.ToDateTime("5/31/2021"))
                {
                    aprl += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("5/1/2021") && r.OderDate <= Convert.ToDateTime("5/31/2021"))
                {
                    may += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("6/1/2021") && r.OderDate <= Convert.ToDateTime("6/30/2021"))
                {
                    jun += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("7/1/2021") && r.OderDate <= Convert.ToDateTime("7/31/2021"))
                {
                    jul += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("8/1/2021") && r.OderDate <= Convert.ToDateTime("8/31/2021"))
                {
                    aug += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("9/1/2021") && r.OderDate <= Convert.ToDateTime("9/30/2021"))
                {
                    sep += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("10/1/2021") && r.OderDate <= Convert.ToDateTime("10/31/2021"))
                {
                    oct += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("11/1/2021") && r.OderDate <= Convert.ToDateTime("11/30/2021"))
                {
                    nov += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("12/1/2021") && r.OderDate <= Convert.ToDateTime("12/31/2021"))
                {
                    dec += Convert.ToDouble(r.Price_);
                }
            }


            string display = "";

            display += "<script>";
            display += "$(function() {";
            display += "'use strict';";

            display += "var ctx1 = document.getElementById('chartBar1').getContext('2d');";
            display += "new Chart(ctx1, {";
            display += "type: 'bar',";
            display += "data: {";
            display += "labels:['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],";
            display += "datasets:";
            display += "[{";
            display += "label: '# Total Recieved Stock',";
            display += "data:[" + jan + ", " + feb + ", " + mar + ", " + aprl + ", " + may + "," + jun + "," + jul + ", " + aug + ", " + sep + ", " + oct + ", " + nov + ", " + dec + "],";
            display += "backgroundColor: '#560bd0'";
            display += "}]";
            display += "},";
            display += "options:";
            display += "{";
            display += "maintainAspectRatio: false,";
            display += "responsive: true,";
            display += "legend:";
            display += "{";
            display += "display: false,";
            display += "labels:";
            display += "{";
            display += "display: false";
            display += "}";
            display += "},";
            display += "scales:";
            display += "{";
            display += "yAxes:";
            display += "[{";
            display += "ticks:";
            display += "{";
            display += "beginAtZero: true,";
            display += "fontSize: 10,";
            display += "max: 10000";
            display += "}";
            display += "}],";
            display += "xAxes:";
            display += "[{";
            display += "barPercentage: 0.6,";
            display += "ticks:";
            display += "{";
            display += "beginAtZero: true,";
            display += "fontSize: 11";
            display += "}";
            display += "}]";
            display += "}";
            display += "}";
            display += "});";

            display += "});";


            display += "</script>";

            jsBar.InnerHtml = display;

        }
    }
}