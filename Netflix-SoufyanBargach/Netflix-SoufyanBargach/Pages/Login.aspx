<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Netflix_SoufyanBargach.Pages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
    <asp:Literal ID="Literal1" runat="server" /><br/>
        <h6>Log hier in!</h6>
        <div style="text-align: center;">
            Gebruikersnaam: <asp:TextBox ID="tbUsername" runat="server" /><br />
            Wachtwoord:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="tbPassword" runat="server" /><br />
    <asp:Button ID="Login" runat="server"  Text="Log In" OnClick="Login_Click" />
            </div>
</div>

</asp:Content>
