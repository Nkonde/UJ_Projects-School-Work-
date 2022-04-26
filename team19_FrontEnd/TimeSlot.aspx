<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TimeSlot.aspx.cs" Inherits="TYPWebApplication.TimeSlot" %>
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

     <style type="text/css">
            #vertical-2 thead,#vertical-2 tbody{
                display:inline-block;
            }
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                          <div class="col-md-12">
                                <div class="main-card mb-3 card">
                                    <div class="card-header  list-group-item-info list-group-item">Choose Date and Time
                                        <div class="btn-actions-pane-right">
                                            <%--<div role="group" class="btn-group-sm btn-group">
                                                <button class="active btn btn-focus">Last Week</button>
                                                <button class="btn btn-focus">All Month</button>
                                            </div>--%>
                                        </div>
                                    </div>
                     



                                         <%-- <div class="form-row">
                                                <div class="col-md-6">
                                                     <div class="position-relative form-group"><label for="examplePassword11" class="">Date [Mon-Fri]</label>    
                                                    <input name="email" id="date1" placeholder="Date" runat="server" type="date" class="form-control" />
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Password</label><input name="password" id="examplePassword11" placeholder="password placeholder" type="password"
                                                                                                                                                             class="form-control"></div>
                                                </div>
                                            </div>--%>

                                          <div class="form">
                                                <div class="col-md-6">
                                                      <div class="position-relative form-group"><label for="examplePassword11" class=""></label>    
                                                  <%-- <input name="email" id="date1" placeholder="Date" runat="server" type="date" class="form-control" />--%>
                                                </div>
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Date [Mon-Fri]</label>    
                                                    <input name="email" id="date" placeholder="Date" runat="server" type="date" class="form-control" />
                                                    
                                                     <button  class="mb-2 mr-2 btn btn-primary btn-lg btn-block" type="submit" onserverclick="Book_Clicked" runat="server">
						                    	        View Time Slot
						                              </button>
                                                    
                                                    </div>
                                                </div>                              
                                            </div>

                                   

                                    <div class="table-responsive">
                                        <table id="myTable" class="align-middle mb-0 table table-borderless table-striped table-hover">
                                           
                                                <tbody>
                                                      <tr>
                                                      <td><b>Time</b></td>                                                       
                                                      <td><b> Status</b></td> 
                                                      <td><b>Book</b></td> 
                                                    </tr>
                                                     <div class="row"   id="slot" runat="server"></div>
                                                    <%--<tr>
                                                        <td>row 1</td>                                                      
                                                        <td>data</td>
                                                        <td>data</td>
                                                         
                                                    </tr>--%>
                                                   <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                                </tbody>                                        
                                         </table>
                                   </div>
                                </div>
                             </div>

</asp:Content>
