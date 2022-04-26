<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customize.aspx.cs" Inherits="TYPWebApplication.Customize" %>
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
    <link href="./main.css" rel="styldesheet">
    <style>

        :root{
           box-sizing:border-box;
       }
       *,*::after,*::before{
           box-sizing:inherit;
           margin:0;
           padding:0;
       }
       .product img{
           display:flex;
           max-width:70%;
           /*max-height:25%;*/
           min-width:0;
           position:center;
       }
       .container{
           display:grid;
           
           height:65vh;
           width:80vw;
           background-color:hsl(30, 50%, 75%);
       }
       .product::after{
           content:"";
           position:absolute;
           top:0;
           right:0;
           bottom:0;
           left:0;
           background-color:hsl(30,50%,75%);
        /*  // opacity:*/
           mix-blend-mode:hue;
       }
       .product-nav{
           position:relative;
       }

       .product-nav label{
           display:inline-block;
           width:2vmax;
           height:2vmax;
           background-color:hsl(30, 50%, 75%);
           border-radius:50%;
           cursor:pointer;
           box-shadow:0 0 0 0.5em #fff,
                      0.5em 0.5em 1em -0.15em rgba(0,0,0,0.25);
           transition:200ms all ease-in-out;
       }

       

       .product-nav label+label{
           margin-left:1.5em;
       }
       .product-nav label:nth-of-type(1),#color_1:checked~.product::after{
           background-color:hsl(30,50%,75%);
       }
       .product-nav label:nth-of-type(2),#color_2:checked~.product::after{
           background-color:hsl(120,50%,75%);
       }
       .product-nav label:nth-of-type(3),#color_3:checked~.product::after{
           background-color:hsl(210,50%,75%);
       }
       .product-nav label:nth-of-type(4),#color_4:checked~.product::after{
           background-color:hsl(300,50%,75%);
       }

       #color_1:checked ~ .product-nav > lable:nth-of-type(1),
       #color_2:checked ~ .product-nav > lable:nth-of-type(2),
       #color_3:checked ~ .product-nav > lable:nth-of-type(3),
       #color_4:checked ~ .product-nav > lable:nth-of-type(4){
           transform:scale(1.5);
       }
        #color_1:checked ~ .product-nav >label:nth-of-type(1){
             background-color:hsl(30,70%,45%);
        }
         #color_2:checked ~ .product-nav >label:nth-of-type(2){
             background-color:hsl(120,70%,45%);
        }
       #color_3:checked ~ .product-nav >label:nth-of-type(3){
             background-color:hsl(210,70%,45%);
        }
        #color_4:checked ~ .product-nav >label:nth-of-type(4){
             background-color:hsl(300,70%,45%);
        }
   </style>
   


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


                                <div class="col-lg-12">
                                   <div class="main-card mb-3 card">
                                        <section class="container">
                                                <input type="radio" name="color"  id="color_1" checked hidden />
                                                <input type="radio" name="color"  id="color_2" hidden />
                                                <input type="radio" name="color"  id="color_3"  hidden/>
                                                <input type="radio" name="color"  id="color_4" hidden/>

                                                <div class="product">
                                                    <img id="img" src="/images/palette1.jpg" alt='' />
                                                    
                                                </div>

                                               <div class="product-nav">
                                                   <label for="color_1"></label>
                                                   <label for="color_2"></label>
                                                   <label for="color_3"></label>
                                                   <label for="color_4"></label>
                                               </div>

                                            </section>

                                       </div>
                                     </div>



    <script>
        document.addEventListener("DOMContentLoaded", () => {
            document.querySelector("img").setAttribute("src", recent);
        }
    </script>
</asp:Content>
