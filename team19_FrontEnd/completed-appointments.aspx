<%@ Page Title="Completed Appointment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="completed-appointments.aspx.cs" Inherits="TYPWebApplication.completed_appointments" %>

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
    <div class="col-md-12">
        <div class="main-card mb-3 card">
            <div class="card-header">
                Completed Appointments
                                        <div class="btn-actions-pane-right">
                                            <div role="group" class="btn-group-sm btn-group">
                                                <%--<button class="active btn btn-focus">Last Week</button>
                                                <button class="btn btn-focus">All Month</button>--%>
                                            </div>
                                        </div>
            </div>
            <div class="table-responsive">
            <table class="align-middle mb-0 table table-borderless table-striped table-hover">
                <thead>
                    <tr>
                        <th class="text-center">Booking ID</th>
                        <th>Customer Name</th>
                         <th class="text-center">Service Type</th>
                        <th class="text-center">Date</th>
                        <th class="text-center">Time</th>
                    </tr>
                </thead>
                <tbody>
                    <section runat="server" id="reportCo">

                    </section>
                </tbody>
            </table>
        </div>
        </div>
    </div>
    <script type="text/javascript" src="./assets/scripts/main.js"></script>
</asp:Content>
