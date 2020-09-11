<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="WebVentas.VerCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/demo-stylescontacto.css" />

      <style type="text/css">
        .auto-style1 {
            width: 49px;
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
            <td class="style5" colspan="2">
                <h1>
                    Registro de Pedido</h1>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvCarrito" runat="server" Width="100%" 
                    AutoGenerateColumns="False" 
                    onselectedindexchanged="gvCarrito_SelectedIndexChanged">
                    <Columns>
                        
                        <asp:BoundField DataField="idprov" HeaderText="Proveedor" />
                        <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                        <asp:BoundField DataField="precio" HeaderText="Precio" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="subtotal" HeaderText="Sub-Total" />
                        <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                                    CommandName="Select" ImageAlign="Middle" ImageUrl="~/images/eliminar.png" 
                                    Width="30px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="White" />
                <RowStyle ForeColor="#0099FF" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:GridView>
            </td>
            <td class="auto-style1">
                
            </td>
            <td>
                <asp:Label ID="lblmensaje2" runat="server" style="color: #0099FF"></asp:Label>
                <a href="Contacto.aspx" tabindex="4">atencion al cliente , gracias </a></td>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server" style="color: #0099FF"></asp:Label>
                <br />
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Monto Total: " CssClass="style5"></asp:Label>
          &nbsp;<asp:Label ID="lblTotal" runat="server" CssClass="style5"></asp:Label>
                <asp:Label ID="lbldescuento" runat="server"></asp:Label>
                <asp:Label ID="lbligv" runat="server"></asp:Label>
                <asp:Label ID="lblneto" runat="server"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button2" runat="server" Text="Realizar Pedido"  
                    BackColor="#0099FF" BorderColor="White" Font-Bold="True" ForeColor="White" 
                    onclick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Regresar"  BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" 
                    onclick="Button1_Click" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            </td>
        </tr>
    </table>
</div>

</asp:Content>
