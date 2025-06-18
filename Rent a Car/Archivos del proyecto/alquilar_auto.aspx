<%@ Page Language="C#" CodeFile="alquilar_auto.aspx.cs" Inherits="Hola.ClaseHola" 
AutoEventWireup="true" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title></title></head>
<body>

<% // mostrando pantalla 01
if (var == 1 | var == 3){ %> 
    <h1>alquilar un auto</h1>
    
    <% // mostrando pantalla 03
    if (var == 3){ %> 
    <h2>la entrada no puede estar vacia.</h2>
    <% } %>
    
    <form id="form1" method="post" runat="server">
        <span>nombre del cliente</span><asp:textbox ID="textbox1" runat="server"/><br />
        <span>fecha inicio del alquiler</span><asp:textbox ID="textbox2" runat="server"/><br />
        <span>fecha final del alquiler</span><asp:textbox ID="textbox3" runat="server"/><br />
        <span>marca y modelo del auto</span>
        <asp:dropdownlist ID="list1" runat="server">
            <asp:ListItem Selected="True" Value="seleccione_un_auto">- seleccione un auto -</asp:ListItem>
        </asp:dropdownlist><br />
        <asp:button ID="button1" runat="server" Text="enviar" OnClick="click_enviar" />
    </form>
<% } %>
<% // mostrando pantalla 02
if (var == 2){ %> 
    <h1>¡auto alquilado con exito!</h1>
<% } %>
    <a href="index.aspx">volver al menú de opciones</a>
</body>
</html>
