<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="Lab02_POO.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="#" rel="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label id="lblConsigna" Text="" runat="server" />
        <br />
        <br />
        <asp:Button Text="Nuevo Juego" runat="server" OnClick="NuevoJuego_Click" />
        <br />
        <br />
        <asp:TextBox ID="tbxNumero" runat="server" Width="50px" Height="20px" />
        <asp:Button Text="Probar" runat="server" OnClick="Probar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMensaje" Text="" runat="server"  />
    
    </div>
    </form>
</body>
</html>
