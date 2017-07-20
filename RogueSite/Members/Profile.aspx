<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="MemberPages_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Side" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1><asp:Label ID="lblWelcome" runat="server" Text="Welcome, User!"></asp:Label></h1>
    <h2><a href="Download.aspx">Download Here</a></h2>

    <asp:Image ID="Image1" runat="server" Height="144px" Width="144px" />
</asp:Content>


