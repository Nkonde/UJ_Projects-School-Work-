<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateAppointment.aspx.cs" Inherits="TYPWebApplication.UpdateAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                      <div class="tab-content">
                            <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
                                <div class="main-card mb-3 card">
                                    <div class="card-body">
                                        <h1 class="card-title">Update Appointment Info</h1>

                                               <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Date</label>    
                                                    <input name="email" id="date" placeholder="Date" runat="server" type="date" class="form-control" />
                                                    </div>
                                                </div>
                                            </div>
<%--                                         <section id="treport" runat="server"></section>--%>
                                         
                                             <div class="form-row">
                                               <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Time</label>    
                                                    <input name="phone" id="time" placeholder="Time" runat="server" type="time" class="form-control">
                                                    </div>
                                                </div>
                                            </div>

                                          <div class="form-row">
                                                 <div class="col-md-6">
                                                     <label for="fname"></label>
                                                    <input type="text" id="fname" runat="server" name="fname" class="form-control">
                                                    </div>
                                             </div>


                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="container-login100-form-btn">
						                              <button class="mt-2 btn btn-primary" type="submit" onserverclick="Book_Clicked" runat="server">
						                    	        Update
						                              </button>
                                                         <asp:Label ID="lblStatus" runat="server"></asp:Label>
					                                </div>
                                                </div>
                                               </div>
                                            </div>
        
                                    
                                </div>
                            </div>
                        </div>
                    </div>
         

</asp:Content>
