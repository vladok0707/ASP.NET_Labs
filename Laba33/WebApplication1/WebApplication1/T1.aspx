<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T1.aspx.cs" Inherits="WebApplication1.T1" %>
<%@ OutputCache Duration="7" VaryByParam="None" %>
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
            <asp:Substitution ID="Sx1" runat="server" MethodName="GetDate" />
        </div>
    </form>
</body>
</html>
