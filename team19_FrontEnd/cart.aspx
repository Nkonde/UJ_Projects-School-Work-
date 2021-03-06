<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="TYPWebApplication.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
             body {
                color: #000;
                overflow-x: hidden;
                height: 100%;
                background-color: #fff;
                background-repeat: no-repeat
            }

            .plus-minus {
                position: relative
            }

            .plus {
                position: absolute;
                top: -4px;
                left: 2px;
                cursor: pointer
            }

            .minus {
                position: absolute;
                top: 8px;
                left: 5px;
                cursor: pointer
            }

            .vsm-text:hover {
                color: #FF5252
            }
        
            .book,
            .book-img {
                width: 120px;
                height: 180px;
                border-radius: 5px
            }

            .book {
                margin: 20px 15px 5px 15px
            }

            .border-top {
                border-top: 1px solid #EEEEEE !important;
                margin-top: 20px;
                padding-top: 15px
            }

          /*  .card {
                margin: 40px 0px;
                padding: 40px 50px;
                border-radius: 20px;
                border: none;
                box-shadow: 1px 5px 10px 1px rgba(0, 0, 0, 0.2)
            }
*/
            input,
            textarea {
                background-color: #F3E5F5;
                padding: 8px 15px 8px 15px;
                width: 100%;
                border-radius: 5px !important;
                box-sizing: border-box;
                border: 1px solid #F3E5F5;
                font-size: 15px !important;
                color: #000 !important;
                font-weight: 300
            }

            input:focus,
            textarea:focus {
                -moz-box-shadow: none !important;
                -webkit-box-shadow: none !important;
                box-shadow: none !important;
                border: 1px solid #9FA8DA;
                outline-width: 0;
                font-weight: 400
            }

            button:focus {
                -moz-box-shadow: none !important;
                -webkit-box-shadow: none !important;
                box-shadow: none !important;
                outline-width: 0
            }

            .pay {
                width: 80px;
                height: 40px;
                border-radius: 5px;
                border: 1px solid #673AB7;
                margin: 10px 20px 10px 0px;
                cursor: pointer;
                box-shadow: 1px 5px 10px 1px rgba(0, 0, 0, 0.2)
            }

            .gray {
                -webkit-filter: grayscale(100%);
                -moz-filter: grayscale(100%);
                -o-filter: grayscale(100%);
                -ms-filter: grayscale(100%);
                filter: grayscale(100%);
                color: #E0E0E0
            }

            .gray .pay {
                box-shadow: none
            }

            #tax {
                border-top: 1px lightgray solid;
                margin-top: 10px;
                padding-top: 10px
            }

            .btn-blue {
                border: none;
                border-radius: 10px;
                background-color: #673AB7;
                color: #fff;
                padding: 8px 15px;
                margin: 20px 0px;
                cursor: pointer
            }

            .btn-blue:hover {
                background-color: #311B92;
                color: #fff
            }

            #checkout {
                float: left
            }

            #check-amt {
                float: right
            }

            @media screen and (max-width: 768px) {

                .book,
                .book-img {
                    width: 100px;
                    height: 150px
                }

                .card {
                    padding-left: 15px;
                    padding-right: 15px
                }

                .mob-text {
                    font-size: 13px
                }

                .pad-left {
                    padding-left: 20px
               
            }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <div class="container px-4 py-5 mx-auto">
                            <div class="row d-flex justify-content-center">
                                <div class="col-5">
                                    <h4 class="heading">Shopping Cart</h4>
                                </div>


                                <div class="col-7">
                                    <div class="row text-right">

                                        <div class="col-4">
                                            <h6 class="mt-2">Price</h6>
                                        </div>

                                        <div class="col-4">
                                            <h6 class="mt-2">Quantity</h6>
                                        </div>

                                        <div class="col-4">
                                            <h6 class="mt-2">Total Price</h6>
                                        </div>
                                    </div>
                                </div>
                            </div>

                             <section id="treport" runat="server"></section>   
                        </div>

                                         <div class="form-row">
                                               <div class="col-md-6">
                                                    <div class="position-relative form-group"><label for="examplePassword11" class="">Total Amount</label>    
                                                    <input name="phone" id="amount" placeholder="Amount" runat="server" type="" class="form-control" readonly>
                                                    </div>
                                                </div>
                                            </div>

                         <section id="Section1" runat="server"></section>
                 
                                              <%-- <div class="form-row">
                                                    <div class="container-login100-form-btn">
						                              <a class="mt-2 btn btn-primary" type="submit" href="Checkout.aspx"  runat="server">
						                    	        Checkout
						                              </a>
                                                         <asp:Label ID="lblStatus" runat="server"></asp:Label>
					                                </div>
                                                </div>--%>



                                        


</asp:Content>
