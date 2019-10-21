<%@ Page Language="C#" AutoEventWireup="true" Theme="Skin" CodeBehind="Main.aspx.cs" Inherits="WebApplication1.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <asp:Button ID="B" runat="server" Text="OK" EnableTheming="false" class="Style"/>
            <asp:Label ID="L" CssClass="style_label" EnableTheming="false" runat="server" Text="ABCDEFGHKLMNOPRST"></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <br />
        <div>
            <asp:TextBox runat="server"></asp:TextBox>
       <br />     <asp:Button ID="Button1" runat="server" Text="OK" EnableTheming="false"/>
       <br />     <asp:Label ID="Label1" CssClass="style_label" runat="server" Text="ABCDEFGHKLMNOPRST"></asp:Label>
        <br />            <asp:Label ID="Label2" CssClass="style_label" runat="server" Text="ABCDEFGHKLMNOPRST" SkinID="RedL"></asp:Label>
        </div>
    </form>
</body>
</html>
