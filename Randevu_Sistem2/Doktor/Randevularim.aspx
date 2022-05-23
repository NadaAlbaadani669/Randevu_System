<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="Randevularim.aspx.cs" Inherits="Randevu_Sistem2.Doktor.Randevularim" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">
    Randevularim
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="contaner_child_ph" runat="server">

    <div class="vgDiv">
        <h2>Randevularim: </h2>
        <br />
        <asp:GridView ID="GridViewRandevular" CssClass="vgCss" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Height="87px" Width="473px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>          
            <asp:BoundField HeaderText="Hasta Adi" DataField="HastaAdi_VG" />
            <asp:BoundField HeaderText="Randevu Saati" DataField="RandevuSaati_VG" />
        </Columns>
        <EmptyDataTemplate>Bugun Hastalariniz Yok Iyi Tatiller</EmptyDataTemplate> 
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
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
  
</asp:Content>
