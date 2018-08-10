<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CSharpOTH.aspx.cs" Inherits="LinkStudio.CSharpOTH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="ProductPage.css" rel="stylesheet" />
    <div id="ProductInfo">
        <h4>About CSharp on the Hill</h4>
        <p>
            C# on the Hill is a PC adaptation of Avalon Hill's Board game 'Betrayal at House on the Hill'.
        </p>
        <br />
        <h4>Backstory on the boardgame</h4>
        <p>
            The popular board game plays out a scenario in which 3 - 6 players are exploring an abandonded house, until one of them turns on the rest, unleashing one of many B-List horror movie monsters into the house. <br />
            The game has a variety of campaigns, or haunts as they are called in game, to play through, and the house is built by drawing tiles each turn, thus making this game as replayable as your heart's content.
        </p>
        <br />
        <h4>Goal of the project</h4>
        <p>
            The goal of this project is to capture the essence of the gameplay. The complexity of the game makes this project so interesting from a programming perspective. 
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
