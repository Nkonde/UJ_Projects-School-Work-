<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="TYPWebApplication.Checkout" %>
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
    <style>
        body {
    background-color: #eee
}

.container {
    height: 100vh
}

.card {
    border: none
}

.form-control {
    border-bottom: 2px solid #eee !important;
    border: none;
    font-weight: 600
}

.form-control:focus {
    color: #495057;
    background-color: #fff;
    border-color: #8bbafe;
    outline: 0;
    box-shadow: none;
    border-radius: 0px;
    border-bottom: 2px solid blue !important
}

.inputbox {
    position: relative;
    margin-bottom: 20px;
    width: 100%
}

.inputbox span {
    position: absolute;
    top: 7px;
    left: 11px;
    transition: 0.5s
}

.inputbox i {
    position: absolute;
    top: 13px;
    right: 8px;
    transition: 0.5s;
    color: #3F51B5
}

input::-webkit-outer-spin-button,
input::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0
}

.inputbox input:focus~span {
    transform: translateX(-0px) translateY(-15px);
    font-size: 12px
}

.inputbox input:valid~span {
    transform: translateX(-0px) translateY(-15px);
    font-size: 12px
}

.card-blue {
    background-color: #492bc4
}

.hightlight {
    background-color: #5737d9;
    padding: 10px;
    border-radius: 10px;
    margin-top: 15px;
    font-size: 14px
}

.yellow {
    color: #fdcc49
}

.decoration {
    text-decoration: none;
    font-size: 14px
}

.btn-success {
    color: #fff;
    background-color: #492bc4;
    border-color: #492bc4
}

.btn-success:hover {
    color: #fff;
    background-color: #492bc4;
    border-color: #492bc4
}

.decoration:hover {
    text-decoration: none;
    color: #fdcc49
}
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <div class="container mt-5 px-5">
    <div class="mb-4">
        <h2>Confirm order and pay</h2> <span>please make the payment, after that you can enjoy all the features and benefits.</span>
    </div>
    <div class="row">
        <div class="col-md-8">
            <div class="card p-3">
                <h6 class="text-uppercase">Payment details</h6>


                    <div class="inputbox mt-3">
                        <input type="text" name="name" placeholder="Name on card" class="form-control" required="required">
                    </div>

                     <div class="inputbox mt-3 mr-2"> 
                        <input type="text" name="name" class="form-control" placeholder="Card Number" maxlength='16' required="required"> <i class="fa fa-credit-card"></i>
                    </div>

                    <div class="d-flex flex-row">
                            <div class="inputbox mt-3 mr-2"> 
                            <input type="text" name="name" placeholder="MM/YY" maxlength='5' onkeyup="formatString(event);" class="form-control" required="required"></div>
                    </div>

                    <div class="d-flex flex-row">
                            <div class="inputbox mt-3 mr-2">
                           <input type="text" name="name" placeholder="CVV" maxlength='3' size='4' class="form-control" required="required"> </div>
                    </div>

                    <div class="form-row">
                     <div class="col-md-6"> 

                      <input name="phone" id="service" placeholder="Feedback" runat="server" type="text" class="form-control">
                            <button class="mt-2 btn btn-primary" type="submit" onserverclick="Purchase"  runat="server"> Submit</button>				                    	       
						         <asp:Label ID="lblStatus" runat="server"></asp:Label>                              
                      </div>
                      </div>

                  

                  </div>
                </div>
             </div>
          </div>

        
   



</asp:Content>
