<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web.aspx.cs" Inherits="WebApplication1.Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function pageLoad() {
            var pm = Sys.WebForms.PageRequestManager.getInstance();
            pm.add_endRequest(endRequest);
        }
        function endRequest(sender, args) {
            if (args.get_error() != null) {
                $get("Ошибка").innerHTML = args.get_error().message;
                args.ser_errorHandled(true);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" OnAsyncPostBackError="ScriptManager1_AsyncPostBackError"></asp:ScriptManager>
            <script type="text/javascript">
               var pm = Sys.WebForms.PageRequestManager.getInstance();
                pm.add_initializeRequest(InitializeRequest);
                function InitializeRequest(sender, args) {
                    if (pm.get_isInAsyncPostBack()) {
                        args.set_cancel(true);
                    }
                }
                function AbortPostBack() {
                    alert("Отмена");
                    if (pm.get_isInAsyncPostBack()) {
                        pm.AbortPostBack();
                    }
                }
            </script>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" >
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                  <%--  <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick"></asp:Timer> --%>
                    <n />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
            </Triggers>
            </asp:UpdatePanel>

            <asp:Button ID="Button4" runat="server" Text="Trigger on SUM" OnClick="Button1_Click" />
                                <br />
                    <br />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                <ContentTemplate>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem Text="Vlad" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Pasha"></asp:ListItem>
                    </asp:CheckBoxList>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server" >
                <ContentTemplate>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Text="Kopyl" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Minsk" ></asp:ListItem>
                    </asp:RadioButtonList>              
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:UpdatePanel ID="UpdatePanel5" runat="server"  UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox8" runat="server" Text="BSTU"></asp:TextBox>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
             <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel5">
                <ProgressTemplate>
                    Servers Call ...
                    <input type="button" id="Cancel" onclick="AbortPostBack();" value="Cancel" />
                </ProgressTemplate>
            </asp:UpdateProgress>
        
        </div>
    </form>
</body>
</html>
