<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4.aspx.cs" Inherits="Lab02_POO.Ejercicio4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="Lanzar dado" runat="server" OnClick="LanzarDado_Click" />
        <asp:TextBox ID="tbxResultado" runat="server" Width="500px" />
    
    </div>
    </form>
</body>
</html>
