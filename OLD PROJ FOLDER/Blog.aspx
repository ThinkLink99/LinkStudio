<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Blog.aspx.cs" Inherits="Blog" MasterPageFile="MasterPages/MasterPage.master" %>

<%@ Register Src="~/Controls/BlogUpdates.ascx" TagPrefix="uc1" TagName="BlogUpdates" %>


<asp:content id="Head" contentplaceholderid="head" runat="server">

</asp:content>
<asp:content id="Body" contentplaceholderid="ContentPlaceHolder1" runat="server">
    <uc1:BlogUpdates runat="server" ID="BlogUpdates" />
</asp:content>
