<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="MantenerProveedor.aspx.cs" Inherits="WebVentas.MantenerProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

      <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
    
      <style type="text/css">
        .auto-style1 {
            width: 7%;
        }
    </style>

    
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

    <script type="text/javascript">
        function sololetras(e) {

            var key;

            if (window.event) // IE
            {
                key = e.keyCode;
            }
            else if (e.which) // Netscape/Firefox/Opera
            {
                key = e.which;
            }

            if (key >= 48 && key <= 57) {
                return false;
            }

            return true;
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br>
      <br>
          <div class="dashboard clearfix">
     <table class="style1">
        <tr>
            <td colspan="10">
                <h1 class="style5">
                    Mantenimiento Proveedores</h1>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                ruc</td>
            <td width="20%">
                <asp:TextBox ID="txtruc" runat="server" 
                    onkeypress="javascript:return solonumeros(event)" TabIndex="1" MaxLength="11"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtruc" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Empresa:</td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" 
                    onkeypress="javascript:return sololetras(event)" TabIndex="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtNom" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

          <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Dirección:</td>
            <td>
                <asp:TextBox ID="txtDir" runat="server" TabIndex="4"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtDir" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Teléfono:</td>
            <td>
                <asp:TextBox ID="txtFono" runat="server" 
                    onkeypress="javascript:return solonumeros(event)" TabIndex="3"  MaxLength="7"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtFono" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Contacto:</td>
            <td>
                <asp:TextBox ID="txtcon" runat="server" TabIndex="5"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtcon" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

         <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Correo:</td>
            <td>
                <asp:TextBox ID="txtcor" runat="server" TabIndex="6" TextMode="Email" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtcor" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

          <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Productos:</td>
            <td>
                <asp:TextBox ID="txtpro" runat="server" TabIndex="7"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtpro" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td class="style4">
                </td>
            <td class="auto-style1">
                </td>
            <td class="style4">
                <asp:Label ID="lblMensaje" runat="server" style="color: #0099FF"></asp:Label>
            </td>
            <td class="style4">
                </td>
            <td class="style4">
                </td>
            <td class="style4">
                </td>
            <td class="style4">
                </td>
            <td class="style4">
                </td>
            <td class="style4">
                </td>
            <td class="style4">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="3" width="20%">
                <asp:Button ID="btnRegistrar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Registrar" onclick="btnRegistrar_Click" />
                &nbsp;<asp:Button ID="btnActualizar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Actualizar" onclick="btnActualizar_Click" />
                &nbsp;<asp:Button ID="btnEliminar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Eliminar" onclick="btnEliminar_Click" />
                &nbsp;<asp:Button ID="btnCancelar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Cancelar" CausesValidation="False" onclick="btnCancelar_Click" />
                &nbsp;<asp:Button ID="btnSalir" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Salir" CausesValidation="False" onclick="btnSalir_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:GridView ID="gvProveedores" runat="server" Width="1005px" 
                    AutoGenerateColumns="False" 
                    onpageindexchanging="gvProveedores_PageIndexChanging" 
                    onselectedindexchanged="gvProveedores_SelectedIndexChanged" 
                    AllowPaging="True" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="ruc" HeaderText="RUC" />
                        <asp:BoundField DataField="nomprov" HeaderText="Nombre" />
                        <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                        <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
                        <asp:BoundField DataField="contacto" HeaderText="Contacto" />
                        <asp:BoundField DataField="correo" HeaderText="Correo" />
                        <asp:BoundField DataField="productos" HeaderText="Productos" />
                        
                        <asp:TemplateField HeaderText="Seleccionar" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                                    CommandName="Select" ImageAlign="Middle" ImageUrl="~/images/editar.png" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="White" />
                <RowStyle ForeColor="#0099FF" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
 </div>


</asp:Content>
