<%@ Page Title="" Language="C#" MasterPageFile="~/Users.Master" AutoEventWireup="true" CodeBehind="GenelBilgileri.aspx.cs" Inherits="Randevu_Sistem2.Sekerter.GenelBilgileri" %>

<%@ Register Src="~/GenelBilgiler.ascx" TagPrefix="uc1" TagName="GenelBilgiler" %>

<asp:Content ID="header" ContentPlaceHolderID="PageTitle" runat="server">Bilgileriniz</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="contaner_child_ph" runat="server">
    <uc1:GenelBilgiler runat="server" ID="GenelBilgiler" />
</asp:Content>
