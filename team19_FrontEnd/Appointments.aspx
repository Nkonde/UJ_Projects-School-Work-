<%@ Page   Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Appointments.aspx.cs" Inherits="TYPWebApplication.Appointments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <style>

       /*:root{
           box-sizing:border-box;
       }
       *,*::after,*::before{
           box-sizing:inherit;
           margin:0;
           padding:0;
       }
       .product img{
           max-width:75%;
           min-width:0;
           position:center;
       }
       .container{
           display:grid;
           
           height:70vh;
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
           background-color:hsl(30,50%,75%);*/
        /*  // opacity:*/
           /*mix-blend-mode:hue;
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
        }*/
   </style>
   
</asp:Content>



        
       
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
                      
                            <div class="form-row">
                          <div class="col-lg-6" id="tab-content-0" role="tabpanel">
                                <div class="main-card mb-3 card" >
                                    <div class="card-body"><h1 class="card-title">Confirm Appointment Details</h1>
                     

                                        <div class="col">

                                               <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Date</label>    
                                                    <input name="email" id="fdate" placeholder="Date" runat="server" type="no" class="form-control" />
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="form-row">
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Time</label>    
                                                    <input name="phone" id="ftime" placeholder="Time" runat="server" type="no" class="form-control">
                                                    </div>
                                                </div>
                                             </div>

                                            <div class="form-row">
                                                 <div class="col-md-6">
                                                     <div class="position-relative form-group"><label for="examplePassword11" class="">Style Name</label>  
                                                    <input type="text" id="fname" runat="server" name="fname" class="form-control">
                                                    </div>
                                             </div>
                                            </div>
                                      

                                         <div class="form-row">
                                                 <div class="col-md-6">
                                                      <div class="position-relative form-group"><label for="examplePassword11" class="">Pick Stylist</label>  
                                                   <input type="text" list="zoo" id="stylist"  runat="server" name="fname" class="form-control"/>
                                                           <%-- <datalist id="cars">
                                                              <option>Volvo</option>
                                                              <option>Saab</option>
                                                              <option>Mercedes</option>
                                                              <option>Audi</option>                                                              
                                                            </datalist>--%>
                                                           <section id="Section2" runat="server"></section>

                                                    </div>
                                                  </div>
                                             </div>

                                              <div class="form-row">
                                                    <div class="container-login100-form-btn">
						                              <button class="mt-2 btn btn-primary" type="submit" onserverclick="Book_Clicked" runat="server">
						                    	        Book Appointment
						                              </button>
                                                         <asp:Label ID="lblStatus" runat="server"></asp:Label>
					                                </div>
                                                </div>


                                         </div>

                                       
                                          
                                </div>
                            </div>
                              </div>

                             <div class="col-lg-6">
                                   <div class="main-card mb-3 card">
                                        <section class="container">
                                                <input type="radio" name="color"  id="color_1" checked hidden />
                                                <input type="radio" name="color"  id="color_2" hidden />
                                                <input type="radio" name="color"  id="color_3"  hidden/>
                                                <input type="radio" name="color"  id="color_4" hidden/>

                                                <div class="product">
                                                     <section id="Section1" runat="server"></section>
                                                </div>

                                               <%--<div class="product-nav">
                                                   <label for="color_1"></label>
                                                   <label for="color_2"></label>
                                                   <label for="color_3"></label>
                                                   <label for="color_4"></label>
                                               </div>--%>

                                            </section>

                                       </div>

<%--                                 <div class="form-row">
                                                    <div class="container-login100-form-btn">
						                              <button class="mt-2 btn btn-primary" type="submit" onserverclick="Book_Clicked" runat="server">
						                    	        Customize Style
						                              </button>
                                                         <asp:Label ID="Label1" runat="server"></asp:Label>
					                                </div>
                                                </div>--%>
                        
                            </div>
                            </div>
  
              
</asp:Content>
