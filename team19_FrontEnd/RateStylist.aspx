<%@ Page Title=""  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RateStylist.aspx.cs" Inherits="TYPWebApplication.RateStylist" %>
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


    <head>
  <link rel="stylesheet" href="//netdna.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css">
</head>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <%--  <a href="#"><i class="fas fa-arrow-left" id="button-back"></i></a>--%>
    <div class="profile-body">
        <div class="photo">
<<<<<<< HEAD
            <img src="images/profile.png" width="100" height="100"
                class="image--cover">
=======
            <img src="images/profile.png"  width="100"  height="100"  class="image--cover">
>>>>>>> 6edc56f6fbcb07fc274e4c05a6172bbf9fad7097
        </div>


      <%--  <body>
          <div class="rate">
            <input type="radio" id="star5" name="rate" value="5" />
            <label for="star5" title="text">5 stars</label>
            <input type="radio" id="star4" name="rate" value="4" />
            <label for="star4" title="text">4 stars</label>
            <input type="radio" id="star3" name="rate" value="3" />
            <label for="star3" title="text">3 stars</label>
            <input type="radio" id="star2" name="rate" value="2" />
            <label for="star2" title="text">2 stars</label>
            <input type="radio" id="star1" name="rate" value="1" />
            <label for="star1" title="text">1 star</label>
          </div>
        </body>--%>
          <section id="treport" runat="server"></section>

         <div class="stars">
          <form action="">

              

            <input class="star star-5" id="star_1" value="1" runat="server" type ="radio" name="star"/>
            <label class="star star-5" for="star_1"></label>

            <input class="star star-4" id="star_2" value="2" runat="server" type="radio" name="star"/>
            <label class="star star-4" for="star_2"></label>

            <input class="star star-3" id="star_3" value="3" runat="server" type="radio" name="star"/>
            <label class="star star-3" for="star_3"></label>

            <input class="star star-2" id="star_4" value="4" runat="server" type="radio" name="star"/>
            <label class="star star-2" for="star_4"></label>

            <input class="star star-1" id="star_5" value="5" runat="server" type="radio" name="star"/>
            <label class="star star-1" for="star_5"></label>
          </form>
        </div>


        
            <%--<h1 class="username">Joane Doe</h1>
            <h2 class="profession"> Designer </h2>
            <h3 class="locationname"><i class="fas fa-map-marker-alt"></i> Paris, France </h3>--%>

           <div class="form-row">
             <div class="col-md-6"> 

              <input name="phone" id="service" placeholder="Feedback" runat="server" type="text" class="form-control">
                    <button class="mt-2 btn btn-primary" type="submit" onserverclick="Rate_Stylist"  runat="server"> Submit</button>				                    	       
						 <asp:Label ID="lblStatus" runat="server"></asp:Label>                              
              </div>
              </div>
            </div>           
      


</asp:Content>
