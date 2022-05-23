<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Ana Sayfa.aspx.cs" Inherits="Randevu_Sistem2.Hasta.Ana_Sayfa" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">
    Ana Sayfa
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="contaner_child_ph" runat="server">

    <div class="vgDiv">
        <h2> Gelecek Randevulariniz </h2>
        <br />
        <br />
        <asp:GridView ID="RandevuVG" runat="server" CssClass="vgCss" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="da_vg" HeaderText="Doktor Adi" />
                <asp:BoundField DataField="rt_vg" HeaderText="Randevu Tarihi" />
                <asp:BoundField DataField="rs_vg" HeaderText="Randevu Saati" />
            </Columns>
            <EmptyDataTemplate>Gelecek Randevunuz Yok Randevu Almak Icin Randevu Al sayfasini Gecin</EmptyDataTemplate> 
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
   
</asp:Content>
