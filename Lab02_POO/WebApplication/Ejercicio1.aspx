<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Lab02_POO.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="Sumar" runat="server" OnClick="Sumar_Click"/>
        <asp:Button Text="Limpiar" runat="server" OnClick="Limpiar_Click"/>
        <br />
        <asp:Label Text="Resultado: " runat="server" /> 
        <asp:TextBox ID="tbxResultado" runat="server" />
    
    </div>
    </form>
</body>
</html>
