<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminDashboard.aspx.cs" Inherits="TYPWebApplication.adminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="app-main__inner">
                        <div class="row">
                            <div class="col-md-6 col-xl-4">
                                <div class="card mb-3 widget-content bg-midnight-bloom">
                                    <div class="widget-content-wrapper text-white">
                                        <div class="widget-content-left">
                                            <div class="widget-heading">Sold Items</div>
                                            <div class="widget-subheading">
                                            </div>
                                        </div>
                                        <div class="widget-content-right" runat="server" id="totalorders">
                                          
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-xl-4">
                                <div class="card mb-3 widget-content bg-arielle-smile">
                                    <div class="widget-content-wrapper text-white">
                                        <div class="widget-content-left">
                                            <div class="widget-heading">Total Stock</div>
                                        </div>
                                        <div class="widget-content-right" runat="server" id="stock">
                                           
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 col-xl-4">
                                <div class="card mb-3 widget-content bg-grow-early">
                                    <div class="widget-content-wrapper text-white">
                                        <div class="widget-content-left">
                                            <div class="widget-heading">Profit</div>
                                            <div class="widget-subheading">Total Profit</div>
                                        </div>
                                        <div class="widget-content-right" runat="server" id="profit">
                                       
                                        </div>
                                    </div>
                                </div>
                            </div>


                              
                       </div>   
                        




           <section class="wrapper">
        
        
            <div class="content-panel">
              <h4><i class="fa fa-angle-right"></i> Stock</h4>
              <section id="Active" runat="server">
              </section>
            </div>
            <!-- /content-panel -->
       
          <!-- /col-lg-4 -->
      


      </section>













                    </div>
                        </div>
        </div>


</asp:Content>
