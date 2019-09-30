<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="Laba30.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
     <script  language="javascript" type ="text/javascript">
        function r_onlick() {
        }
        function f_onlick() {
        }
        function it_onlick() {
        }
        function s_onlick() {
        }
        function ch_onclick() {
        }
        function ta_onclick() {
        }
    </script>
<body>
  
    <form id="form1" runat="server">
        <div>
            <input id="Reset1" runat="server" onserverclick="Res"  type="reset" value="reset" />             <br />
            <input id="Button1" runat="server"  onserverclick="But" type="button" value="button" /><br />
            <input id="Submit1" runat="server"  onserverclick="Sub"  type="submit" value="submit" /><br />
            <input id="File1" type="file" runat="server" onserverchange="File"  onclick="return f_onlick()"/><br />
            <input id="Text1" runat="server" onserverchange="Common_onserverchange" type="text" onclick="return it_onlick()"/><br />
            <input id="Password1" runat="server" onserverchange="Common_onserverchange" type="password" /><br />
            <input id="Checkbox1" runat="server" onserverchange="Common_onserverchange" type="checkbox" onclick="return ch_onlick()"/><br />
            <textarea id="TextArea1" runat="server" onserverchange="Common_onserverchange" cols="20" rows="2" onclick="return ta_onclick()" ></textarea><br />
            <input id="Radio1" runat="server" onserverchange="Common_onserverchange" type="radio" onclick="return r_onlick()" /><br />
            <select id="Select1" onserverchange="Common_onserverchange" runat="server">
                <option></option>
                <option>Влад</option>
                <option>Павел</option>
            </select>
        </div>
        
    </form>
    
</body>
</html>
