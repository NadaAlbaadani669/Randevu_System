<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Resete.aspx.cs" Inherits="Randevu_Sistem2.Hasta.Resete" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">Reseteleriniz</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contaner_child_ph" runat="server">
    <div class="vgDiv">
        <h2>Reseteler: </h2>
        <br />
        <asp:GridView ID="RecetGV" runat="server" CssClass="vgCss" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="487px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="DA_gv" HeaderText="Doktor Adi" />
            <asp:BoundField DataField="RT_gv" HeaderText="Randevu Tarihi" />
            <asp:BoundField DataField="R_gv" HeaderText="Resete" />
        </Columns>
        <EmptyDataTemplate>Reseteniz Yoktur !!</EmptyDataTemplate>
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
