<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="MantenerTelevision.aspx.cs" Inherits="WebVentas.MantenerTelevision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

      <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css"> 

<script type="text/javascript">

</script>
<script type="text/javascript">
    function SoloNumeroDecimal(e, field) {
        key = e.keyCode ? e.keyCode : e.which
        // backspace
        if (key == 8) return true

        // 0-9 a partir del .decimal  
        if (field.value != "") {
            if ((field.value.indexOf(".")) > 0) {
                //si tiene un punto valida dos digitos en la parte decimal
                if (key > 47 && key < 58) {
                    if (field.value == "") return true
                    //regexp = /[0-9]{1,10}[\.][0-9]{1,3}$/
                    regexp = /[0-9]{2}$/
                    return !(regexp.test(field.value))
                }
            }
        }
        // 0-9 
        if (key > 47 && key < 58) {
            if (field.value == "") return true
            regexp = /[0-9]{7}/
            return !(regexp.test(field.value))
        }
        // .
        if (key == 46) {
            if (field.value == "") return false
            regexp = /^[0-9]+$/
            return regexp.test(field.value)
        }
        // other key
        return false
    }

</script>


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
        .style9
        {
            height: 23px;
            color: #0099FF;
        }
        .style10
        {
            height: 22px;
        }
        .style11
        {
            color: #0099FF;
            height: 22px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br>
      <br>
    <div class="dashboard clearfix">
    <table class="style1">
        <tr>
            <td colspan="10">
                <h1 class="style5">
                    Mantenimiento de Television</h1>
            </td>
        </tr>
        <tr>
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
            <td>
                &nbsp;</td>
            <td class="style5">
                Modelo:</td>
            <td width="20%">
                <asp:TextBox ID="txtmodelo" runat="server" 
                     TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtmodelo" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <%--onkeypress="javascript:return sololetras(event)"--%>
            <td class="style5">
                Proveedor:</td>
            <td>
                <asp:DropDownList ID="ddlidprov" runat="server" AutoPostBack="False" 
                      style="margin-left: 0px" TabIndex="2">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
           <tr>
            <td class="style5">
                Tecnologia:</td>
            <td>
                <asp:DropDownList ID="ddlcodtip" runat="server" AutoPostBack="False" 
                      TabIndex="2">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
           
            <td class="style5">
                Categoria:</td>
            <td>
                <asp:DropDownList ID="ddlcodcat" runat="server" AutoPostBack="False" 
                       TabIndex="2">
                </asp:DropDownList>
            </td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                Resolucion:</td>
            <td width="20%">
                <asp:TextBox ID="txtresolucion" runat="server" 
                    TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtresolucion" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style5">
                Tamaño:</td>
            <td width="20%">
                <asp:TextBox ID="txttamaño" runat="server" 
                     TabIndex="1" MaxLength="2"  onkeypress="javascript:return solonumeros(event)" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txttamaño" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                Caracteristica:</td>
            <td width="20%">
                <asp:TextBox ID="txtcaracteristica" runat="server" 
                    TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtcaracteristica" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                Precio:</td>
            <td width="20%">
                <asp:TextBox ID="txtprecio" runat="server" TabIndex="3" onkeypress="return SoloNumeroDecimal(event,this)"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPrecio" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="style5">
                Stock</td>
            <td>
                <asp:TextBox ID="txtstock" runat="server" TabIndex="4" onkeypress="javascript:return solonumeros(event)" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtStock" Display="Dynamic" ErrorMessage="*" 
                    Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5" colspan="4" style="vertical-align: middle">
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Imagen:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                <asp:FileUpload ID="FileUpload1" runat="server" TabIndex="5" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                </td>
            <td class="style10">
                </td>
            <td class="style10">
                </td>
            <td class="style11">
                </td>
            <td class="style10" colspan="3">
                &nbsp;</td>
            <td class="style10">
                </td>
            <td class="style10">
                </td>
            <td class="style10">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2">
&nbsp;&nbsp;&nbsp;<asp:Label ID="lblMensaje" runat="server" style="color: #0099FF"></asp:Label>
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
        </tr>
        <tr>
            <td colspan="10">
                <asp:Button ID="btnRegistrar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Registrar" onclick="btnRegistrar_Click" />
                <asp:Button ID="btnActualizar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Actualizar" onclick="btnActualizar_Click" />
                <asp:Button ID="btnEliminar" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Eliminar" onclick="btnEliminar_Click" />
                <asp:Button ID="btnSalir" runat="server" CausesValidation="False" 
                    BackColor="#0099FF" BorderColor="White" Font-Bold="True" ForeColor="White" 
                    Width=75px Text="Salir" OnClick="btnSalir_Click" />
                <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" 
                    BackColor="#0099FF" BorderColor="White" Font-Bold="True" ForeColor="White" 
                    Width=75px Text="Cancelar" OnClick="btnCancelar_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="10">
                <asp:GridView ID="gvTelevision" runat="server" Width="100%" 
                    AutoGenerateColumns="False" AllowPaging="True" 
                    onselectedindexchanged="gvTelevision_SelectedIndexChanged" PageSize="5" 
                    onpageindexchanging="gvTelevision_PageIndexChanging" DataKeyNames="img">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Modelo" />
                        <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" />
                        <asp:BoundField DataField="Tecnologia" HeaderText="Tecnologia" />
                        <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                        <asp:BoundField DataField="Resolucion" HeaderText="Resolucion" />
                          <asp:BoundField DataField="Pulgadas" HeaderText="Tamaño" />
                        <asp:BoundField DataField="Caracteristicas" HeaderText="Caracteristica" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" />
                        <asp:BoundField DataField="Img" HeaderText="Img" Visible="False" />
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
    </table>
 </div>

</asp:Content>
