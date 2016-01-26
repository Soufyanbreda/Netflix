<%@ Page Title="Beheerscherm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adminscherm.aspx.cs" Inherits="Netflix_SoufyanBargach.Pages.Adminscherm" %>

    

 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Beheerscherm</h1>
   
        <div style="text-align: center;">
        <asp:Button Text="Films" BorderStyle="None" ID="Tab1" CssClass="Initial" runat="server"
              OnClick="Tab1_Click" />
            
          <asp:Button Text="Series" BorderStyle="None" ID="Tab2" CssClass="Initial" runat="server"
              OnClick="Tab2_Click" />
           </div>
          <asp:MultiView ID="MainView" runat="server">
            <asp:View ID="View1" runat="server">
                 <div style="text-align: center;">
                <asp:Panel ID="PanelFilms" runat="server" Visible="False" Width="431px" Height="399px">
                    <h2>Films  </h2>
                    <asp:ListBox ID="lbFilms" autopostback="true" runat="server" Height="168px" Width="190px" OnSelectedIndexChanged="lbFilms_SelectedIndexChanged" ></asp:ListBox>
                    
                    <br />
                    
                   <asp:Button ID="btnDeleteMovie" runat="server" Height="35px"  Text="Film verwijderen" Width="154px" OnClick="btnFilm_Click" />
                    <asp:Button ID="btnChangeNaam" runat="server"  Text="Wijzig Film naam" Width="154px" Height="35px" OnClick="btnChangeNaam_Click" />
                    <br />
                    <asp:Panel ID="PanelUpdate" runat="server" Height="152px" Visible="False" Width="345px">

                        <h4>Wijzig Naam</h4>
                        
                        <asp:TextBox ID="tbNaam" runat="server" AutoCompleteType="Disabled" Height="55px" Width="130px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btnBevestig" runat="server"  Text="Bevestig" Width="94px" OnClick="btnBevestig_Click" />
                    </asp:Panel>
                    <br />
                </asp:Panel>
                 </div>
            </asp:View>
            <asp:View ID="View2" runat="server">
              
                   <div style="text-align: center;">
              <asp:Panel ID="PanelSerie" runat="server" Visible="False" Width="431px" Height="399px">
                  <h3>Series </h3>
                            <asp:ListBox ID="lbSerie" runat="server" Height="163px" Width="197px"></asp:ListBox>
                            <br />
                            <asp:Button ID="btnSerieVerwijderen" runat="server" Text="Serie Verwijderen" Width="158px" OnClick="btnSerieVerwijderen_Click" />
                      
                        </asp:Panel>
                        </div>
                  </asp:View>
            
          </asp:MultiView>
    
         </asp:Content>


      
    
     
           
  
       
      

