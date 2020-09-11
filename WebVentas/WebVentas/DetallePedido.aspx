<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="WebVentas.DetallePedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link rel="stylesheet" href="css/demo-stylescontacto.css" />
    <style type="text/css">
        .style13
        {
            font-weight: bold;
            color: #0099FF;
        }
        .auto-style1 {
            height: 27px;
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
            <td>
                nbsp;</td>
            <td class="style5">
                <h1>
                    Detalle de Pedido</h1>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#0099FF" Font-Bold="True" 
                    ForeColor="White" onclick="Button1_Click" Text="Regresar" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:DataList ID="dlDetalle" runat="server" OnSelectedIndexChanged="dlDetalle_SelectedIndexChanged">
                    <ItemTemplate>
                        <table class="style1" border="1">
                            <tr>
                                <td class="style13" rowspan="5">
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("img") %>' Width="200" Height="175"/>
                                </td>
                                <td class="style13">
                                    Código:</td>
                                <td>
                                    <asp:Label ID="lblCodigo" runat="server" CssClass="style5" 
                                        Text='<%# Eval("pedcod") %>'></asp:Label>
                                </td>
                                <td class="style13">
                                    Fecha</td>
                                <td>
                                    <asp:Label ID="lblFecha" runat="server" CssClass="style5" 
                                        Text='<%# Eval("fecha") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style13">
                                    Nro. de Item</td>
                                <td>
                                    <asp:Label ID="lblItem" runat="server" CssClass="style5" 
                                        Text='<%# Eval("item") %>'></asp:Label>
                                </td>
                                <td class="style13">
                                    Precio:</td>
                                <td>
                                    <asp:Label ID="lblPrecio" runat="server" CssClass="style5" 
                                        Text='<%# Eval("precio") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style13">
                                    Proveedor:</td>
                                <td>
                                    <asp:Label ID="lblProveedor" runat="server" CssClass="style5" 
                                        Text='<%# Eval("nomprov") %>'></asp:Label>
                                </td>
                                <td class="style13">
                                    Cantidad:</td>
                                <td>
                                    <asp:Label ID="lblCantidad" runat="server" CssClass="style5" 
                                        Text='<%# Eval("cantidad") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style13">
                                    Modelo:</td>
                                <td>
                                    <asp:Label ID="lblModelo" runat="server" CssClass="style5" 
                                        Text='<%# Eval("modelo") %>'></asp:Label>
                                </td>
                                <td class="style13">
                                    Subtotal:</td>
                                <td>
                                    <asp:Label ID="lblSubtotal" runat="server" CssClass="style5" 
                                        Text='<%# Eval("subtotal") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <span class="style5"><strong>Estado: </strong></span>
                                    <asp:Label ID="lblEstado" runat="server" CssClass="style5" 
                                        Text='<%# Eval("estdesc") %>'></asp:Label>
                                </td>

                                 </tr>
                           <%-- <tr>
                                <td colspan="2" width="15%" class="style5" style="text-align: right">
                Estado
            <td colspan="2" width="15%">
                <asp:DropDownList ID="lblEstado" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
                                </tr>--%>


                        </table>
                    </ItemTemplate>
                </asp:DataList>
            
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                </td>
            <td class="auto-style1">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
          </div>

</asp:Content>
