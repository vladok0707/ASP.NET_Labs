<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="FirstForm.aspx.cs" Inherits="WebApplication2.FirstForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" Width="79px" />
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
            <asp:Button ID="Button2" runat="server" Text="INFO" onClick="Button2_Click" Width="79px" />
            <br />
             <asp:Label ID="label2" runat="server" Text=""></asp:Label>
            <br />
        </div>
            <div>
                <asp:Label ID="label1" runat="server" Text=""></asp:Label>
            </div>
    </form>

</body>
</html>
