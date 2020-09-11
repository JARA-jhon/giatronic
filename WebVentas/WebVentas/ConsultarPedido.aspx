<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="ConsultarPedido.aspx.cs" Inherits="WebVentas.ConsultarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link rel="stylesheet" href="css/demo-stylescontacto.css" />
     <script type="text/javascript">
         function solonumeros(e) {

             var key;

             if (window.event) // IE
             {
                 key = e.keyCode;
             }
             else if (e.which) // Netscape/Firefox/Opera/chrome
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
          .auto-style1 {
              height: 72px;
          }
      </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <br>
    <br>
    <br>

      <div class="dashboard clearfix">

     <table>
        <tr>
            <td class="auto-style1" colspan="12">
                <h1 class="style5">
                   Consulta de Pedidos                    
                </h1>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" width="15%" class="style5">
                &nbsp;</td>
            <td colspan="2" width="15%">
                <asp:TextBox ID="txtNroPedido" runat="server" TabIndex="1" 
                onkeypress="javascript:return solonumeros(e)" Visible="False"></asp:TextBox>
            </td>
            <td colspan="2" width="15%" class="style5" style="text-align: right">
                Estado
            <td colspan="2" width="15%">
                <asp:DropDownList ID="ddlEstado" runat="server" >
                </asp:DropDownList>
            </td>
            <td width="15%" style="text-align: right">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/btn_buscar.png" 
                    onclick="ImageButton1_Click" Width="30px" />
            </td>
             <td>
                <asp:Button ID="Button1" runat="server" Text="Salir" BackColor="#0099FF" BorderColor="White" 
                Font-Bold="True" ForeColor="White" Width=75px CausesValidation="False" 
                    onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="12">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="12">
                <span class="style5">Cantidad de Registros: </span>
                <asp:TextBox ID="txtCant" runat="server" BorderWidth="1px" Font-Bold="True" 
                    ReadOnly="True" Width="68px" Enabled="False" style="text-align: center"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="12">
                <asp:GridView ID="gvPedido" runat="server" AllowPaging="True" 
                    Width="100%" 
                    AutoGenerateColumns="False" 
                    onselectedindexchanged="gvPedido_SelectedIndexChanged" 
                    onpageindexchanging="gvPedido_PageIndexChanging">
                
                    <Columns>
                        <asp:BoundField DataField="pedcod" HeaderText="Código" />
                        <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="monto" HeaderText="Monto" />
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                        <asp:BoundField DataField="estdesc" HeaderText="Estado" />
                        <asp:TemplateField HeaderText="Ver Detalle" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Select" 
                                    ImageUrl="~/images/leer.jpg" Width="25px" />
                              
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                
                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="White" />
                <RowStyle ForeColor="#0099FF" HorizontalAlign="Center" VerticalAlign="Middle" />



                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="8">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="8">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
        </tr>
    </table>
    </div>
</asp:Content>
