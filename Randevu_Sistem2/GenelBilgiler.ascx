<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenelBilgiler.ascx.cs" Inherits="Randevu_Sistem2.GenelBilgiler" %>

<div class="child">
    <h2>Bilgileriniz:</h2>      
    <br />
    <br />
    <div class="input-group">
        <label class="label">Adi :  </label>
        <asp:Label ID="ad_txt" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div class="input-group">
        <label class="label">TC NO :  </label>
        <asp:Label ID="tc_txt" runat="server" Text=""></asp:Label>
    </div>   
    <br />    
    <div class="input-group">
        <label class="label">Dogum Gunu :  </label>
        <asp:Label ID="dob_txt" runat="server" Text=""></asp:Label>
    </div>
    <br />    
    <div class="input-group">
        <label class="label">Telefon :  </label>
        <asp:Label ID="tel_txt" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div class="input-group">
        <label class="label">Email :  </label>
        <asp:Label ID="email_txt" runat="server" Text=""></asp:Label>
    </div>
         
    <asp:Label ID="massege" runat="server" Text=""></asp:Label>
   

</div>

