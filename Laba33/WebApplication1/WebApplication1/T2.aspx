﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T2.aspx.cs" Inherits="WebApplication1.T2" %>
<%@ OutputCache Duration="7" VaryByParam="P1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
			<br />
			<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
