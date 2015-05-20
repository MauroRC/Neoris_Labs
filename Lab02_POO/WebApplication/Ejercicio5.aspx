<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="Lab02_POO.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tbxNumero" runat="server" Width="50px" />
        <br />
        <br />
        <asp:Button Text="Es multiplo de 5?" runat="server" OnClick="Comprueba_Click" />
        <br />
        <br />
        <asp:Label ID="lblRespuesta" Text="" runat="server" />
    
    </div>
    </form>
</body>
</html>
