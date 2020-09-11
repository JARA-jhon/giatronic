<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="Television.aspx.cs" Inherits="WebVentas.DetalleCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="css/demo-stylescontacto.css" />

     <script type="text/javascript">
         function solonumeros(e) {

             var key;

             if (window.event) // IE
             {
                 key = e.keyCode;
             }
             else if (e.which) // Netscape/Firefox/Opera
             {
                 key = e.which;
             }

             if (key < 48 || key > 57) {
                 return false;
             }

             return true;
         }
</script>
    <style type="text/css">
        .style13
        {
            color: #0099FF;
            font-weight: bold;
            font-size: 11pt;
        }
        .auto-style1 {
            color: #0099FF;
            font-weight: bold;
            font-size: 11pt;
            height: 27px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style3 {
            height: 72px;
        }
        .auto-style4 {
            height: 72px;
            width: 7%;
        }
        .auto-style5 {
            color: #0099FF;
            font-weight: bold;
            font-size: 11pt;
            width: 7%;
        }
        .auto-style6 {
            color: #0099FF;
            font-weight: bold;
            font-size: 11pt;
            height: 27px;
            width: 7%;
        }
        .auto-style7 {
            width: 7%;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <br>
    <br>

      <div class="dashboard clearfix">
    <table class="style1">
       
            <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td colspan="4" class="auto-style3">
                <h1 class="style5">
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    Añadir Al Carrito</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td width="15%" class="style13">
                Codigo</td>
            <td width="20%">
                <asp:Label ID="lblCodigo" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td rowspan="7">
                <asp:Image ID="Image1" runat="server"  Width="200" Height="175" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Proveedor</td>
            <td>
                <asp:Label ID="lblProveedor" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Tecnologia</td>
            <td>
                <asp:Label ID="lblTecnologia" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Categoria:</td>
            <td>
                <asp:Label ID="lblCategoria" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Resolucion</td>
            <td>
                <asp:Label ID="lblResolucion" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Pulgadas:</td>
            <td>
                <asp:Label ID="lblPulgadas" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Caracteristicas:</td>
            <td>
                <asp:Label ID="lblCaracteristicas" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style1">
                Cliente:</td>
            <td class="auto-style2">
                <asp:Label ID="lblCliente" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style1">
                Precio</td>
            <td class="auto-style2">
                <asp:Label ID="lblPrecio" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Stock</td>
            <td>
                <asp:Label ID="lblStock" runat="server" CssClass="style5"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="style13">
                Cantidad</td>
            <td>
                <asp:TextBox ID="txtCantidad" runat="server" onkeypress="javascript:return solonumeros(event)"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnAgregar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px onclick="btnAgregar_Click" 
                    Text="Agregar" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="#0099FF" BorderColor="White" 
                    Font-Bold="True" ForeColor="White" Width=75px onclick="Button2_Click" 
                    Text="Regresar" />
            </td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" style="color: #0099FF"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
      
    </table>
          </div>

</asp:Content>
