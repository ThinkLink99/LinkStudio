<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Managers_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header>
        <nav>
            <ul>
                <li><a href = "Updates.aspx">Launcher Updates</a></li>
            </ul>
        </nav>
    </header>
    <h1>Manager Portal</h1>
    <p>
        Managers can add/remove/edit blog posts, edit the updates page for the launcher, and moderate forums
    </p>
</asp:Content>

