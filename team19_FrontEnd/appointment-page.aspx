<%@ Page Title="Appointmemnt Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="appointment-page.aspx.cs" Inherits="TYPWebApplication.appointment_page" %>

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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-6 col-xl-4">
            <div class="card mb-3 widget-content bg-midnight-bloom">
                <div class="widget-content-wrapper text-white">
                    <div class="widget-content-left">
                    <div class="widget-heading">Completed</div>
                    <div class="widget-subheading"></div>
                </div>
                <div class="widget-content-right" runat="server" id="completed">
                    <%--<div class="widget-numbers text-white"><span>1896</span></div>--%>
                </div>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-xl-4">
            <div class="card mb-3 widget-content bg-arielle-smile">
                <div class="widget-content-wrapper text-white">
                    <div class="widget-content-left">
                    <div class="widget-heading">In Progress</div>
                    <div class="widget-subheading"></div>
                </div>
                <div class="widget-content-right" runat="server" id="inprogess">
                    <%--<div class="widget-numbers text-white"><span>$ 568</span></div>--%>
                </div>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-xl-4">
            <div class="card mb-3 widget-content bg-grow-early">
                <div class="widget-content-wrapper text-white">
                    <div class="widget-content-left">
                        <div class="widget-heading">Waiting</div>
                        <div class="widget-subheading"></div>
                    </div>
                    <div class="widget-content-right" runat="server" id="inwaiting">
                        <%--<div class="widget-numbers text-white"><span>46%</span></div>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="main-card mb-3 card">
        <div class="card-header">
            <div runat ="server" id="TotalBooking"></div>
            <div class="btn-actions-pane-right">
                <div role="group" class="btn-group-sm btn-group">
                    <button class="active btn btn-focus">Last Week</button>
                    <button class="btn btn-focus">All Month</button>
                </div>
            </div>
        </div>
        <div class="table-responsive">
            <table class="align-middle mb-0 table table-borderless table-striped table-hover">
                <thead>
                    <tr>
                        <th class="text-center">#</th>
                        <th>Name</th>
                        <th class="text-center">Service</th>
                        <th class="text-center">Status</th>
                        <th class="text-center">Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <section runat="server" id="listClients">

                    </section>
                </tbody>
            </table>
        </div>
    </div>

  

<div class="modal fade bd-example-modal-sm" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-sm">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle">Modal title</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                <button type="button" class="btn btn-primary">Save changes</button>
            </div>
        </div>
    </div>
</div>
  <script type="text/javascript" src="./assets/scripts/main.js"></script>
</asp:Content>                                    