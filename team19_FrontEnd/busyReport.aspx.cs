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
    public partial class busyReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


            HttpResponseMessage response = client.GetAsync("Bookings").Result;
            var item = response.Content.ReadAsAsync<List<Root>>().Result;


            double mon = 0;
            double tue = 0;
            double wed = 0;
            double thur = 0;
            double fri = 0;
            double total = 0;

            foreach (var r in item)
            {
                total += Convert.ToDouble(r.Status.Equals("Completed"));

                if (r.Date.DayOfWeek==DayOfWeek.Monday)
                {
                    mon += Convert.ToDouble(r.Status.Equals("Completed"));
                }

                if (r.Date.DayOfWeek==DayOfWeek.Tuesday)
                {
                    tue += Convert.ToDouble(r.Status.Equals("Completed"));
                }

                if (r.Date.DayOfWeek==DayOfWeek.Wednesday)
                {
                    wed += Convert.ToDouble(r.Status.Equals("Completed"));
                }

                if (r.Date.DayOfWeek==DayOfWeek.Thursday)
                {
                    thur += Convert.ToDouble(r.Status.Equals("Completed"));
                }
                if (r.Date.DayOfWeek==DayOfWeek.Friday)
                {
                    fri += Convert.ToDouble(r.Status.Equals("Completed"));
                }
            }

            var values = new List<double> { (mon/total)*100, (tue/total)*100, (wed/total)*100, (thur/total)*100,(fri/total)*100 };

            string display = "";

            display += "<script>";
            display += "$(function() {";
            display += "'use strict';";

            display += "var ctx1 = document.getElementById('chartBar1').getContext('2d');";
            display += "new Chart(ctx1, {";
            display += "type: 'bar',";
            display += "data: {";
            display += "labels:['Mon', 'Tue', 'Wed', 'Thur', 'Frid'],";
            display += "datasets:";
            display += "[{";
            display += "label: 'Average Apointments %',";
            display += "data:[" + (mon/total)*100+ ", " + (tue/total)*100 + ", " + (thur/total)*100 + ", " + (wed/total)*100 + ", " + (fri/total)*100 + "],";
            display += "backgroundColor: '#66424d'";
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
            display += "max: " + (values.Max() + (values.Max() * 0.2)) + "";
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