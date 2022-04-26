<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addstyle.aspx.cs" Inherits="TYPWebApplication.addstyle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main-card mb-3 card">
                           <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
                                <div class="main-card mb-3 card">
                                    <div class="card-body"><h5 class="card-title">Add HairStyle</h5>
                                
                                            <div class="form-row">
                                               
                                            </div>
                                            <div class="position-relative form-group"><label for="exampleAddress" class="">Name</label><input name="address" id="name"  runat="server" placeholder="name" type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Price </label><input name="address2" id="price"  runat="server"  placeholder="price"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Description</label><input name="address3" id="descrip"  runat="server"  placeholder="description"  type="text" class="form-control">
                                            </div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Hair Style</label><input name="address3" id="type"  runat="server"  placeholder="hair System"  type="text" class="form-control">
                                            </div>
                                              <br />
                                             <br />
                                             <asp:FileUpload ID="FileUpload1" runat="server" />
                                                
                                           
                                            
                                            <button runat="server" class="mt-2 btn btn-primary"  onserverclick="addStyle_Clicked" >Add Package</button>
                                       
                                       
                                    </div>
                                         <asp:Label ID="error" runat="server" Visible="false"></asp:Label>                          
        </div>
        </div>
        </div>
</asp:Content>
