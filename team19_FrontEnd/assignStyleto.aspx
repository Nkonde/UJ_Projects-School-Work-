<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="assignStyleto.aspx.cs" Inherits="TYPWebApplication.assignStyleto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                                          
  
                                    <div class="card-body"><h5 class="card-title">Select Style to Assign</h5>
                                     

                                              <div class="card-body"><h5 class="card-title" runat="server" id="inputas">Sizing</h5>
                                                      <div class='divider'></div>
                                                    
                                            </div>   
 
                                             
                                 
                                        <div class="DivButton"><button id="btnstyl" class="mb-2 mr-2 btn btn-primary btn-lg btn-block" visible="true" onserverclick="assign_Clicked" runat="server">Assign Style</button></div>
                                        <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                       
                                          
                                        

                             


                                       
                                      
                                        
              
    
    

</asp:Content>
