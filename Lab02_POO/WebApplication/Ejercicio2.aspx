<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Lab02_POO.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="Empezar" runat="server" OnClick="Empezar_click" />
        <br />
        <asp:TextBox ID="tbxIngresar" runat="server" />
        <asp:Button Text="Ingresar" runat="server" OnClick="Ingresar_click"/>
        <br />
        <br />
        <asp:Button Text="Analizar" runat="server" OnClick="Analizar_click" />
        <br />
        <br />
        <asp:Label Text="Resultado: " runat="server" />
        <asp:TextBox ID="tbxResultado" runat="server" Width="550px" Height="68px" />
    
    </div>
    </form>
</body>
</html>
