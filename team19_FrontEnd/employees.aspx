<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="employees.aspx.cs" Inherits="TYPWebApplication.employees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

                      <div class="position-relative form-group"><label for="exampleEmail" class="">Email</label><input name="email"  placeholder="with a placeholder" runat="server" id="search" type="email" class="form-control"></div>
                                                  
          
                    
          

          
            <div class="content-panel">
              <section id="emailS" runat="server">
              </section>
            </div>
            <!-- /content-panel -->
       
                              
         <button runat="server"  class="mt-2 btn btn-danger" visible="false" id="active" onserverclick="deactivate_Clicked" >Deactivate User</button>  
                                                 <button runat="server" class="mt-2 btn btn-success" visible="false" id="noactive" onserverclick="activate_Clicked" >Activate User</button> 
                                                <button runat="server" class="mt-2 btn btn-primary" onserverclick="search_Clicked"> Search Email</button>
 
                                                  <asp:Label ID="wrong" runat="server" Visible="false"></asp:Label>    
           </br>
             </br>
                 
       
                  
                        <div class="row">

                            <div class="col-md-6">

                               
                                <div class="main-card mb-3 card">
            <div class="card-body"><h5 class="card-title">Employee Form</h5>
                                
                                            <div class="form-row">
                                                <div class="col-lg-6">
                                                    <div  class="position-relative form-group"><label for="Email" class="">Email</label><input name="email"  runat="server" id="email" placeholder="email" type="email" class="form-control"></div>
                                                </div>
                                                  <div class="col-lg-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Confirm Email</label><input name="password"  runat="server" id="cemail"  placeholder="Conform Email" type="email"
                                                                                                                                                             class="form-control"></div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Password</label><input name="password"  runat="server" id="password"  placeholder="password" type="password"
                                                                                                                                                             class="form-control"></div>
                                                </div>
                                                 <div class="col-md-6">
                                                       <div class="position-relative form-group"><label for="exampleAddress" class="">Name</label><input name="address" id="name"  runat="server" placeholder="name" type="text" class="form-control"></div>
                                                     </div>
                                                   <div class="col-md-6">
                                                        <div class="position-relative form-group"><label for="exampleAddress2" class="">Surname </label><input name="address2" id="surname"  runat="server"  placeholder="surname"  type="text" class="form-control"></div>
                                                       </div>
                                                 <div class="col-md-6">
                                                        <div class="position-relative form-group"><label for="exampleAddress2" class="">Cellphone</label><input name="address3" id="phone"  runat="server"  placeholder="Cellphone"  type="text" class="form-control">
                                            </div>
                                                     </div>
                                            </div>

                                              
                                                    <%--<input type="text" runat="server" list="cars" id="stycheck" name="fname"class="form-control"/>--%>
                                          
                                              
                                             
                                            
                                            <%-- <select class="mb-2 form-control-lg form-control" id="Select1"  runat="server">
                                                        <option value="employee">Employee</option>
                                                        <option value="supplier">Supplier</option>
                                             </select>--%>
                                         
                                              
                                             <select class="mb-2 form-control-lg form-control" id="input"  runat="server">
                                                        <option value="employee">Employee</option>
                                                        <option value="supplier">Supplier</option>
                                             </select>
                                                    
                                
                                                
                                           
                                            
                                            <button runat="server" class="mt-2 btn btn-primary"  onserverclick="addEmpoyee_Clicked" >Register</button>
                                   
                                        
                                        </br>

                                          <asp:Label ID="error" runat="server" Visible="false"></asp:Label>      
                                       
            
              
         
                    </div>
                                    </div>
       
                                </div>
                              








                               <div class="col-md-6">
                                


                                

     
        
        <div class="main-card mb-3 card">
          <div class="col-lg-12">
            <div class="content-panel">
              <h4> Employee</h4>
              <section id="employeess" runat="server">
              </section>
            </div>
          </div>
   </div>

                        
    



                               
                            </div>
                        </div>





                          
                            </div>


                         
                   
                       </div>   
</asp:Content>
