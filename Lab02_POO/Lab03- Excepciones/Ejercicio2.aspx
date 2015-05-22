<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Lab03__Excepciones.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="Ingrese dividendo: " runat="server" />
        <asp:TextBox ID="tbxDividendo" runat="server" />
        <br /> 
        <asp:Label Text="Ingrese divisor: " runat="server" />
        <asp:TextBox ID="tbxDivisor" runat="server" />
        <br />
        <asp:Button Text="Dividir" runat="server" OnClick="btnDividir_Click" />
        <br />
        <asp:Label Text="Resultado: " runat="server" />
        <asp:TextBox ID="tbxResultado" runat="server" />
        <br />
        <asp:Label Text="Excepcion: " runat="server" />
        <asp:TextBox ID="tbxExcepcion" runat="server" Width="500px" />


    
    </div>
    </form>
</body>
</html>
