<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="TashisEkleme.aspx.cs" Inherits="Randevu_Sistem2.Doktor.TashisEkleme" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">
    Tashis Ekleme
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="contaner_child_ph" runat="server">
    <div class="TE">
        <h2>Tashis Ekleme:</h2>        
        <br /><br />
        <div class="input-group">
            <label class="label">Teşhis koymak istediğiniz hastayı seçin: </label>
            <div class="rs-select2 js-select-simple select--no-search">
                <asp:DropDownList  ID="hasta_drp" CssClass="dropdl" runat="server" AutoPostBack="True" OnSelectedIndexChanged="hasta_drp_SelectedIndexChanged"></asp:DropDownList>                
            </div>
        </div>                         
        <br />          
        <div class="input-group">
            <label class="label">Tashis: </label>
            <div class="input-group-icon">
                <asp:TextBox ID="tashis_txt" CssClass="txtbox" runat="server" Height="107px" Width="278px"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="input-group">
            <label class="label">Resete</label>
            <div class="input-group-icon">
                <asp:CheckBox ID="tashis_cbx" Text="Hastanın ilaca ihtiyacı var mı ?" runat="server" AutoPostBack="True" OnCheckedChanged="tashis_cbx_CheckedChanged"></asp:CheckBox>
                <br /><br />
                <asp:Panel ID="pnlResete" runat="server" Visible="False">
                    Resete :<br /> &nbsp;<asp:TextBox ID="resete_txt" CssClass="txtbox" runat="server" Height="107px" Width="278px"></asp:TextBox>
                </asp:Panel>
            </div>
        </div>     
        <br /> <br /> <br />            
        <div class="p-t-15">
            <asp:Button CssClass="button" ID="tashis_btn" runat="server" Text="Tashis Ekle" OnClick="tashis_btn_Click"/>
        </div>
           
        <asp:Label ID="massege" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
