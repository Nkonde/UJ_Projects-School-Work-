<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="TYPWebApplication.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
     
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no, shrink-to-fit=no" />
    <meta name="description" content="Tables are the backbone of almost all web applications.">
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

    
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     
   <div class="container-fluid mt-5 mb-5  ">
    <div class="p-2 bg-white px-4 rounded">
        <div class="d-flex flex-row justify-content-between align-items-center">
            <div class="d-flex flex-row align-items-center filters">
                <span class="ml-2">All types</span><i class="fa fa-angle-down ml-1"></i></div>
            <div class="d-flex flex-row align-items-center filters mt-2">
                <div class="sub-cat" style="border-bottom: 2px solid blue;">
                    <h3>Nail Styles we Available now</h3>
                </div>
              
            </div>
            <div class="d-flex flex-row align-items-center filters">
                <div class="d-flex flex-row align-items-center">
                    <span class="ml-2">our price</span><i class="fa fa-angle-down ml-1"></i></div>
            </div>
        </div>
    </div>

         <div class="row" id="treport" runat="server"></div>
        <div class="row" id="stock" runat="server"></div>
        <%-- <div class="row" runat ="server" id="recent">--%>

      </div>



                   


</asp:Content>
