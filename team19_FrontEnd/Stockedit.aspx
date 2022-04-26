<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stockedit.aspx.cs" Inherits="TYPWebApplication.Stockedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
                            <div class="col-md-4">

                                 
                                <div class="main-card mb-3 card">
            <div class="card-body"><h5 class="card-title">Update Form</h5>
                                
                                            <div class="form-row">
                                               
                                            </div>
                 <div class="position-relative form-group"><label for="exampleAddress" class="">Name</label><input name="address" id="name"  runat="server" placeholder="name" type="text" class="form-control"></div>
                                          <div class="position-relative form-group"><label for="exampleAddress2" class="">Description </label><input name="address2" id="description"  runat="server"  placeholder="Description"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Price</label><input name="address3" id="price"  runat="server"  placeholder="Price "  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Stock Price</label><input name="address3" id="StockPrice"  runat="server"  placeholder="Stock Price"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Suppier Name</label><input name="address3" id="supplier"  runat="server"  placeholder="Supplier Name"  type="text" class="form-control">
                                            </div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Storage Capacity</label><input name="address3" id="Storage"  runat="server"  placeholder="Storage Capacity"  type="text" class="form-control"></div>
                                             
                                               
                                             <select class="mb-2 form-control-lg form-control" id="input"  runat="server">
                                                  <option value="" disabled selected hidden>on Special?</option>      
                                                 <option  runat="server" value="1">Yes</option>
                                                        <option  runat="server" value="0">No</option>
                                                    </select>

                                              <br />
                                             <br />
                                             <asp:FileUpload ID="FileUpload2" runat="server" />   
                
                                             <button runat="server" class="mt-2 btn btn-primary"  onserverclick="updateS_Clicked" >Update Stock</button>   
                                            
                 <asp:Label ID="error" runat="server" Visible="false"></asp:Label> 
                  <ul class="nav">
                                        <li class="nav-item">
                                            <a href="stockmanagement.aspx" class="nav-link">
                                                Back
                                            </a>
                                        </li>
                                        
                                    </ul>
                                    </div>
         
                    </div>
   
                            </div>
                        </div>
                        
     
</asp:Content>
