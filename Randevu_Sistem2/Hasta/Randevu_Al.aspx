<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Randevu_Al.aspx.cs" Inherits="Randevu_Sistem2.Hasta.Randevu_Al" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">Randevu Al</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="contaner_child_ph" runat="server">
    <div class="RA">
        <h2>Randevu Yapma:</h2>
        <br />
        <div class="input-group">
            <label class="label">Randevu almak istediğiniz bölüm: </label>
            <div class="rs-select2 js-select-simple select--no-search">
                <asp:DropDownList ID="birim_drp" CssClass="dropdl" runat="server" AutoPostBack="True" OnSelectedIndexChanged="birim_drp_SelectedIndexChanged"></asp:DropDownList>                
            </div>
         </div>
         <br /> 
        <div class="input-group">
            <label class="label">Randevu almak istediğiniz doktor: </label>
            <div class="rs-select2 js-select-simple select--no-search">  
                <asp:DropDownList ID="doktor_drp" CssClass="dropdl" runat="server"></asp:DropDownList>
                
            </div>
          </div>               
          <br />          
         <div class="input-group">
            <label class="label">Randevu Tarihi</label>
            <div class="input-group-icon">
                <input class="txtbox RAtxt" type="text" name="RTarih" id="RTarih_txt" runat="server">
                <i class="zmdi zmdi-calendar-note input-icon js-btn-calendar"></i>
            </div>
        </div>
        <br />
        <div class="input-group">
            <label class="label">Randevu Saati</label>
            <div class="input-group-icon">
                <input class="txtbox RAtxt" type="text" name="RSaat" id="RSaat_txt" runat="server">
                <i class="zmdi zmdi-clock-note input-icon js-btn-clock"></i>
            </div>
        </div>                                  
         <br /><br />          
        <div class="p-t-15">
            <asp:Button CssClass="button" ID="RandevuAl_btn" runat="server" Text="Randevu Al" OnClick="RandevuAl_btn_Click"/>
        </div>
        <br /><br />      
        <asp:Label ID="massege" runat="server" Text=""></asp:Label>
    </div>
    
           
</asp:Content>
