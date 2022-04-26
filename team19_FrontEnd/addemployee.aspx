<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addemployee.aspx.cs" Inherits="TYPWebApplication.addemployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main-card mb-3 card">
                           <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
                                <div class="main-card mb-3 card">
                                    <div class="card-body"><h5 class="card-title">Add Employee</h5>
                                
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div  class="position-relative form-group"><label for="Email" class="">Email</label><input name="email"  runat="server" id="email" placeholder="email" type="email" class="form-control"></div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Password</label><input name="password"  runat="server" id="password"  placeholder="password" type="password"
                                                                                                                                                             class="form-control"></div>
                                                </div>
                                            </div>
                                            <div class="position-relative form-group"><label for="exampleAddress" class="">Name</label><input name="address" id="name"  runat="server" placeholder="name" type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Surname </label><input name="address2" id="surname"  runat="server"  placeholder="surname"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Cellphone</label><input name="address3" id="phone"  runat="server"  placeholder="Cellphone"  type="text" class="form-control">
                                            </div>
                                               
                                             <select class="mb-2 form-control-lg form-control" id="input"  runat="server">
                                                        <option  runat="server">Fade</option>
                                                        <option  runat="server">Brush Cut</option>
                                                        <option  runat="server">cut</option>
                                                    </select>
                                
                                                
                                           
                                            
                                            <button runat="server" class="mt-2 btn btn-primary"  onserverclick="addEmpoyee_Clicked" >Register</button>
                                       
                                    </div>
                                
        </div>
        </div>






     
  
        </div>
</asp:Content>
