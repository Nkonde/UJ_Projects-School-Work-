<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="TYPWebApplication.PlaceOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="main-card mb-3 card">
                          
                                    <div class="card-body"><h5 class="card-title">Vertical Menu</h5>
                                        <div class="row">
                                            <div class="col">
                                                <ul class="nav flex-column">
                                                    <li class="nav-item"><a disabled="" href="javascript:void(0);" class="nav-link disabled">Supplier Name:</a></li>
                                                    <li class="nav-item"><a disabled="" href="javascript:void(0);" class="nav-link disabled">Item Name :</a></li>
                                                    <li class="nav-item"><a disabled="" href="javascript:void(0);" class="nav-link disabled">Stock Price :</a></li>
                                                     <li class="nav-item"><a disabled="" href="javascript:void(0);" class="nav-link disabled">QTY :</a></li>
                                                    <li class="nav-item"><a disabled="" href="javascript:void(0);" class="nav-link disabled">Total Amount :</a></li>
                                                    
                                                </ul>
                                            </div>
                                            <div class="col">
                                                <ul class="nav flex-column" runat="server" id="invoice">
                                             
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="divider"></div>
                                        <div class="text-center">
                                            <div class="btn-group dropdown">
                                                  <button runat="server" class="mt-2 btn btn-primary" id="btnPlaceOder" visible="false"  onserverclick="StockOrder_Clicked" >Order Stock</button>
                                               
                                            </div>
                                        </div>
                                          <asp:Label ID="error" runat="server" Visible="false"></asp:Label>      
                                    </div>

                                 


                             
                           <ul class="nav">
                                        <li class="nav-item">
                                            <a href="adminDashboard.aspx" class="nav-link">
                                                Back
                                            </a>
                                        </li>
                                        
                                    </ul>
                                    </div>
                                
                       




</asp:Content>
