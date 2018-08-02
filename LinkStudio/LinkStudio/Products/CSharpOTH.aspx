<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CSharpOTH.aspx.cs" Inherits="LinkStudio.CSharpOTH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="ProductPage.css" rel="stylesheet" />
    <div id="ProductInfo">
        <h4>About CSharp on the Hill</h4>
        <p>
            Cs on the Hill is a PC adaptation of Avalon Hill's Board game 'Betrayal at House on th Hill'.
        </p>
    </div>
    <div id="ProductLink">
        <h4>Product Links</h4>
        <a href ="https://www.github.com/ThinkLink99/CSharpOnTheHill/releases">View 'C# on the hill' on Github </a><br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Products/images/csoth.png" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Side" runat="server">
</asp:Content>
