<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="notification.aspx.cs" Inherits="TYPWebApplication.notification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row>"
                   <div class="col-md-6">
                                        <div class="main-card mb-3 card">
                                            <div class="card-body"><h5 class="card-title">Pending Stock</h5>
                                                <ul class="list-group" runat="server" id="notifications">
                                                 
                                                    </ul>
                                            </div>
                                        </div>
                                    </div>
                               
                           </div>
                           
                       
                    
     
                
                       </div>   
                    

 <%-- <div class="modal fade bd-example-modal-sm" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-sm">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle">Modal title</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <p>Are you Sure you want add new Stock?</p>
                  
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                <button type="button" runat="server" onserverclick="verify_Clicked" class="btn btn-primary">Confirm Stock</button>
            </div>
        </div>
    </div>
</div>--%>










  </div>
              </div>

                   
        </div>
</asp:Content>
