<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSum.aspx.cs" Inherits="WebApplication2.WebFormSum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Основы ASP.NET</title>
    <script type="text/javascript">
        var xmlRequest;

function CreateXMLHttpRequest() {
    try {
        // Этот код работает, если XMLHttpRequest является частью JavaScript
        xmlRequest = new XMLHttpRequest();
    }
    catch (err) {
        // В противном случае требуется объект ActiveX
        xmlRequest = new ActiveXObject("Microsoft.XMLHTTP");
    }
}

function CallServerForUpdate() {
    var txt1 = document.getElementById("txt1");
    var txt2 = document.getElementById("txt2");

    var url = "CalculatorCallbackHandler.ashx?value1=" +
      txt1.value + "&value2=" + txt2.value;
    xmlRequest.open("POST", url);
    xmlRequest.onreadystatechange = ApplyUpdate;
    xmlRequest.send(null);
}

function ApplyUpdate() {
    // Проверить успешность получения ответа
    if (xmlRequest.readyState == 4) {
        if (xmlRequest.status == 200) {
            var lbl = document.getElementById("lblResponse");

            var response = xmlRequest.responseText;

            if (response == "-") {
                lbl.innerHTML = "Вы ввели некорректные числа.";
            }
            else {
                var responseStrings = response.split(",");
                lbl.innerHTML = "Сумма чисел: " +
                    responseStrings[0] ;
            }
        }
    }
}
        
    </script>
</head>
<body onload="CreateXMLHttpRequest();">
    <form id="form1" runat="server">
        <div>
            Число 1: 
            <asp:TextBox ID="txt1" runat="server" onKeyUp="CallServerForUpdate();"></asp:TextBox><br />
            Число 2: 
            <asp:TextBox ID="txt2" runat="server" onKeyUp="CallServerForUpdate();"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblResponse" runat="server">
            </asp:Label>
        </div>
    </form>
</body>
</html>