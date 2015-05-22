<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Lab03__Excepciones.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="SimpleException" runat="server" OnClick="SimpleException_CLick" />
        <br />
        <br />
        <asp:TextBox ID="tbxMensaje" runat="server" Width="200px" />
        <br />
        <br />
        <asp:TextBox ID="tbxFinaliza" runat="server" />
    
    </div>
    </form>
</body>
</html>
