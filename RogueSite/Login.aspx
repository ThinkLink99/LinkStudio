<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="~/MasterPages/MasterPage.master" %>
<%@ MasterType virtualpath="MasterPages/MasterPage.master" %>


<asp:content id="Head" contentplaceholderid="head" runat="server">

</asp:content>
<asp:content id="Body" contentplaceholderid="ContentPlaceHolder1" runat="server">
    <h1>Login:</h1>
            <p>
                Username: <input id="Username" runat="server" type="text"/><br />
                Password: <input id="Password" runat="server" type="password"/><br />

                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Label id="ErrorLabel" runat="Server" ForeColor="Red" Visible="false"/> <br />
                
                Don't have an account? <a href = "register.aspx">Click Here!</a>          
            </p> 
</asp:content>