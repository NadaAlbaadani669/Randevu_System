<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sifre_Unuttum.aspx.cs" Inherits="Randevu_Sistem2.Sifre_unuttum.Sifre_Unuttum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags-->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Colorlib Templates">
    <meta name="author" content="Colorlib">
    <meta name="keywords" content="Colorlib Templates">

    <!-- Title Page-->
    <title>Sifre Unuttum</title>
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
        <div class="page-wrapper bg-gra-02 p-t-130 p-b-100 font-poppins">
        <div class="wrapper wrapper--w680">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Sifre Unuttum</h2>

                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <form method="POST">
                         <div class="input-group">
                            <label class="label">Kullanci Turu</label>
                            <div class="rs-select2 js-select-simple select--no-search">
                                <select name="Yetki" id="turu_drp" runat="server">
                                    <option disabled="disabled" selected="selected">Kullanci Turu Seciniz</option>
                                    <option value="Doktor">Doktor</option>
                                    <option value="Hasta">Hasta</option>
                                    <option value="Sekreter">Sekreter</option>
                                </select>
                                <div class="select-dropdown"></div>
                            </div>
                        </div>
                        
                            <div class="p-t-15">
                                <div class="input-group">
                                    <label class="label">TC</label>
                                    <input class="input--style-4" type="text" name="TC" id="tc_txt" runat="server">
                                </div>
                            </div>                        
                        
                       
                        
                            <div class="p-t-15">
                                <div class="input-group">
                                    <label class="label">Email</label>
                                    <input class="input--style-4" type="email" name="email" id="email_txt" runat="server">
                                </div>
                            </div>
                           
                        
                       
                        <div class="p-t-15">
                            <asp:Button CssClass="btn btn--radius-2 btn--blue" ID="Sifre_goster" runat="server" Text="Sifre Goster" OnClick="Sifre_goster_Click" />
                           
                        </div>
                        
                         
                    </form>
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
