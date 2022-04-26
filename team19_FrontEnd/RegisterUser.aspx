<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="TYPWebApplication.RegisterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


                         <div class="tab-content">
                            <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
                                <div class="main-card mb-3 card">
                                    <div class="card-body"><h1 class="card-title">Register Account</h1>
                                     

                                         <div class="form-row">
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Name</label>    
                                                    <input name="phone" id="name" placeholder="Name" runat="server" type="text" class="form-control">
                                                    </div>
                                                </div>

                                             <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Surname</label>    
                                                    <input name="phone" id="surname" placeholder="Surname" runat="server" type="text" class="form-control">
                                                    </div>
                                                </div>
                                             </div>

                                          
                                                 

                                            <div class="form-row">
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Phone Number</label>    
                                                    <input name="phone" id="phone" placeholder="Phone number" runat="server" type="text" class="form-control">
                                                    </div>
                                                </div>
                                                
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Email</label>    
                                                    <input name="email" id="email" placeholder="Email" runat="server" type="text" class="form-control">
                                                    </div>
                                                </div>
                                             </div>

                                        <div class="form-row">
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Password</label>    
                                                    <input name="password" id="password" placeholder="password" runat="server" type="password" class="form-control">
                                                    </div>
                                                </div>
                                                
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Confirm Password</label>    
                                                    <input name="Confirm" id="Confirm" placeholder="Confirm Password" runat="server" type="password" class="form-control">
                                                    </div>
                                                </div>
                                             </div>

                                        <div class="form-row">
                                                 <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Address</label>    
                                                    <input name="address" id="address" placeholder="Address" runat="server" type="address" class="form-control">
                                                    </div>
                                                </div>
                                            <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Gender</label>    
                                                    <input name="address" id="gender" placeholder="Gender" runat="server" type="text" class="form-control">
                                                    </div>
                                                </div>
                                             </div>
                                          <div class="form-row">
                                                 <div class="col-md-6">
                                                      <button class="mt-2 btn btn-primary" type="submit" onserverclick="Book_Clicked" runat="server">
						                    	        Register
						                              </button>
                                                         <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                                </div>
                                          </div>
                                            
                                </div>
                            </div>
                        </div>
                     </div>

</asp:Content>
