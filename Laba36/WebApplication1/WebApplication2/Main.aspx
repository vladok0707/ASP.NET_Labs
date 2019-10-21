<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApplication2.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label Text="X : " runat="server"></asp:Label><br />
            <asp:TextBox ID="numberXTextBox" runat="server"></asp:TextBox><br />
            <asp:Label Text="Y : " runat="server"></asp:Label><br />
            <asp:TextBox ID="numberYTextBox" runat="server"></asp:TextBox><br />
            <asp:Button Text="Add" runat="server" OnClick="OnButtonClickAddition"/><br />
            <asp:Button Text="Sub" runat="server" OnClick="OnButtonClickSubmition"/><br />
            <asp:Button Text="Mult" runat="server" OnClick="OnButtonClickMultiplication"/><br />
            <asp:Label ID="webServiceResul" Text="Результат: " runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
