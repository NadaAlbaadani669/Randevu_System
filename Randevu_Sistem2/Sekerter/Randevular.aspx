<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Randevular.aspx.cs" Inherits="Randevu_Sistem2.Randevular" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">Randevular</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contaner_child_ph" runat="server">

    <div class="vgDiv">
        <h2>Randevular: </h2>
        <asp:GridView ID="GridViewRandevularSekerter" CssClass="vgCss" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="HastaAdi_GV" HeaderText="Hasta Adi" />
            <asp:BoundField DataField="DoktorAdi_GV" HeaderText="Doktor Adi" />
            <asp:BoundField DataField="RS_VG" HeaderText="Randevu Saati" />
        </Columns>
        <EmptyDataTemplate>Bugun randevular yoktur </EmptyDataTemplate>
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
