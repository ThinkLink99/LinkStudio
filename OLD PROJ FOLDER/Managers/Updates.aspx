<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Updates.aspx.cs" Inherits="Updates" %>

<%@ Register Src="~/Controls/BlogUpdates.ascx" TagPrefix="uc1" TagName="BlogUpdates" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/Style/RogueSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Brand New Launcher!</h1>
        <p>

            Welcome to the brand new Launcher For Rouge! This will show all updates, blog posts and other important information before running the game.</p>
        <uc1:BlogUpdates runat="server" ID="BlogUpdates" />
    </div>
    </form>
</body>
</html>
