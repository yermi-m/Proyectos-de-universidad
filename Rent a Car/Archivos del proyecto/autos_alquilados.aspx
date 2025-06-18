<%@ Page Language="C#" CodeFile="autos_alquilados.aspx.cs" Inherits="Hola.ClaseHola" 
AutoEventWireup="true" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title></title></head>
<body>
    <h1>autos alquilados</h1>

    <asp:table ID="table1" runat="server" GridLines="Both">
        <asp:TableRow>
            <asp:TableCell>nombre del cliente</asp:TableCell>
            <asp:TableCell>fecha inicio del alquiler</asp:TableCell>
            <asp:TableCell>fecha final del alquiler</asp:TableCell>
            <asp:TableCell>marca y modelo del auto</asp:TableCell>
        </asp:TableRow>
    </asp:table>

    <a href="index.aspx">volver al menú de opciones</a>
</body>
</html>
