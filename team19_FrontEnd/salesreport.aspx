<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="salesreport.aspx.cs" Inherits="TYPWebApplication.salesreport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-90680653-2"></script>
    <script>
      window.dataLayer = window.dataLayer || [];
      function gtag(){dataLayer.push(arguments);}
      gtag('js', new Date());

      gtag('config', 'UA-90680653-2');
    </script>

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Twitter -->
    <!-- <meta name="twitter:site" content="@bootstrapdash">
    <meta name="twitter:creator" content="@bootstrapdash">
    <meta name="twitter:card" content="summary_large_image">
    <meta name="twitter:title" content="Azia">
    <meta name="twitter:description" content="Responsive Bootstrap 4 Dashboard Template">
    <meta name="twitter:image" content="https://www.bootstrapdash.com/azia/img/azia-social.png"> -->

    <!-- Facebook -->
    <!-- <meta property="og:url" content="https://www.bootstrapdash.com/azia">
    <meta property="og:title" content="Azia">
    <meta property="og:description" content="Responsive Bootstrap 4 Dashboard Template">

    <meta property="og:image" content="https://www.bootstrapdash.com/azia/img/azia-social.png">
    <meta property="og:image:secure_url" content="https://www.bootstrapdash.com/azia/img/azia-social.png">
    <meta property="og:image:type" content="image/png">
    <meta property="og:image:width" content="1200">
    <meta property="og:image:height" content="600"> -->

    <!-- Meta -->
    <meta name="description" content="Responsive Bootstrap 4 Dashboard Template">
    <meta name="author" content="BootstrapDash">

    <title>Azia Responsive Bootstrap 4 Dashboard Template</title>

    <!-- vendor css -->
    <link href="../lib/fontawesome-free/css/all.min.css" rel="stylesheet">
    <link href="../lib/ionicons/css/ionicons.min.css" rel="stylesheet">
    <link href="../lib/typicons.font/typicons.css" rel="stylesheet">

    <!-- azia CSS -->
    <link rel="stylesheet" href="../css/azia.css">    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-90680653-2"></script>
    <script>
      window.dataLayer = window.dataLayer || [];
      function gtag(){dataLayer.push(arguments);}
      gtag('js', new Date());

      gtag('config', 'UA-90680653-2');
    </script>

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Twitter -->
    <!-- <meta name="twitter:site" content="@bootstrapdash">
    <meta name="twitter:creator" content="@bootstrapdash">
    <meta name="twitter:card" content="summary_large_image">
    <meta name="twitter:title" content="Azia">
    <meta name="twitter:description" content="Responsive Bootstrap 4 Dashboard Template">
    <meta name="twitter:image" content="https://www.bootstrapdash.com/azia/img/azia-social.png"> -->

    <!-- Facebook -->
    <!-- <meta property="og:url" content="https://www.bootstrapdash.com/azia">
    <meta property="og:title" content="Azia">
    <meta property="og:description" content="Responsive Bootstrap 4 Dashboard Template">

    <meta property="og:image" content="https://www.bootstrapdash.com/azia/img/azia-social.png">
    <meta property="og:image:secure_url" content="https://www.bootstrapdash.com/azia/img/azia-social.png">
    <meta property="og:image:type" content="image/png">
    <meta property="og:image:width" content="1200">
    <meta property="og:image:height" content="600"> -->

    <!-- Meta -->
    <meta name="description" content="Responsive Bootstrap 4 Dashboard Template">
    <meta name="author" content="BootstrapDash">

    <title>Azia Responsive Bootstrap 4 Dashboard Template</title>

    <!-- vendor css -->
    <link href="../lib/fontawesome-free/css/all.min.css" rel="stylesheet">
    <link href="../lib/ionicons/css/ionicons.min.css" rel="stylesheet">
    <link href="../lib/typicons.font/typicons.css" rel="stylesheet">

    <!-- azia CSS -->
    <link rel="stylesheet" href="../css/azia.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
                          
                                    
                                        <div class="main-card mb-3 card">
                                            <div class="card-header"><i class="header-icon lnr-license icon-gradient bg-plum-plate"> </i>Header with Tabs
                                                <div class="btn-actions-pane-right">
                                                    <div role="group" class="btn-group-sm nav btn-group">
                                                        <a data-toggle="tab" href="#tab-eg1-0" class="btn-shadow active btn btn-primary">Weekly</a>
                                                        <a data-toggle="tab" href="#tab-eg1-1" class="btn-shadow  btn btn-primary">Montly</a>
                                                        <a data-toggle="tab" href="#tab-eg1-2" class="btn-shadow  btn btn-primary">Montly Avarage</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="card-body">
                                                <div class="tab-content">
                                                    <div class="tab-pane active" id="tab-eg1-0" role="tabpanel">
                                                       
       
              <div class="az-content-label mg-b-5">Weekly Sales </div>
              <p class="mg-b-20">Below is the basic line chart example.</p>
              <div class="chartjs-wrapper-demo"><canvas id="chartLine1"></canvas></div>
                                                        
           







                                                    </div>
                                                    <div class="tab-pane" id="tab-eg1-1" role="tabpanel">

                                                        <div class="az-content-label mg-b-5">Weekly Sales </div>
                                                         <p class="mg-b-20">Montly total Sales..</p>
                                                      <div class="chartjs-wrapper-demo"><canvas id="chartLine2"></canvas></div>





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
  
    
    <div runat="server" id="salesscript"></div>
    
 
</asp:Content>
