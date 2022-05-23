<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Raporlar.aspx.cs" Inherits="Randevu_Sistem2.Hasta.Raporlar" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">Raporlarinin</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contaner_child_ph" runat="server">

    <div class="vgDiv">
        <h2>Raporlarim: </h2>
        <br />
        <asp:GridView ID="RaporGV" runat="server" CssClass="vgCss" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="484px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="DA_gv" HeaderText="Doktor Adi" />
            <asp:BoundField DataField="RT_gv" HeaderText="Randevu Tarihi" />
            <asp:BoundField DataField="DT_vg" HeaderText="Doktor Tashisi" />
        </Columns>
        <EmptyDataTemplate>Raporlariniz Yoktur Hastane daha once gelmediniz</EmptyDataTemplate>
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
