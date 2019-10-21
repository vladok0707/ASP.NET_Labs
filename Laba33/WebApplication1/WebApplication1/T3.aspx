<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T3.aspx.cs" Inherits="WebApplication1.T3" %>
<%@ OutputCache Duration="3" VaryByParam="P1;P2" %>
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
