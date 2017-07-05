<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="MasterPages/MasterPage.master" %>
<%@ MasterType virtualpath="MasterPages/MasterPage.master" %>
<asp:content id="Head" contentplaceholderid="head" runat="server">

</asp:content>
<asp:content id="Body" contentplaceholderid="ContentPlaceHolder1" runat="server">    
    <h1>Welcome</h1>
    <asp:Image ID="MainImage" runat="server" style="height: 16px" />
    <p>Welcome to Rogue, the dungeon RPG, built by Trey Hall</p>
</asp:content>
	        
