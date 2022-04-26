<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="busyReport.aspx.cs" Inherits="TYPWebApplication.busyReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

            <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>Dashboard Boxes - Highly configurable boxes best used for showing numbers in an user friendly way.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no, shrink-to-fit=no">
    <meta name="description" content="Highly configurable boxes best used for showing numbers in an user friendly way.">
    <meta name="msapplication-tap-highlight" content="no">
   
    
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-90680653-2"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'UA-90680653-2');
    </script>
<link rel="stylesheet" href="../css/azia.css">
    
    <!--
    =========================================================
    * ArchitectUI HTML Theme Dashboard - v1.0.0
    =========================================================
    * Product Page: https://dashboardpack.com
    * Copyright 2019 DashboardPack (https://dashboardpack.com)
    * Licensed under MIT (https://github.com/DashboardPack/architectui-html-theme-free/blob/master/LICENSE)
    =========================================================
    * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
    -->
<link href="./main.css" rel="stylesheet"><style type="text/css">/* Chart.js */
@-webkit-keyframes chartjs-render-animation{from{opacity:0.99}to{opacity:1}}@keyframes chartjs-render-animation{from{opacity:0.99}to{opacity:1}}.chartjs-render-monitor{-webkit-animation:chartjs-render-animation 0.001s;animation:chartjs-render-animation 0.001s;}</style></head>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="az-content-body pd-lg-l-40 d-flex flex-column">
        
          <h2 class="az-content-title">Popular Days</h2>

          <div class="az-content-label mg-b-5">Mon-Fri</div>
         
          
           
              <div class="ht-400 ht-lg-250"><canvas id="chartBar1"></canvas></div>
            
         
         



         
        </div><!-- az-content-body -->
       
                  
                            </div>


                         
                   
                       </div>   
                    
                     
    <script src="../lib/jquery/jquery.min.js"></script>
    <script src="../lib/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../lib/ionicons/ionicons.js"></script>
    <script src="../lib/chart.js/Chart.bundle.min.js"></script>


    <script src="../js/azia.js"></script>
    <script src="../js/jquery.cookie.js" type="text/javascript"></script>
   
<script type="text/javascript" src="./assets/scripts/main.js"></script>

            <div runat="server" id="jsBar">

                 

            </div>





</asp:Content>
