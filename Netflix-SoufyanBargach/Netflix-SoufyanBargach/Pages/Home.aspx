<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Netflix_SoufyanBargach._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="../Content/Site.css" rel="stylesheet" />
    <asp:ImageButton ID="logo" runat="server"  ImageUrl="../Images/logo.png" Height="124px" Width="245px" />
    <div class="jumbotron">
           <h2>Kijk Altijd en Overal </h2>
        <h3>Series en films</h3>
    </div>
    
    <div class="row">
        <div class="meldjeaan">
            <h6>Meld je aan</h6>
            <p>
                Drama,actie,comedy,series - alles wat je graag kijkt ,
                gepersonaliseerd voor jou
            </p>
            <p>
                
                <asp:Button ID="btnMeldjeaan" CssClass="meldjeaan" href="../Pages/Adminscherm.aspx" runat="server" Height="48px" Text="Meld je aan" Width="127px" OnClick="btnMeldjeaan_Click" />
                
            </p>
        </div>
        <div class="col-md-4">
           
        </div>
        <div class="col-md-4">
           
        </div>
    </div>

    </body>
</asp:Content>
