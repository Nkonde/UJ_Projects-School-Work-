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
    public partial class salesreport : System.Web.UI.Page
    {
        private readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
//sales (weekly)
//display+="               <script>                                                ";
//display+="        $(function() {                                                 ";
//display+="                'use strict';                                          ";
//display+="                /* LINE CHART */                                       ";
//display+="                var ctx8 = document.getElementById('chartLine1');      ";
//display+="                new Chart(ctx8, {                                      ";
//display+="                type: 'line',                                          ";
//display+="                data: {                                                ";
//display+="                    labels:['Mon', 'Tue', 'Wed', 'Thur', 'Fri'],       ";
//display+="                    datasets:                                          ";
//display+="                    [{                                                 ";
//display+="                        data:[12, 15, 18, 4, 35],                      ";
//display+="                        borderColor: '#f10075',                        ";
//display+="                        borderWidth: 1,                                ";
//display+="                        fill: false                                    ";
//display+="                    }, {                                               ";
//display+="                        data:[10, 20, 50, 4, 50],                      ";
//display+="                        borderColor: '#007bff',                        ";
//display+="                        borderWidth: 1,                                ";
//display+="                        fill: false                                    ";
//display+="                    }]                                                 ";
//display+="                },                                                     ";
//display+="                options:                                               ";
//display+="                {                                                      ";
//display+="                    maintainAspectRatio: false,                        ";
//display+="                    legend:                                            ";
//display+="                    {                                                  ";
//display+="                        display: false,                                ";
//display+="                        labels:                                        ";
//display+="                        {                                              ";
//display+="                            display: false                             ";
//display+="                        }                                              ";
//display+="                    },                                                 ";
//display+="                    scales:                                            ";
//display+="                    {                                                  ";
//display+="                        yAxes:                                         ";
//display+="                        [{                                             ";
//display+="                            ticks:                                     ";
//display+="                            {                                          ";
//display+="                                beginAtZero: true,                     ";
//display+="                                fontSize: 10,                          ";
//display+="                                max: 80                                ";
//display+="                            }                                          ";
//display+="                        }],                                            ";
//display+="                        xAxes:                                         ";
//display+="                        [{                                             ";
//display+="                            ticks:                                     ";
//display+="                            {                                          ";
//display+="                                beginAtZero: true,                     ";
//display+="                                fontSize: 11                           ";
//display+="                            }                                          ";
//display+="                        }]                                             ";
//display+="                    }                                                  ";
//display+="                }                                                      ";
//display+="            });                                                        ";
//display+="        });                                                            ";
//display += "    </script>                                                          ";







            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44301/api/");


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

            //prev
            double jan1 = 0;
            double feb1 = 0;
            double mar1 = 0;
            double aprl1 = 0;
            double may1 = 0;
            double jun1 = 0;
            double jul1 = 0;
            double aug1 = 0;
            double sep1 = 0;
            double oct1 = 0;
            double nov1 = 0;
            double dec1 = 0;
            double total1 = 0;

            foreach (var r in item)
            {

                total1 += Convert.ToDouble(r.Price_);
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


            foreach (var r in item)
            {

                total += Convert.ToDouble(r.Price_);
                if (r.OderDate >= Convert.ToDateTime("1/1/2020") && r.OderDate <= Convert.ToDateTime("1/31/2020"))
                {
                    jan1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("2/1/2020") && r.OderDate <= Convert.ToDateTime("2/28/2020"))
                {
                    feb1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("3/1/2020") && r.OderDate <= Convert.ToDateTime("3/31/2020"))
                {
                    mar1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("4/1/2020") && r.OderDate <= Convert.ToDateTime("5/31/2020"))
                {
                    aprl1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("5/1/2020") && r.OderDate <= Convert.ToDateTime("5/31/2020"))
                {
                    may1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("6/1/2020") && r.OderDate <= Convert.ToDateTime("6/30/202"))
                {
                    jun1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("7/1/2020") && r.OderDate <= Convert.ToDateTime("7/31/2020"))
                {
                    jul1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("8/1/2020") && r.OderDate <= Convert.ToDateTime("8/31/202"))
                {
                    aug1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("9/1/2020") && r.OderDate <= Convert.ToDateTime("9/30/2020"))
                {
                    sep1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("10/1/2020") && r.OderDate <= Convert.ToDateTime("10/31/2020"))
                {
                    oct1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("11/1/2020") && r.OderDate <= Convert.ToDateTime("11/30/2020"))
                {
                    nov1 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("12/1/2020") && r.OderDate <= Convert.ToDateTime("12/31/2020"))
                {
                    dec1 += Convert.ToDouble(r.Price_);
                }
            }






            display += "    <script>                                                                                                                   ";
display+="        $(function () {                                                                                                        ";
display+="            'use strict';                                                                                                      ";
display+="            var ctx8 = document.getElementById('chartLine2');                                                                  ";
display+="        new Chart(ctx8, {                                                                                                      ";
display+="            type: 'line',                                                                                                      ";
display+="                data:                                                                                                          ";
display+="            {                                                                                                                  ";
display+="                labels:['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'July', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],                  ";
display+="                    datasets:                                                                                                  ";
display+="                [{                                                                                                             ";
display+="                    data:["+jan+", "+feb+", "+mar+", "+aprl+", "+may+", "+jun+", "+jul+", "+aug+", "+sep+", "+oct+", "+nov+", "+dec+"],                                                     ";
display+="                        borderColor: '#f10075',                                                                                ";
display+="                        borderWidth: 1,                                                                                        ";
display+="                        fill: false                                                                                            ";
display+="                    }, {                                                                                                       ";
display+= "                     data:[" + jan1 + ", " + feb1 + ", " + mar1 + ", " + aprl1 + ", " + may1 + ", " + jun1 + ", " + jul1 + ", " + aug1 + ", " + sep1 + ", " + oct1 + ", " + nov1 + ", " + dec1 + "],                                                   ";
display+="                        borderColor: '#007bff',                                                                                ";
display+="                        borderWidth: 1,                                                                                        ";
display+="                        fill: false                                                                                            ";
display+="                    }]                                                                                                         ";
display+="                },                                                                                                             ";
display+="                options:                                                                                                       ";
display+="            {                                                                                                                  ";
display+="                maintainAspectRatio: false,                                                                                    ";
display+="                    legend:                                                                                                    ";
display+="                {                                                                                                              ";
display+="                    display: false,                                                                                            ";
display+="                        labels:                                                                                                ";
display+="                    {                                                                                                          ";
display+="                        display: false                                                                                         ";
display+="                        }                                                                                                      ";
display+="                },                                                                                                             ";
display+="                    scales:                                                                                                    ";
display+="                {                                                                                                              ";
display+="                    yAxes:                                                                                                     ";
display+="                    [{                                                                                                         ";
display+="                        ticks:                                                                                                 ";
display+="                        {                                                                                                      ";
display+="                            beginAtZero: true,                                                                                 ";
display+="                                fontSize: 10,                                                                                  ";
display+="                                max: 80                                                                                        ";
display+="                            }                                                                                                  ";
display+="                    }],                                                                                                        ";
display+="                        xAxes:                                                                                                 ";
display+="                    [{                                                                                                         ";
display+="                        ticks:                                                                                                 ";
display+="                        {                                                                                                      ";
display+="                            beginAtZero: true,                                                                                 ";
display+="                                fontSize: 11                                                                                   ";
display+="                            }                                                                                                  ";
display+="                    }]                                                                                                         ";
display+="                    }                                                                                                          ";
display+="            }                                                                                                                  ";
display+="        });                                                                                                                    ";
display+="        });                                                                                                                    "; display += "    </script>                                                                                                                  ";







            double jan0 = 0;
            double feb0 = 0;
            double mar0 = 0;
            double apr0 = 0;
            double may0 = 0;
            double jun0 = 0;
            double jul0 = 0;
            double aug0 = 0;
            double sep0 = 0;
            double oct0 = 0;
            double nov0 = 0;
            double dec0 = 0;
            double total0 = 0;

            //prev
            double jan2 = 0;
            double feb2 = 0;
            double mar2 = 0;
            double apr2 = 0;
            double may2 = 0;
            double jun2 = 0;
            double jul2 = 0;
            double aug2 = 0;
            double sep2 = 0;
            double oct2 = 0;
            double nov2 = 0;
            double dec2 = 0;
            double total2 = 0;

            foreach (var r in item)
            {

                total0 += Convert.ToDouble(r.Price_);
                if (r.OderDate >= Convert.ToDateTime("1/1/2021") && r.OderDate <= Convert.ToDateTime("1/31/2021"))
                {
                    jan0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("2/1/2021") && r.OderDate <= Convert.ToDateTime("2/28/2021"))
                {
                    feb0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("3/1/2021") && r.OderDate <= Convert.ToDateTime("3/31/2021"))
                {
                    mar0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("4/1/2021") && r.OderDate <= Convert.ToDateTime("5/31/2021"))
                {
                    apr0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("5/1/2021") && r.OderDate <= Convert.ToDateTime("5/31/2021"))
                {
                    may0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("6/1/2021") && r.OderDate <= Convert.ToDateTime("6/30/2021"))
                {
                    jun0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("7/1/2021") && r.OderDate <= Convert.ToDateTime("7/31/2021"))
                {
                    jul0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("8/1/2021") && r.OderDate <= Convert.ToDateTime("8/31/2021"))
                {
                    aug0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("9/1/2021") && r.OderDate <= Convert.ToDateTime("9/30/2021"))
                {
                    sep0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("10/1/2021") && r.OderDate <= Convert.ToDateTime("10/31/2021"))
                {
                    oct0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("11/1/2021") && r.OderDate <= Convert.ToDateTime("11/30/2021"))
                {
                    nov0 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("12/1/2021") && r.OderDate <= Convert.ToDateTime("12/31/2021"))
                {
                    dec0 += Convert.ToDouble(r.Price_);
                }
            }


            foreach (var r in item)
            {

                total2 += Convert.ToDouble(r.Price_);
                if (r.OderDate >= Convert.ToDateTime("1/1/2020") && r.OderDate <= Convert.ToDateTime("1/31/2020"))
                {
                    jan2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("2/1/2020") && r.OderDate <= Convert.ToDateTime("2/28/2020"))
                {
                    feb2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("3/1/2020") && r.OderDate <= Convert.ToDateTime("3/31/2020"))
                {
                    mar2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("4/1/2020") && r.OderDate <= Convert.ToDateTime("5/31/2020"))
                {
                    apr2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("5/1/2020") && r.OderDate <= Convert.ToDateTime("5/31/2020"))
                {
                    may2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("6/1/2020") && r.OderDate <= Convert.ToDateTime("6/30/202"))
                {
                    jun2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("7/1/2020") && r.OderDate <= Convert.ToDateTime("7/31/2020"))
                {
                    jul2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("8/1/2020") && r.OderDate <= Convert.ToDateTime("8/31/202"))
                {
                    aug2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("9/1/2020") && r.OderDate <= Convert.ToDateTime("9/30/2020"))
                {
                    sep2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("10/1/2020") && r.OderDate <= Convert.ToDateTime("10/31/2020"))
                {
                    oct2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("11/1/2020") && r.OderDate <= Convert.ToDateTime("11/30/2020"))
                {
                    nov2 += Convert.ToDouble(r.Price_);
                }
                if (r.OderDate >= Convert.ToDateTime("12/1/2020") && r.OderDate <= Convert.ToDateTime("12/31/2020"))
                {
                    dec2 += Convert.ToDouble(r.Price_);
                }
            }







            display += "        <script>                                                                                                                                     ";
display+="        $(function () {                                                                                                                              ";
display+="            'use strict';                                                                                                                            ";
display+="                    var ctx8 = document.getElementById('chartLine3');                                                                                ";
display+="    new Chart(ctx8, {                                                                                                                                ";
display+="        type: 'line',                                                                                                                                ";
display+="                data:                                                                                                                                ";
display+="        {                                                                                                                                            ";
display+="            labels:['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'July', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],                                            ";
display+="                    datasets:                                                                                                                        ";
display+="            [{                                                                                                                                       ";
display+= "                data:[" + jan0 + ", " + feb0 + ", " + mar0 + ", " + apr0 + ", " + may0 + ", " + jun0 + ", " + jul0 + ", " + aug0 + ", " + sep0 + ", " + oct0 + ", " + nov0 + ", " + dec0 + "],                                                                                       ";
display+="                        borderColor: '#f10075',                                                                                                      ";
display+="                        borderWidth: 1,                                                                                                              ";
display+="                        fill: false                                                                                                                  ";
display+="                    }, {                                                                                                                             ";
display+= "                data:[" + jan2 + ", " + feb2 + ", " + mar2 + ", " + apr2 + ", " + may2 + ", " + jun2 + ", " + jul2 + ", " + aug2 + ", " + sep2 + ", " + oct2 + ", " + nov2 + ", " + dec2 + "],                                                                                      ";
display+="                        borderColor: '#007bff',                                                                                                      ";
display+="                        borderWidth: 1,                                                                                                              ";
display+="                        fill: false                                                                                                                  ";
display+="                    }]                                                                                                                               ";
display+="                },                                                                                                                                   ";
display+="                options:                                                                                                                             ";
display+="        {                                                                                                                                            ";
display+="            maintainAspectRatio: false,                                                                                                              ";
display+="                    legend:                                                                                                                          ";
display+="            {                                                                                                                                        ";
display+="                display: false,                                                                                                                      ";
display+="                        labels:                                                                                                                      ";
display+="                {                                                                                                                                    ";
display+="                    display: false                                                                                                                   ";
display+="                        }                                                                                                                            ";
display+="            },                                                                                                                                       ";
display+="                    scales:                                                                                                                          ";
display+="            {                                                                                                                                        ";
display+="                yAxes:                                                                                                                               ";
display+="                [{                                                                                                                                   ";
display+="                    ticks:                                                                                                                           ";
display+="                    {                                                                                                                                ";
display+="                        beginAtZero: true,                                                                                                           ";
display+="                                fontSize: 10,                                                                                                        ";
display+="                                max: 80                                                                                                              ";
display+="                            }                                                                                                                        ";
display+="                }],                                                                                                                                  ";
display+="                        xAxes:                                                                                                                       ";
display+="                [{                                                                                                                                   ";
display+="                    ticks:                                                                                                                           ";
display+="                    {                                                                                                                                ";
display+="                        beginAtZero: true,                                                                                                           ";
display+="                                fontSize: 11                                                                                                         ";
display+="                            }                                                                                                                        ";
display+="                }]                                                                                                                                   ";
display+="                    }                                                                                                                                ";
display+="        }                                                                                                                                            ";
display+="    });                                                                                                                                              ";
display+="                                                                                                                                                     ";
display+="        });                                                                                                                                          ";
display+="                                                                                                                                                     ";
            display += "    </ script >                                                                                                                                      ";


            salesscript.InnerHtml = display;
        }
    }
}