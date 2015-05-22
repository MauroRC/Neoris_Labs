<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="Lab03__Excepciones.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="Generar Excepción" runat="server" OnClick="GenerarExcepcion_Click"/>
        <br />
        <br />
        <asp:Label Text="Excepción:" runat="server" />
        <br />
        <asp:TextBox ID="tbxExcepcion" runat="server" Width="500px" />
    
    </div>
    </form>
</body>
</html>
