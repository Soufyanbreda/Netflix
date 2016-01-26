<%@ Page Title="Registreer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registreer.aspx.cs" Inherits="Netflix_SoufyanBargach.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <h2>Maak een Account op Netflix </h2>
    <div style="text-align: center;" id="Register">
        <h5>Vul hier je gebruikersnaam in</h5>
     <asp:TextBox ID="tbUsername" runat="server" />
    <h5>Vul hier je wachtwoord in</h5>
    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" />
        <h5>Vul hier je geslacht in</h5>
          <asp:TextBox ID="tbGender" runat="server"></asp:TextBox>
         <h5>Vul hier je voornaam in </h5>
        <asp:TextBox ID="tbFirstname" runat="server"></asp:TextBox>
       <h5>Vul hier je achternaam in</h5>
        <asp:TextBox ID="tbLastname" runat="server"></asp:TextBox>
       
     
        <br />
        <br />
       
     
      <asp:Button ID="btnRegistreer" runat="server" Height="28px" OnClick="btnRegistreer_Click" Text="Registreer" Width="96px" />
        <br />
        </div>
</asp:Content>
