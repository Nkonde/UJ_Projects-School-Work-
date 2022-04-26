<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PickStylist.aspx.cs" Inherits="TYPWebApplication.PickStylist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <%--<title>Analytics Dashboard - This is an example dashboard created using build-in elements and components.</title>--%>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no, shrink-to-fit=no" />
    <meta name="description" content="This is an example dashboard created using build-in elements and components.">
    <meta name="msapplication-tap-highlight" content="no">
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
    <link href="./main.css" rel="stylesheet">

    <style>

        .rating>label {
            position: relative;
            width: 1em;
            font-size: 6vw;
            color: #FFD600;
            cursor: pointer
        }

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


                            <div class="col-md-12">
                                <div class="main-card mb-3 card">
                                    <div class="card-header  list-group-item-info list-group-item">Choose Stylist
                                        
                                    </div>

                                    <div class="table-responsive">
                                        <table id="myTable" class="align-middle mb-0 table table-borderless table-striped table-hover">
                                            <thead>
                                            <tr> 
                                                <th>Name</th>
                                                <th class="text-center">Style</th>
                                                <th class="text-center">Rating Average</th>
                                               <th class="text-center">Time Slot</th>
                                            </tr>
                                            </thead>
                                            <tbody>
                                            <tr>
                                      
				                        <section id="slot" runat="server"></section>   
                                                </table>
                                   </div>






                                </div>
                             </div>




</asp:Content>
