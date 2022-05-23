<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="ziyaretler.aspx.cs" Inherits="Randevu_Sistem2.Hasta.Gesmisim" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">Ziyaretleriniz</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contaner_child_ph" runat="server">
   
    <div class="vgDiv">
        <h2> Ziyaretleriniz: </h2>
        <br />
        <asp:GridView ID="zGV" CssClass="vgCss" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="da_gv" HeaderText="Doktor Adi" />
                <asp:BoundField DataField="rt_vg" HeaderText="Randevu Tarihi " />
            </Columns>
        </asp:GridView>
    </div>
    
</asp:Content>
