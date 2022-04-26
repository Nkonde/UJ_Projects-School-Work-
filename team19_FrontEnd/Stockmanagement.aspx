<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stockmanagement.aspx.cs" Inherits="TYPWebApplication.Stockmanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
                  
                        <div class="row">
                            <div class="col-md-4">
                           
                                <div class="main-card mb-3 card">
            <div class="card-body"><h5 class="card-title">Stock Form</h5>
                                
                                          
                



                    <div class="position-relative form-group"><label for="exampleAddress" class="">Name</label><input name="address" id="name"  runat="server" placeholder="name" type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Description </label><input name="address2" id="description"  runat="server"  placeholder="Description"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Price</label><input name="address3" id="price"  runat="server"  placeholder="Price "  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Stock Price</label><input name="address3" id="StockPrice"  runat="server"  placeholder="Stock Price"  type="text" class="form-control"></div>
                                             <div class="position-relative form-group"><label for="exampleAddress2" class="">Availble Stock</label><input name="address3" id="AvailableStock"  runat="server"  placeholder="Available Stock"  type="text" class="form-control"></div>
                                            <div class="position-relative form-group"><label for="exampleAddress2" class="">Storage Capacity</label><input name="address3" id="Storage"  runat="server"  placeholder="Storage Capacity"  type="text" class="form-control"></div>
                                             
                                             
                                             <div class="col-md-6">
                                                      <div class="position-relative form-group"><label for="examplePassword11" class="">Choose Supplier</label>  
                                                   <input type="text" list="cars" id="supp"  runat="server" name="stylist" class="form-control"/>
                                                         <%--   <datalist id="cars">
                                                              <option>Volvo</option>
                                                              <option>Saab</option>
                                                              <option>Mercedes</option>
                                                              <option>Audi</option>                                                              
                                                            </datalist>--%>
                                                           <section id="Section2" runat="server"></section>

                                                    </div>
                                                  </div>

                                               
                                             <select class="mb-2 form-control-lg form-control" id="input"  runat="server">
                                                  <option value="" disabled selected hidden>on Special?</option>      
                                                 <option  runat="server" value="1">Yes</option>
                                                        <option  runat="server" value="0">No</option>
                                                    </select>

                                        </br>
                                        </br>
                                            <asp:FileUpload ID="FileUpload2" runat="server" />
                                                
                                           
                                            
                                            <button runat="server" class="mt-2 btn btn-primary"  onserverclick="addStock_Clicked" >Add Stock</button>
                                   
                                        
                                        </br>

                                          <asp:Label ID="error" runat="server" Visible="false"></asp:Label>    
                                       
            
              
         
                    </div>
                                    </div>
       
                                
                                </div>
                              








                               <div class="col-md-8">
                                


                              
                                                   <div class="row mt">
          
       
          

          
            <div class="content-panel">
              <section id="emailS" runat="server">
              </section>
            </div>
            <!-- /content-panel -->
  
        </div>                                <%--  <button runat="server" class="mt-2 btn btn-danger" visible="false" id="active" onserverclick="deactivate_Clicked" >Deactivate User</button>  
                                                 <button runat="server" class="mt-2 btn btn-success" visible="false" id="noactive" onserverclick="activate_Clicked" >Activate User</button> 
                                                <button runat="server" class="mt-2 btn btn-primary" onserverclick="search_Clicked"> Search Email</button>--%>
 
                                                  <asp:Label ID="wrong" runat="server" Visible="false"></asp:Label>    
           </br>
             </br>

     
        
        <div class="main-card mb-3 card">
                                   <div class="content-panel">
                      <h4><i class="fa  fa-hand-o-right"></i> Stock </h4>
                      <section id="Active" runat="server">
                      </section>
                      </div>
                               
   </div>

                        
    



                               
                            </div>
                        </div>





                          
</asp:Content>
