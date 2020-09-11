<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="WebVentas.RegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

      <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
    

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

    <style type="text/css">
        .style8
        {
            text-align: center;
        }
        .style11
        {
            height: 23px;
            color: #0099FF;
            text-align: center;
        }
        .style21
        {
            height: 30px;
        }
        .style22
        {
            color: #0099FF;
            height: 30px;
        }
        .style23
        {
            width: 15%;
            height: 30px;
        }
        .style24
        {
            color: #0099FF;
            height: 30px;
            text-align: right;
        }
        .style25
        {
            color: #0099FF;
            text-align: right;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br>
      <br>
        <div class="dashboard clearfix">
    <table>

      
        <tr>
            <td class="style8" colspan="7">
                <h1 class="style5" align="center">
                    Registrar Usuario<br></h1>
            </td>
        </tr>
       
        <tr>
            <td width="5%">
                </td>
            <td>
                </td>
            <td class="style5" width="10%">
                Nombre:</td>
            <td align="left" width="20%">
                <asp:TextBox ID="txtNom" runat="server" 
                    onkeypress="javascript:return sololetras(event)" TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNom" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
               <td align="left" class="style21">
                <asp:TextBox ID="txtpass2" runat="server" TabIndex="4" Visible="False"></asp:TextBox>
     
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                Password:</td>
            <td align="left">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password" TabIndex="2"></asp:TextBox>
               
            </td>
         
            <td class="style25">
                DNI:</td>
            <td>
                <asp:TextBox ID="txtDni" runat="server" 
                    onkeypress="javascript:return solonumeros(event)" MaxLength="8" 
                    TabIndex="3" OnTextChanged="txtDni_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtDni" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
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
                <asp:TextBox ID="txtEmail" runat="server" TabIndex="5" TextMode="Email" ></asp:TextBox>
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
                <asp:TextBox ID="txtTel" runat="server" TabIndex="8"  onkeypress="javascript:return solonumeros(event)" MaxLength="7" > </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtTel" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style24">
                Nick:</td>
            <td class="style23">
                <asp:TextBox ID="txtNic" runat="server" TabIndex="9"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="txtNic" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style21">
                </td>
        </tr>


        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style8" colspan="4">
                <asp:Label ID="lblPerfil" runat="server" CssClass="style5" Text="Perfil:" 
                    Visible="False"></asp:Label>
                <asp:DropDownList ID="ddlPerfil" runat="server" AutoPostBack="True" 
                    Visible="False"  TabIndex="10" OnSelectedIndexChanged="ddlPerfil_SelectedIndexChanged" >
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style4">
            </td>
            <td class="style4">
            </td>
            <td align="left" colspan="3" style="text-align: center">
                <asp:Label ID="lblMensaje" runat="server" 
                    style="text-align: center; color: #0099FF"></asp:Label>
            </td>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td class="style4">
            </td>
            <td align="left" class="style11" colspan="3">
                <asp:Button ID="Button1" runat="server" BackColor="#0099FF" BorderColor="White" 
                    Font-Bold="True" ForeColor="White" onclick="Button1_Click" 
                    Text="Registrar" Width="75px" />
                <asp:Button ID="btnEliminar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Text="Eliminar" 
                    Enabled="False" Visible="False" onclick="btnEliminar_Click" Width="75px" 
                    CausesValidation="False" />
                <asp:Button ID="btnSalir" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Text="Sailr" 
                    onclick="btnSalir_Click" Width="75px" CausesValidation="False" />
                <asp:Button ID="btnActualizar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Enabled="False" Visible="False" 
                    Text="Actualizar" onclick="btnActualizar_Click" Width="75px" />
                <asp:Button ID="btnCancelar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Cancelar" CausesValidation="False" onclick="btnCancelar_Click" />
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style8" colspan="7">
                <asp:GridView ID="gvUsuarios" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" 
                    onselectedindexchanged="gvAutos_SelectedIndexChanged" PageSize="5" 
                    Width="100%" onpageindexchanging="gvUsuarios_PageIndexChanging" 
                    DataKeyNames="contraseña" style="margin-bottom: 0px">
                    <Columns>
                        <asp:BoundField DataField="dni" HeaderText="Dni" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="apellidop" HeaderText="Apellidop" />
                        <asp:BoundField DataField="apellidom" HeaderText="Apellidom" />
                        <asp:BoundField DataField="correo" HeaderText="CORREO" />
                        <asp:BoundField DataField="telefono" HeaderText="telefono" />
                        <asp:BoundField DataField="direccion" HeaderText="DIRECCION" />
                        <asp:BoundField DataField="nick" HeaderText="nick" />
                        <asp:BoundField DataField="contraseña" HeaderText="contraseña"  />
                        <asp:BoundField DataField="perfil" HeaderText="PERFIL" />
                        
                        <asp:TemplateField HeaderText="Seleccionar" ShowHeader="False">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Select" 
                                    ImageUrl="~/images/editar.png" CausesValidation="False" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="White" />
                <RowStyle ForeColor="#0099FF" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style8" colspan="7">
                &nbsp;</td>
        </tr>
        
    </table>
 </div>

</asp:Content>
