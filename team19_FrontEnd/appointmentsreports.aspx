<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="appointmentsreports.aspx.cs" Inherits="TYPWebApplication.appointmentsreports" %>
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

<div class="tab-content">
                      
                              
                                   






















       <div class="main-card mb-3 card">
                                            <div class="card-header"><i class="header-icon lnr-license icon-gradient bg-plum-plate"> </i>Appointments Reports
                                                <div class="btn-actions-pane-right">
                                                    <div role="group" class="btn-group-sm nav btn-group">
                                                        <a data-toggle="tab" href="#tab-eg1-0" class="btn-shadow active btn btn-primary">Completed Appointments</a>
                                                        <a data-toggle="tab" href="#tab-eg1-1" class="btn-shadow  btn btn-primary">Pending Appointments</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="card-body">
                                                <div class="tab-content">
                                                    <div class="tab-pane active" id="tab-eg1-0" role="tabpanel">
                                                       
       
              <div class="az-content-label mg-b-5">Completed Appointments </div>        
              <div class="chartjs-wrapper-demo">    <canvas id="chartBar2" width="350" height="250" style="display: block; width: 350px; height: 250px;" class="chartjs-render-monitor"></canvas></div>
                                                        
           







                                                    </div>
                                                    <div class="tab-pane" id="tab-eg1-1" role="tabpanel">

                                                        <div class="az-content-label mg-b-5">Pending Appointments  </div>
                                                        
                                                      <div class="chartjs-wrapper-demo">    <canvas id="chartBar3" width="350" height="250" style="display: block; width: 350px; height: 250px;" class="chartjs-render-monitor"></canvas></div>





                                                    </div>
                                                    <div class="tab-pane" id="tab-eg1-2" role="tabpanel">
                                                        <div class="az-content-label mg-b-5">Weekly Sales </div>
                                                         <p class="mg-b-20">Montly Average Sales.</p>
                                                      <div class="chartjs-wrapper-demo"><canvas id="chartLine3"></canvas></div>

                                                    </div>
                                                </div>
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



            <div runat="server" id="jsbar2">
            </div>



                     


</asp:Content>
