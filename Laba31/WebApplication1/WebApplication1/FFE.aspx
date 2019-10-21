<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FFE.aspx.cs" Inherits="WebApplication1.FFE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">

                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
                    <asp:Label ID="Label1" runat="server" Text="Label" style="margin-left: 20px" ></asp:Label>
                    <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" DisplayCancelButton="True" FinishCompleteButtonText="Подтвердить" FinishPreviousButtonText="Назад" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnFinishButtonClick="Wizard1_FinishButtonClick" StartNextButtonText="Дальше" StepNextButtonText="Дальше" StepPreviousButtonText="Назад">                       
                        <WizardSteps>
                            <asp:WizardStep runat="server" title="Фамилия Имя" > 
                                <label>Фамилия</label>
                                <asp:TextBox ID="F" runat="server"></asp:TextBox>
                                <label>Имя</label>
                                <asp:TextBox ID="I" runat="server"></asp:TextBox>                               

                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Место рождения">
                                <label>
                                Место рождения</label>
                                <asp:TextBox ID="R" runat="server"></asp:TextBox>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Университет">
                                <label>
                                Университет</label>
                                <asp:TextBox ID="Y" runat="server"></asp:TextBox>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Машина">
                                <label>
                                Машина</label>
                                <asp:TextBox ID="M" runat="server"></asp:TextBox>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Информация">
                                <asp:Label ID="INFO" runat="server" Text="Label"></asp:Label>
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>

                </asp:View>
                 <asp:View ID="View2" runat="server">
                     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"/>
                    <asp:Label ID="Label2" runat="server" Text="Label" style="margin-left: 20px" ></asp:Label>


                     <br />
                       <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" OnTreeNodeCheckChanged="TreeView1_TreeNodeCheckChanged" Width="83px">
                           <Nodes>
                               <asp:TreeNode Text="1" Value="1" Expanded="False" ImageUrl="Banner1.aspx">
                                   <asp:TreeNode Text="Баннер" Value="1.1" ToolTip="Перейти на баннер1" ImageUrl="../Image/1.png"></asp:TreeNode>
                                   <asp:TreeNode Text="1.2" Value="1.2"></asp:TreeNode>
                                   <asp:TreeNode Text="1.3" Value="1.3"></asp:TreeNode>
                               </asp:TreeNode>
                                <asp:TreeNode Text="2" Value="2" Expanded="False" Checked="true">
                                   <asp:TreeNode ShowCheckBox="True" Text="2.1" Value="2.1"></asp:TreeNode>
                                   <asp:TreeNode ShowCheckBox="True" Text="2.2" Value="2.2"></asp:TreeNode>
                                   <asp:TreeNode ShowCheckBox="True" Text="2.3" Value="2.3"></asp:TreeNode>
                               </asp:TreeNode>
                                <asp:TreeNode Text="3" Value="3" Expanded="False" Checked="true">
                                   <asp:TreeNode Text="3.1" Value="3.1"></asp:TreeNode>
                                   <asp:TreeNode Text="3.2" Value="3.2"></asp:TreeNode>
                                   <asp:TreeNode Text="3.3" Value="3.3"></asp:TreeNode>
                               </asp:TreeNode>
                                <asp:TreeNode Text="4" Value="4" Expanded="False" Checked="true">
                                  
                               </asp:TreeNode>
                           </Nodes>
                     </asp:TreeView>

                </asp:View>
                 <asp:View ID="View3" runat="server">
                     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click"/>
                    <asp:Label ID="Label3" runat="server" Text="Label" style="margin-left: 20px" ></asp:Label>
                     <br />
                     <br />
                     <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="1em" ForeColor="#7C6F57" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px">
                         <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                         <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                         <DynamicMenuStyle BackColor="#F7F6F3" />
                         <DynamicSelectedStyle BackColor="#5D7B9D" />
                         <Items>
                             <asp:MenuItem Text="Главная" Value="Главная">
                                 <asp:MenuItem Text="1" Value="1">
                                     <asp:MenuItem Text="2" Value="2"></asp:MenuItem>
                                 </asp:MenuItem>
                                 <asp:MenuItem Text="Дополнитлеьная" ToolTip="Информация" Value="Дополнитлеьная">
                                     <asp:MenuItem Text="1" Value="1"></asp:MenuItem>
                                 </asp:MenuItem>
                             </asp:MenuItem>
                             <asp:MenuItem Text="Последняя" Value="Последняя">
                                 <asp:MenuItem Text="1" Value="1"></asp:MenuItem>
                                 <asp:MenuItem Text="2" Value="2"></asp:MenuItem>
                                 <asp:MenuItem Text="3" Value="3"></asp:MenuItem>
                             </asp:MenuItem>
                         </Items>
                         <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                         <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                         <StaticSelectedStyle BackColor="#5D7B9D" />
                         <StaticItemTemplate>
                             <%# Eval("Text") %>
                         </StaticItemTemplate>
                     </asp:Menu>
                </asp:View>
            </asp:MultiView>

        </div>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View Change" />

        <asp:Button ID="Button5" runat="server" Text="Rotator" OnClick="Button5_Click" />

        <div>

            <asp:AdRotator ID="AdRotator1" runat="server"  AdvertisementFile="~/App_Data/AdRotator.xml"/>

        </div>
    </form>
</body>
</html>
