<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="~/MasterPages/MasterPage.master" %>
<%@ MasterType virtualpath="MasterPages/MasterPage.master" %>


<asp:content id="Head" contentplaceholderid="head" runat="server">

</asp:content>
<asp:content id="Body" contentplaceholderid="ContentPlaceHolder1" runat="server">
    <h1>Login:</h1>
            <p>
                Username: <asp:TextBox ID="txtUser" runat="server"></asp:TextBox> <br />
                Password: <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox> <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> <br />
                Don't have an account? <a href = "register.aspx">Click Here!</a>          
            </p> 
</asp:content>