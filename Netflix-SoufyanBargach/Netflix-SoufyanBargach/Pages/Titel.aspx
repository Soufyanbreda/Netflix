<%@ Page Title="Titels" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Titel.aspx.cs" Inherits="Netflix_SoufyanBargach.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/Site.css" rel="stylesheet" />
    <h6>Titels</h6>
    <asp:Label ID="lblzoek" runat="server" Text="Zoek op titel"></asp:Label><asp:TextBox ID="tbZoek" runat="server"></asp:TextBox><asp:Button ID="btnzoek" runat="server" Text="Zoek!" OnClick="Zoek" />
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <video controls autoplay id="Videocontrol" visible="false" runat="server">
                <source src="../Movies/video1.mp4" type="video/mp4">
                 </video>
            <video controls autoplay id="Videocontrol2" visible="false" runat="server">
                <source src="../Movies/video2.mp4" type="video/mp4">
                 </video>
           
            <div id="vids">
                 <h3>Avontuur</h3>
                <asp:ImageButton ID="Imagebutton1" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/Deadpool.jpg" Height="124px" Width="245px" />
                 <asp:ImageButton ID="ImageButton2" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/battle-of-five-armes.jpg" Width="255px" Height="119px" />
                <asp:ImageButton ID="ImageButton3" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/jamesbond.jpg" Width="218px" Height="119px" />
                <asp:ImageButton ID="ImageButton4" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/Ghost_rider.jpg" Width="202px" Height="125px" />
                 </div>
               <div id="vids2">
                 <h3>Aktie</h3>
                <asp:ImageButton ID="Imagebutton5" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/disney.jpg" Height="124px" Width="245px" />
                 <asp:ImageButton ID="ImageButton6" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/thor.jpg" Width="255px" Height="119px" />
                <asp:ImageButton ID="ImageButton7" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/brave-Preview.jpg" Width="218px" Height="119px" />
                <asp:ImageButton ID="ImageButton8" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/battle-of-five-armes.jpg" Width="202px" Height="125px" />
                 </div>
            <div id="vids3">
                 <h3>Comedy</h3>
                <asp:ImageButton ID="Imagebutton9" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/comedy1.jpg" Height="124px" Width="245px" />
                 <asp:ImageButton ID="ImageButton10" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/comedy2.jpg" Width="255px" Height="119px" />
                <asp:ImageButton ID="ImageButton11" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/comedy3.jpg" Width="218px" Height="119px" />
                <asp:ImageButton ID="ImageButton12" runat="server" onclick="ChangeVid" CssClass="vid" ImageUrl="../Images/disney.jpg" Width="202px" Height="125px" />
                 </div>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
