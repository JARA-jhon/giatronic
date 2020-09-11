<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="WebVentas.EditarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link rel="stylesheet" href="css/demo-stylescontacto.css" />
   <style type="text/css">
        .style13
        {
            color: #FF0000;
        }
        .style18
        {
            color: #0099FF;
            font-weight: bold;
        }
        .style19
        {
            color: #0099FF;
            font-size: 8pt;
        }
        .style21
        {
            color: #0099FF;
            font-weight: bold;
            font-size: 8pt;
        }
    </style>

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
    <br>

      <div class="dashboard clearfix">

    <table class="style1" style="text-align: center">
        <tr>
            <td class="style5" colspan="4">
                <h1>Editar Perfil</h1>
            </td>
        </tr>
        <tr>
            <td colspan="4" class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="5%">
                </td>
            <td>
                </td>
            <td class="style5" width="10%">
                Nick:</td>
              <td class="style23">
                <asp:TextBox ID="txtNic" runat="server" TabIndex="9"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="txtNic" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td> 

            <td>
                &nbsp;</td>
        </tr>

         <tr>
            <td class="style18" style="text-align: right">
                &nbsp;</td>
            <td class="style21">
                <strong>Nota: Sirve como usuario<br />
                para loguear al sistema.</strong></td>
            <td class="style18" colspan="2">
                &nbsp;</td>
        </tr>
        
        
        <tr>
            <td class="style21">
                </td>
            <td class="style21">
                </td>
            <td class="style22">
                Dirección:</td>
            <td align="left" class="style21">
                <asp:TextBox ID="txtDir" runat="server" TabIndex="4"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtDir" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style24">
                E-mail:</td>
            <td class="style23">
                <asp:TextBox ID="txtEmail" runat="server" TabIndex="5"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style21">
                </td>
        </tr>


         <tr>
            <td class="style21">
                </td>
            <td class="style21">
                </td>
            <td class="style22">
                Apellido Paterno:</td>
            <td align="left" class="style21">
                <asp:TextBox ID="txtApep" runat="server" TabIndex="6"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtApep" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style24">
                Apellido Materno:</td>
            <td class="style23">
                <asp:TextBox ID="txtApem" runat="server" TabIndex="7"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtApem" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style21">
                </td>
        </tr>


            <tr>
            <td class="style21">
                </td>
            <td class="style21">
                </td>
            <td class="style22">
                Telefono:</td>
            <td align="left" class="style21">
                <asp:TextBox ID="txtTel" runat="server" TabIndex="8"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtTel" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style24">
                Nombre:</td>
                <td align="left" width="20%">
                <asp:TextBox ID="txtNom" runat="server" 
                    onkeypress="javascript:return sololetras(event)" TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNom" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style21">
                </td>
        </tr>


        
         <tr>
            <td class="style18" colspan="4" style="text-align: right">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18" style="text-align: right">
                Password: 
            </td>
            <td>
                <asp:TextBox ID="txtPas" runat="server" TabIndex="5" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style13" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18" style="text-align: right">
                Confirmar Password:</td>
            <td>
                <asp:TextBox ID="txtCPas" runat="server" TabIndex="6" TextMode="Password"></asp:TextBox>
            </td>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server" style="color: #0099FF"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style19">
                <strong>Nota: Si no desea modificar su password, deje en blanco ambos campos</strong></td>
            <td colspan="2">
                <asp:Button ID="btnGCambios" runat="server" Text="Guardar Cambios" 
                BackColor="#0099FF" BorderColor="White" Font-Bold="True" ForeColor="White"
                    onclick="btnGCambios_Click" Width="30%" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRegresar" runat="server" CausesValidation="False" 
                   BackColor="#0099FF" BorderColor="White" Font-Bold="True" ForeColor="White" 
                   Text="Regresar" onclick="btnRegresar_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="4" class="style5">
                &nbsp;</td>
        </tr>
    </table>

          </div>
</asp:Content>
