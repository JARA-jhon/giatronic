<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="MantenerCategoria.aspx.cs" Inherits="WebVentas.MantenerCategoria" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <br>
      <br>
    <div class="dashboard clearfix">
     <table class="style1">
        <tr>
            <td colspan="10">
                <h1 class="style5">
                    Mantenimiento Categoria</h1>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                Categoria:</td>
            <td width="20%">    
                <asp:TextBox ID="txtcodcat" runat="server" 
                    onkeypress="javascript:return sololetras(event)" TabIndex="1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtcodcat" Display="Dynamic" ErrorMessage="*" 
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
                Descripcion:</td>
            <td>
                <asp:TextBox ID="txtdescat" runat="server" 
                    onkeypress="javascript:return sololetras(event)" TabIndex="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtdescat" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
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
                Detalle:</td>
            <td>
                <asp:TextBox ID="txtdetalle" runat="server" TabIndex="4"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtdetalle" Display="Dynamic" ErrorMessage="*" Font-Bold="True" 
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
                <asp:GridView ID="gvTecnologia" runat="server" Width="1005px" 
                    AutoGenerateColumns="False" 
                    onpageindexchanging="gvTecnologia_PageIndexChanging" 
                    onselectedindexchanged="gvTecnologia_SelectedIndexChanged" 
                    AllowPaging="True" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="codcat" HeaderText="Categoria" />
                        <asp:BoundField DataField="descat" HeaderText="Descripcion" />
                        <asp:BoundField DataField="detalle" HeaderText="Detalle" />
                        
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
