using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPWebApplication.Models;

namespace TYPWebApplication
{
    public partial class Stylereports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://typapi.azurewebsites.net/api/");


<<<<<<< HEAD
            HttpResponseMessage response = client.GetAsync("Booking?x=" + 0 + "&y=" + 0 + "&thanabi=" + 1).Result;
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> b79a4c32eef165f10b6cd8d1ccb938d8a4786b56
            HttpResponseMessage response = client.GetAsync("Booking?x=" + 0 + "&y=" + 0 + "&thanabi=" + 1).Result;
            var item = response.Content.ReadAsAsync<List<Root>>().Result;

            List<string> list = new List<string>();


            foreach (var r in item)
            {
                list.Add(r.Service);
<<<<<<< HEAD
=======
=======
            HttpResponseMessage response = client.GetAsync("Booking?x="+0+"&y="+0).Result;
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
            var item = response.Content.ReadAsAsync<List<Root>>().Result;

            List<string> list = new List<string>();


            foreach (var r in item)
            {
<<<<<<< HEAD
                list.Add(r.Service);
=======
                list.Add(r.Service);    
>>>>>>> f80f60440ae79f41501455be8766ed5efa98804d
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
            }

            var q = from x in list
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
<<<<<<< HEAD

            //    var values = new List<double> { (mon / total) * 100, (tue / total) * 100, (wed / total) * 100, (thur / total) * 100, (fri / total) * 100 };


            string display = "";

            double total = 0;
            foreach (var x in q)
            {
                total += Convert.ToDouble(x.Count);
            }

            //    foreach (var x in q)
            //{


            //    display += "<div class='text-center'>"+x.Value+"</div>";                                                                                                    
            //    display += "<div class='mb-3 progress'>";

            //    display += "<div class='progress-bar' role='progressbar' aria-valuenow='100' aria-valuemin='50' aria-valuemax='100' style='width: "+((x.Count/total)*100)+"%;'>"+Math.Round(((x.Count/total)*100),2)+"%</div>";
            //    display += " </div>";
            //   // Console.Write("Value: " + x.Value + "  "  ",");
            //}




            foreach (var x in q)
<<<<<<< HEAD
=======
            {


                display += "    <div class='widget-content-wrapper'>";
                display += "                                       <div class='widget-content-left pr-2 fsize-1'>";
                display += "                                           <div class='widget-numbers mt-0 fsize-3 text-success'>" + Math.Round(((x.Count / total) * 100), 0) + "%</div>";
                display += "                                       </div>";
                display += "                                       <div class='widget-content-right w-100'>";
                display += "                                           <div class='progress-bar-xs progress'>";
                display += "                                               <div class='progress-bar bg-success' role='progressbar' aria-valuenow=" + ((x.Count / total) * 100) + " aria-valuemin='0' aria-valuemax='100' style='width: " + ((x.Count / total) * 100) + "%;'></div>";
                display += "                                           </div>";
                display += "                                       </div>";
                display += "                                   </div>";
                display += "                                   <div class='widget-content-left fsize-1'>";
                display += "                                       <div class='text-muted opacity-6'>" + x.Value + "</div>";
                display += "                                   </div>";
            }

            stylesrepo.InnerHtml = display;


            string display1 = "";



            /*
             * 
             * get top stylist algorhm
             */



            HttpResponseMessage response1 = client.GetAsync("Rating").Result;
            var rate = response1.Content.ReadAsAsync<List<Rating>>().Result;

            List<int> ratelist = new List<int>();


            foreach (var r in rate)
            {
                ratelist.Add(r.stylistID);
            }

            var rt = from w in ratelist
                     group w by w into a
                     let count = a.Count()
                     orderby count descending
                     select new { Value = a.Key, Count = count };



            double total1 = 0;
            foreach (var kx in rt)
            {
                total1 += Convert.ToDouble(kx.Count);
>>>>>>> b79a4c32eef165f10b6cd8d1ccb938d8a4786b56
            }
            


         
            foreach (var kx in rt)
            {


                HttpResponseMessage response3 = client.GetAsync("Users?userId=" +kx.Value).Result;
                var rate1 = response3.Content.ReadAsAsync<Users>().Result;


                display1 += " <li class='list-group-item'>";
                display1 += "<div class='widget-content p-0'>";
                display1 += "<div class='widget-content-wrapper'>";
                display1 += " <div class='widget-content-left mr-3'>";
                display1 += "<div class='font-icon-wrapper'><i class='metismenu-icon pe-7s-user'></i></div>";
                display1 += " </div>";
                display1 += " <div class='widget-content-left'>";
                display1 += "     <div class='widget-heading'>"+rate1.Name+"</div>";
                display1 += "     <div class='widget-subheading'>Stylist</div>";
                display1 += " </div>";
                display1 += " <div class='widget-content-right'>";
                display1 += "<div class='font-size-xlg text-muted'>";
                display1 += "  <small class='text-danger pl-2'>";
                display1 += "<button class='mb-2 mr-2 btn btn-warning'>☆☆☆☆☆<span class='badge badge-pill badge-light'>"+Math.Round((kx.Count/total1)*5,0)+"</span></button>";
                display1 += "</small>";
                display1 += " </div>";
                display1 += " </div>";
                display1 += "</div>";
                display1 += "</div>";
                display1 += " </li>";
                //qna.InnerHtml = display;
            }

            employ.InnerHtml = display1;
=======

            //    var values = new List<double> { (mon / total) * 100, (tue / total) * 100, (wed / total) * 100, (thur / total) * 100, (fri / total) * 100 };

<<<<<<< HEAD
            var q = from x in list
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            //    var values = new List<double> { (mon / total) * 100, (tue / total) * 100, (wed / total) * 100, (thur / total) * 100, (fri / total) * 100 };

=======
>>>>>>> b79a4c32eef165f10b6cd8d1ccb938d8a4786b56

            string display = "";

            double total = 0;
            foreach (var x in q)
            {
                total += Convert.ToDouble(x.Count);
            }

<<<<<<< HEAD
            //    foreach (var x in q)
            //{


            //    display += "<div class='text-center'>"+x.Value+"</div>";                                                                                                    
            //    display += "<div class='mb-3 progress'>";

            //    display += "<div class='progress-bar' role='progressbar' aria-valuenow='100' aria-valuemin='50' aria-valuemax='100' style='width: "+((x.Count/total)*100)+"%;'>"+Math.Round(((x.Count/total)*100),2)+"%</div>";
            //    display += " </div>";
            //   // Console.Write("Value: " + x.Value + "  "  ",");
            //}




            foreach (var x in q)
            {


                display += "    <div class='widget-content-wrapper'>";
                display += "                                       <div class='widget-content-left pr-2 fsize-1'>";
                display += "                                           <div class='widget-numbers mt-0 fsize-3 text-success'>" + Math.Round(((x.Count / total) * 100), 0) + "%</div>";
                display += "                                       </div>";
                display += "                                       <div class='widget-content-right w-100'>";
                display += "                                           <div class='progress-bar-xs progress'>";
                display += "                                               <div class='progress-bar bg-success' role='progressbar' aria-valuenow=" + ((x.Count / total) * 100) + " aria-valuemin='0' aria-valuemax='100' style='width: " + ((x.Count / total) * 100) + "%;'></div>";
                display += "                                           </div>";
                display += "                                       </div>";
                display += "                                   </div>";
                display += "                                   <div class='widget-content-left fsize-1'>";
                display += "                                       <div class='text-muted opacity-6'>" + x.Value + "</div>";
                display += "                                   </div>";
            }

            stylesrepo.InnerHtml = display;


            string display1 = "";



            /*
             * 
             * get top stylist algorhm
             */



            HttpResponseMessage response1 = client.GetAsync("Rating").Result;
            var rate = response1.Content.ReadAsAsync<List<Rating>>().Result;

            List<int> ratelist = new List<int>();


            foreach (var r in rate)
            {
                ratelist.Add(r.stylistID);
            }

            var rt = from w in ratelist
                     group w by w into a
                     let count = a.Count()
                     orderby count descending
                     select new { Value = a.Key, Count = count };



            double total1 = 0;
            foreach (var kx in rt)
            {
                total1 += Convert.ToDouble(kx.Count);
            }
            


         
            foreach (var kx in rt)
            {


                HttpResponseMessage response3 = client.GetAsync("Users?userId=" +kx.Value).Result;
                var rate1 = response3.Content.ReadAsAsync<Users>().Result;


                display1 += " <li class='list-group-item'>";
                display1 += "<div class='widget-content p-0'>";
                display1 += "<div class='widget-content-wrapper'>";
                display1 += " <div class='widget-content-left mr-3'>";
                display1 += "<div class='font-icon-wrapper'><i class='metismenu-icon pe-7s-user'></i></div>";
                display1 += " </div>";
                display1 += " <div class='widget-content-left'>";
                display1 += "     <div class='widget-heading'>"+rate1.Name+"</div>";
                display1 += "     <div class='widget-subheading'>Stylist</div>";
                display1 += " </div>";
                display1 += " <div class='widget-content-right'>";
                display1 += "<div class='font-size-xlg text-muted'>";
                display1 += "  <small class='text-danger pl-2'>";
                display1 += "<button class='mb-2 mr-2 btn btn-warning'>☆☆☆☆☆<span class='badge badge-pill badge-light'>"+Math.Round((kx.Count/total1)*5,0)+"</span></button>";
                display1 += "</small>";
                display1 += " </div>";
                display1 += " </div>";
                display1 += "</div>";
                display1 += "</div>";
                display1 += " </li>";
                //qna.InnerHtml = display;
            }

            employ.InnerHtml = display1;
=======
                foreach (var x in q)
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
            {


                display += "    <div class='widget-content-wrapper'>";
                display += "                                       <div class='widget-content-left pr-2 fsize-1'>";
                display += "                                           <div class='widget-numbers mt-0 fsize-3 text-success'>" + Math.Round(((x.Count / total) * 100), 0) + "%</div>";
                display += "                                       </div>";
                display += "                                       <div class='widget-content-right w-100'>";
                display += "                                           <div class='progress-bar-xs progress'>";
                display += "                                               <div class='progress-bar bg-success' role='progressbar' aria-valuenow=" + ((x.Count / total) * 100) + " aria-valuemin='0' aria-valuemax='100' style='width: " + ((x.Count / total) * 100) + "%;'></div>";
                display += "                                           </div>";
                display += "                                       </div>";
                display += "                                   </div>";
                display += "                                   <div class='widget-content-left fsize-1'>";
                display += "                                       <div class='text-muted opacity-6'>" + x.Value + "</div>";
                display += "                                   </div>";
            }

            stylesrepo.InnerHtml = display;


            string display1 = "";



            /*
             * 
             * get top stylist algorhm
             */



            HttpResponseMessage response1 = client.GetAsync("Rating").Result;
            var rate = response1.Content.ReadAsAsync<List<Rating>>().Result;

            List<int> ratelist = new List<int>();


            foreach (var r in rate)
            {
                ratelist.Add(r.stylistID);
            }

            var rt = from w in ratelist
                     group w by w into a
                     let count = a.Count()
                     orderby count descending
                     select new { Value = a.Key, Count = count };



            double total1 = 0;
            foreach (var kx in rt)
            {
                total1 += Convert.ToDouble(kx.Count);
            }
            


         
            foreach (var kx in rt)
            {


                HttpResponseMessage response3 = client.GetAsync("Users?userId=" +kx.Value).Result;
                var rate1 = response3.Content.ReadAsAsync<Users>().Result;


                display1 += " <li class='list-group-item'>";
                display1 += "<div class='widget-content p-0'>";
                display1 += "<div class='widget-content-wrapper'>";
                display1 += " <div class='widget-content-left mr-3'>";
                display1 += "<div class='font-icon-wrapper'><i class='metismenu-icon pe-7s-user'></i></div>";
                display1 += " </div>";
                display1 += " <div class='widget-content-left'>";
                display1 += "     <div class='widget-heading'>"+rate1.Name+"</div>";
                display1 += "     <div class='widget-subheading'>Stylist</div>";
                display1 += " </div>";
                display1 += " <div class='widget-content-right'>";
                display1 += "<div class='font-size-xlg text-muted'>";
                display1 += "  <small class='text-danger pl-2'>";
                display1 += "<button class='mb-2 mr-2 btn btn-warning'>☆☆☆☆☆<span class='badge badge-pill badge-light'>"+Math.Round((kx.Count/total1)*5,0)+"</span></button>";
                display1 += "</small>";
                display1 += " </div>";
                display1 += " </div>";
                display1 += "</div>";
                display1 += "</div>";
                display1 += " </li>";
                //qna.InnerHtml = display;
            }

<<<<<<< HEAD
            employ.InnerHtml = display1;
=======
           
                                        
            qna.InnerHtml = display;
>>>>>>> f80f60440ae79f41501455be8766ed5efa98804d
>>>>>>> b79a4c32eef165f10b6cd8d1ccb938d8a4786b56
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
        }
    }
}