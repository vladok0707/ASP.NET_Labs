<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="lab35.WebUserControl1" %>
<div>
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell><b>Фамилия</b></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><b>Имя</b></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell><b>Отчество</b></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell><b>Дата рождения</b></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><b>Пол</b></asp:TableCell>
            <asp:TableCell>
                 <asp:RadioButtonList ID="RadioButtonList1" runat="server"  RepeatDirection="Horizontal">
        <asp:ListItem Text="М"></asp:ListItem>
        <asp:ListItem Text="Ж"></asp:ListItem>
                </asp:RadioButtonList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><b>Факультет</b></asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="ФИТ"></asp:ListItem>
                    <asp:ListItem Text="Лес"></asp:ListItem>
                    <asp:ListItem Text="ИЭФ"></asp:ListItem>
                    <asp:ListItem Text="ХИМ"></asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><b>Группа</b></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><b>Год поступления</b></asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox7" runat="server" TextMode="Number"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="Ввод" OnClick="Button1_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button2" runat="server" Text="Откзааться" OnClick="Button2_Click"  />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Введите фамилию" ControlToValidate="TextBox1" EnableClientScript="False"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Введите имя" ControlToValidate="TextBox2" EnableClientScript="False"></asp:RequiredFieldValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Введите отчество" ControlToValidate="TextBox3" EnableClientScript="False"></asp:RequiredFieldValidator>
    <br />
    <asp:RangeValidator ID="RangeValidator4" runat="server" ErrorMessage="Введите значение в пределах 1-100" ControlToValidate="TextBox6" MaximumValue="100" MinimumValue="1" EnableClientScript="False"></asp:RangeValidator>
</div>