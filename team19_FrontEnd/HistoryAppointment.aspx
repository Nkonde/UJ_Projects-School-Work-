<%@ Page Title=""  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HistoryAppointment.aspx.cs" Inherits="TYPWebApplication.HistoryAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
            <style>
            .checked {
              color: orange;
            }
            </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="col-md-12">
                                <div class="main-card mb-3 card">
                                    <div class="card-header  list-group-item-info list-group-item">MY History Appointment
                                        <div class="btn-actions-pane-right">
                                            <%--<div role="group" class="btn-group-sm btn-group">
                                                <button class="active btn btn-focus">Last Week</button>
                                                <button class="btn btn-focus">All Month</button>
                                            </div>--%>
                                        </div>
                                    </div>

                                    <div class="table-responsive">
                                        <table id="myTable" class="align-middle mb-0 table table-borderless table-striped table-hover">
                                            <thead>
                                            <tr> 
                                                <th>Booking ID</th>
                                                <th class="text-center">Stylist Name</th>
                                                <th class="text-center">Style</th>
                                                <th class="text-center">Rate Stylist</th>
                                                
                                            </tr>
                                            </thead>
                                            <tbody>
                                            <tr>
                                      
				                          <section id="treport" runat="server"></section>

                                            <%-- <span class="fa fa-star checked"></span>
                                            <span class="fa fa-star checked"></span>
                                            <span class="fa fa-star checked"></span>
                                            <span class="fa fa-star"></span>
                                            <span class="fa fa-star"></span>--%>
                                   </table>                                 
                                   </div>
                                </div>
                             </div>


</asp:Content>
