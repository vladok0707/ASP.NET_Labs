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
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        </div>
        <div>

            <asp:Button ID="GetButton" runat="server" OnClick="GetButton_Click" Text="Get" Width="67px" />
            <asp:Button ID="PostButton" runat="server" OnClick="PostButton_Click" Text="Post" Width="67px" />
             <asp:Button ID="PutButton" runat="server" OnClick="PutButton_Click" Text="Put" Width="67px" />
                     
    
            
        </div>
    </form>
</body>
</html>
