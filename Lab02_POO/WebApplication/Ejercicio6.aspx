<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio6.aspx.cs" Inherits="Lab02_POO.Ejercicio6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>  
        <asp:Button Text="Que dia sera mañana?" runat="server" OnClick="Pregunta_Click" />
        <asp:TextBox ID="tbxDia" runat="server" Width="250px"/>
    </div>
    </form>
</body>
</html>
