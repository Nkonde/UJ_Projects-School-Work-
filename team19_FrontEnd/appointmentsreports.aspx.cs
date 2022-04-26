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
    public partial class appointmentsreports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/api/");


            HttpResponseMessage response = client.GetAsync("Bookings").Result;
            var item = response.Content.ReadAsAsync<List<Root>>().Result;

            //completed
            double mon = 0;
            double tue = 0;
            double wed = 0;
            double thur = 0;
            double fri = 0;
            double total = 0;



            //waiting
            double mon1 = 0;
            double tue1 = 0;
            double wed1 = 0;
            double thur1 = 0;
            double fri1 = 0;
            double total1 = 0;
            foreach (var r in item)
            {
                total += Convert.ToDouble(r.Status.Equals("Completed"));

                if (r.Date.DayOfWeek == DayOfWeek.Monday)
                {
                    mon += Convert.ToDouble(r.Status.Equals("Completed"));
                }

                if (r.Date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    tue += Convert.ToDouble(r.Status.Equals("Completed"));
                }

                if (r.Date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    wed += Convert.ToDouble(r.Status.Equals("Completed"));
                }

                if (r.Date.DayOfWeek == DayOfWeek.Thursday)
                {
                    thur += Convert.ToDouble(r.Status.Equals("Completed"));
                }
                if (r.Date.DayOfWeek == DayOfWeek.Friday)
                {
                    fri += Convert.ToDouble(r.Status.Equals("Completed"));
                }
            }




            //upcoming
            foreach (var r in item)
            {
                total1 += Convert.ToDouble(r.Status.Equals("Waiting"));

                if (r.Date.DayOfWeek == DayOfWeek.Monday)
                {
                    mon1 += Convert.ToDouble(r.Status.Equals("Waiting"));
                }

                if (r.Date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    tue1 += Convert.ToDouble(r.Status.Equals("Waiting"));
                }

                if (r.Date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    wed1 += Convert.ToDouble(r.Status.Equals("Waiting"));
                }

                if (r.Date.DayOfWeek == DayOfWeek.Thursday)
                {
                    thur1 += Convert.ToDouble(r.Status.Equals("Waiting"));
                }
                if (r.Date.DayOfWeek == DayOfWeek.Friday)
                {
                    fri1 += Convert.ToDouble(r.Status.Equals("Waiting"));
                }
            }

            var values = new List<double> { (mon / total) * 100, (tue / total) * 100, (wed / total) * 100, (thur / total) * 100, (fri / total) * 100 };
            var values1 = new List<double> { (mon1 / total1) * 100, (tue1 / total1) * 100, (wed1 / total1) * 100, (thur1 / total1) * 100, (fri1 / total1) * 100 };
            string display = "";
            string display1 = "";


        display+="     <script>                                                                                     ";
        display+="               $(function () {                                                                    ";
        display+="                   'use strict';                                                                  ";
        display+="                                                                                                  ";
        display+="                   var ctx2 = document.getElementById('chartBar2').getContext('2d');              ";
        display+="                   new Chart(ctx2, {                                                              ";
        display+="                       type: 'bar',                                                               ";
        display+="                       data: {                                                                    ";
        display+="                           labels: ['Mon', 'Tue', 'Wed', 'Thur', 'Fri'],                    ";
        display+="                           datasets: [{                                                           ";
        display+="                               label: '# Appointments',                                               ";
        display+="                               data: ["+mon+", "+tue+", "+wed+", "+thur+", "+fri+"],                                    ";
        display+= "                               backgroundColor: 'rgb(165,42,42)'                              ";
        display+="                           }]                                                                     ";
        display+="                       },                                                                         ";
        display+="                       options: {                                                                 ";
        display+="                           maintainAspectRatio: false,                                            ";
        display+="                           responsive: true,                                                      ";
        display+="                           legend: {                                                              ";
        display+="                               display: false,                                                    ";
        display+="                               labels: {                                                          ";
        display+="                                   display: false                                                 ";
        display+="                               }                                                                  ";
        display+="                           },                                                                     ";
        display+="                           scales: {                                                              ";
        display+="                               yAxes: [{                                                          ";
        display+="                                   ticks: {                                                       ";
        display+="                                       beginAtZero: true,                                         ";
        display+="                                       fontSize: 10,                                              ";
        display+="                                       max: " +(values.Max() + (values.Max() * 0.2))+"                                                    ";
        display+="                                   }                                                              ";
        display+="                               }],                                                                ";
        display+="                               xAxes: [{                                                          ";
        display+="                                   barPercentage: 0.6,                                            ";
        display+="                                   ticks: {                                                       ";
        display+="                                       beginAtZero: true,                                         ";
        display+="                                       fontSize: 11                                               ";
        display+="                                   }                                                              ";
        display+="                               }]                                                                 ";
        display+="                           }                                                                      ";
        display+="                       }                                                                          ";
        display+="                   });                                                                            ";
        display+="               });                                                                                ";
        display += "           </script>                                                                              ";


           



            display1 += "     <script>                                                                                     ";
            display1 += "               $(function () {                                                                    ";
            display1 += "                   'use strict';                                                                  ";
            display1 += "                                                                                                  ";
            display1 += "                   var ctx2 = document.getElementById('chartBar3').getContext('2d');              ";
            display1 += "                   new Chart(ctx2, {                                                              ";
            display1 += "                       type: 'bar',                                                               ";
            display1 += "                       data: {                                                                    ";
            display1 += "                           labels: ['Mon', 'Tue', 'Wed', 'Thur', 'Fri'],                    ";
            display1 += "                           datasets: [{                                                           ";
            display1 += "                               label: '# Appointsments',                                               ";
<<<<<<< HEAD
            display1 += "                               data: [0, 0, 13, 12, 13, 18],                                    ";
=======
            display1 += "                              data: [" + mon1 + ", " + tue1 + ", " + wed1 + ", " + thur1 + ", " + fri1 + "],                               ";
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
            display1 += "                               backgroundColor: 'rgba(0,123,255,.5)'                              ";
            display1 += "                           }]                                                                     ";
            display1 += "                       },                                                                         ";
            display1 += "                       options: {                                                                 ";
            display1 += "                           maintainAspectRatio: false,                                            ";
            display1 += "                           responsive: true,                                                      ";
            display1 += "                           legend: {                                                              ";
            display1 += "                               display: false,                                                    ";
            display1 += "                               labels: {                                                          ";
            display1 += "                                   display: false                                                 ";
            display1 += "                               }                                                                  ";
            display1 += "                           },                                                                     ";
            display1 += "                           scales: {                                                              ";
            display1 += "                               yAxes: [{                                                          ";
            display1 += "                                   ticks: {                                                       ";
            display1 += "                                       beginAtZero: true,                                         ";
            display1 += "                                       fontSize: 10,                                              ";
            display1 += "                                       max: max: " + (values1.Max() + (values1.Max() * 0.2)) + "                                                     ";
            display1 += "                                   }                                                              ";
            display1 += "                               }],                                                                ";
            display1 += "                               xAxes: [{                                                          ";
            display1 += "                                   barPercentage: 0.6,                                            ";
            display1 += "                                   ticks: {                                                       ";
            display1 += "                                       beginAtZero: true,                                         ";
            display1 += "                                       fontSize: 11                                               ";
            display1 += "                                   }                                                              ";
            display1 += "                               }]                                                                 ";
            display1 += "                           }                                                                      ";
            display1 += "                       }                                                                          ";
            display1 += "                   });                                                                            ";
            display1 += "               });                                                                                ";
            display1 += "           </script>                                                                              ";

            jsbar2.InnerHtml = display;
            jsBar.InnerHtml = display1;




        }
    }
}