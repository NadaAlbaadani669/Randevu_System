<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HesapOlusturma.aspx.cs" Inherits="Randevu_Sistem2.HesapOlusturma.HesapOlusturma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Colorlib Templates">
    <meta name="author" content="Colorlib">
    <meta name="keywords" content="Colorlib Templates">

    <!-- Title Page-->
    <title>Hesap Olustur</title>
    <link rel="icon" href="Design/Master_Page/img/favicon.ico" /> 

    <!-- Icons font CSS-->
    <link href="/Design/Log-Sign-Forget/vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">
    <link href="/Design/Log-Sign-Forget/vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">

    <!-- Vendor CSS-->
    <link href="/Design/Log-Sign-Forget/vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="/Design/Log-Sign-Forget/vendor/datepicker/daterangepicker.css" rel="stylesheet" media="all">

    <!-- Main CSS-->
    <link href="/Design/Log-Sign-Forget/css/main.css" rel="stylesheet" media="all">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="page-wrapper bg-gra-02 p-t-130 p-b-100 font-poppins">
        <div class="wrapper wrapper--w680">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Hesap Olustur</h2>                    
                    <asp:Label ID="warning_lbl" runat="server" Text="" Font-Size="Larger"></asp:Label>
                   
                    <form method="POST">

                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Ad</label>
                                    <asp:TextBox ID="Text1" CssClass="input--style-4" runat="server"></asp:TextBox>  
                                     
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Soyad</label>
                                    <asp:TextBox ID="soyad_txt" CssClass="input--style-4" runat="server"></asp:TextBox>                                   
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Dogum Tarih</label>
                                    <div class="input-group-icon">                                        
                                        <asp:TextBox ID="dob_txt" CssClass="input--style-4 js-datepicker" runat="server"></asp:TextBox>
                                        <i class="zmdi zmdi-calendar-note input-icon js-btn-calendar"></i>
                                    </div>
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Cinsyet</label>
                                    <div class="p-t-10">

                                        <label class="radio-container m-r-45">Bay
                                            
                                            <input type="radio" name="gender" id="bay_rd"  runat="server">
                                            <span class="checkmark"></span>
                                        </label>
                                        <label class="radio-container">Bayan
                                            <input type="radio" name="gender" id="bayan_rd" runat="server">
                                            <span class="checkmark"></span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Email</label>
                                    <asp:TextBox ID="email_txt" CssClass="input--style-4" runat="server"></asp:TextBox>
                                    
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Telefon Numarasi</label>
                                    <asp:TextBox ID="telefon_txt" CssClass="input--style-4" runat="server"></asp:TextBox>
                                    
                                </div>
                            </div>
                        </div>

                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">TC</label>                                   
                                    <asp:TextBox ID="tc_txt" CssClass="input--style-4" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        
                        </div>

                        <div class="row row-space">
                        <div class="col-2">
                            <div class="input-group">
                                <label class="label">Sifre</label>
                                
                                <asp:TextBox ID="pass_txt" CssClass="input--style-4" TextMode="Password" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-2">
                            <div class="input-group">
                                <label class="label">Tekrar Sifre</label>
                                
                                <asp:TextBox ID="passAg_txt" CssClass="input--style-4" TextMode="Password" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                       
                        <div class="p-t-15">
                            <asp:Button CssClass="btn btn--radius-2 btn--blue" ID="olustur_btn" runat="server" Text="Olustur" OnClick="olustur_btn_Click" />
<%--                            <button class="btn btn--radius-2 btn--blue" type="submit" id="gonder_btn" runat="server" onclick="gonderBtn_onclick">Submit</button>--%>
                        </div>
                         <div class="aherf" style="margin-top:20px;text-align:center">                            
                            <a id="log_in" runat="server" href="Login.aspx" style="font-size:1.3em">Hesabim Var</a>
                        </div>

                    </form>
                </div>
            </div>
        </div>
    </div>
        </div>
    </form>

      <!-- Jquery JS-->
    <script src="/Design/Log-Sign-Forget/vendor/jquery/jquery.min.js"></script>
    <!-- Vendor JS-->
    <script src="/Design/Log-Sign-Forget/vendor/select2/select2.min.js"></script>
    <script src="/Design/Log-Sign-Forget/vendor/datepicker/moment.min.js"></script>
    <script src="/Design/Log-Sign-Forget/vendor/datepicker/daterangepicker.js"></script>

    <!-- Main JS-->
    <script src="/Design/Log-Sign-Forget/js/global.js"></script>

</body>
</html>
