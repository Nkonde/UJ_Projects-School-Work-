﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stylesmanager.aspx.cs" Inherits="TYPWebApplication.Stylesmanager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
                        <div class="row">
                            <div class="col-md-4">

                               
                                <div class="main-card mb-3 card">
            <div class="card-body"><h5 class="card-title">Style Form</h5>
                                
                                            <div class="form-row">
                                               
                                            </div>
                                            <div class="position-relative form-group"><label for="exampleAddress" class="">Name</label><input name="address" id="name"  runat="server" placeholder="name" type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Price </label><input name="address2" id="price"  runat="server"  placeholder="price"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Description</label><input name="address3" id="descrip"  runat="server"  placeholder="description"  type="text" class="form-control">
                                            </div>                                                                                                                              
                                            <%--<div class="position-relative form-group"><label for="exampleAddress2" class="">Style</label><input name="address3" id="type"  runat="server"  placeholder="hair System"  type="text" class="form-control">--%>
                                              <div class="position-relative form-group">          
                                             <select name="input" runat="server" id="type" class="mb-2 form-control-lg form-control">
	                                         <option value="Nails">Nails</option>
                                                 <option value="Manicure">Manicure</option>
                                                 <option value="Artificial">Artificial Nail</option>
                                                 <option value="Silk">Gel Nails</option>
                                             </select>
                                
                                            </div>
                                              <br />
                                             <br />
                                             <asp:FileUpload ID="FileUpload1" runat="server" />   
                
                                             <button runat="server" class="mt-2 btn btn-primary"  onserverclick="addStyle_Clicked" >Add Style</button>                            
                                    </div>
                                         <asp:Label ID="error" runat="server" Visible="false"></asp:Label> 
            
              
         
                    </div>
            











                            </div>


                            <div class="col-md-8">
                                <div class="main-card mb-3 card">
                                   <div class="content-panel">
                      <h4><i class="fa  fa-hand-o-right"></i> Styles </h4>
                      <section id="Active" runat="server">
                      </section>
                      </div>
                               </div>
                            </div>
                        </div>
</asp:Content>
