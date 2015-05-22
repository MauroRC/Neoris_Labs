<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormEmpleado.aspx.cs" Inherits="TP02_POO.FormEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 308px">
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:RadioButton ID="rbtnEncargado" Text="Encargado" runat="server" AutoPostBack="true" OnCheckedChanged="rbtnEncargado_Check"/></td>
                <td> <asp:RadioButton ID="rbtnSupervisor" Text="Supervisor" runat="server" AutoPostBack="true" OnCheckedChanged="rbtnSupervisor_Check" /></td>
                <td> <asp:Label ID="lblTipoEmpleado" Text="" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label Text="DNI" runat="server" /></td>
                <td><asp:TextBox ID="tbxDni" runat="server" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Nombre" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="tbxNombre" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Apellido" runat="server" />

                </td>
                <td>
                    <asp:TextBox ID="tbxApellido" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Año ingreso" runat="server" />

                </td>
                <td>
                    <asp:TextBox ID="tbxAñoIngreso" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Sueldo base" runat="server" />

                </td>
                <td>
                    <asp:TextBox ID="tbxSueldoBase" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Hs Trabajadas" runat="server" />

                </td>
                <td>
                    <asp:TextBox ID="tbxHsTrabajadas" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Precio p/hora" runat="server" />

                </td>
                <td>
                    <asp:TextBox ID="tbxPrecioHora" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Text="Categoria" runat="server" />

                </td>
                <td>
                    <asp:DropDownList ID="ddlCategoria" runat="server" Width="50px">
                        <asp:ListItem Text="" />
                        <asp:ListItem Text="A" />
                        <asp:ListItem Text="B" />
                        <asp:ListItem Text="C" />
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblCategoria" Text="" runat="server" />
                </td>
            </tr>
                <tr>
                <td>
                </td>
                <td>
                    <asp:Button Text="Calcular sueldo" runat="server" OnClick="Calcular_Click" />
                </td>
            </tr>
        </table>
        <asp:TextBox ID="tbxSueldo" runat="server" Width="350px" />
        <br />
        <asp:Label ID="lblError" Text="" runat="server" />
    </div>
    </form>
</body>
</html>
