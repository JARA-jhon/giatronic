<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="ConsultarTelevision.aspx.cs" Inherits="WebVentas.ConsultarTelevision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       
	
    
  <link rel="stylesheet" href="css/demo-stylescontacto.css" />


<style type="text/css">
        .style9
        {
            height: 110px;
        }
    .style10
    {
        height: 155px;
    }
    .auto-style11 {
        width: 182px;
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
            <td colspan="2">
                <h1 class="style5">
                    Carrito de Compras Televisores</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="Button1" runat="server" BackColor="#0099FF" BorderColor="White" 
                    Font-Bold="True" ForeColor="White" Width=80px onclick="Button1_Click" 
                    Text="Ver Carrito" />
            &nbsp;
                <asp:Button ID="btnSalir" runat="server" BackColor="#0099FF" 
                    BorderColor="White" Font-Bold="True" ForeColor="White" Width=75px 
                    Text="Salir" CausesValidation="False" onclick="btnSalir_Click" />
            </td>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="auto-style1">             

                   <asp:TextBox ID="txtNroPedido" runat="server" TabIndex="1" 
                onkeypress="javascript:return solonumeros(e)" Visible="False"></asp:TextBox>
                
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/btn_buscar.png" 
                     Width="30px" OnClick="ImageButton1_Click" />
                Marca          
                <asp:DropDownList ID="ddlMarca" runat="server" >
                </asp:DropDownList>                                 
                
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/btn_buscar.png" 
                     Width="30px" OnClick="ImageButton2_Click" />
                 Tipo Pantalla          
                <asp:DropDownList ID="ddlPantalla" runat="server" >
                </asp:DropDownList>                 
                
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/btn_buscar.png" 
                     Width="30px" OnClick="ImageButton3_Click" />
                 Tecnologia          
                <asp:DropDownList ID="ddlTecnologia" runat="server">
                </asp:DropDownList>                 
                

            </td>
                
            <td class="style4" colspan="2">
                <asp:DataList ID="dlAutos" runat="server" RepeatColumns="5" 
                    onselectedindexchanged="dlAutos_SelectedIndexChanged" 
                    RepeatDirection="Horizontal" CellPadding="4" ForeColor="#333333">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <EditItemStyle BorderColor="#0099FF" BorderStyle="Solid" BorderWidth="1px" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BorderColor="#0099FF" BorderStyle="Solid" BorderWidth="1px" BackColor="#F7F6F3" ForeColor="#333333" />
                  
                    <ItemTemplate>
                    
                        <table class="style1" border="4">
                            <tr>
                                <td class="style10">
                                    <asp:Image ID="Image1" runat="server" 
                                        ImageUrl='<%# Eval("img") %>' Width="200" Height="175" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center; vertical-align: middle">
                                    <span class="style5"><strong>Ver Detalle =&gt;</strong></span><asp:ImageButton ID="btnDetalle" runat="server" CommandName="Select" 
                                        ImageUrl="~/images/carrito.png" Width="35px" />
                                    <br />
                                    <asp:Label 
                                        ID="lblCodigo" runat="server" Text='<%# Eval("Codigo") %>'></asp:Label>
                                    &nbsp;<asp:Label ID="lblProveedor" runat="server" Text='<%# Eval("Proveedor") %>' 
                                        Visible="False"></asp:Label>
                                         <asp:Label ID="lblTecnologia" runat="server" Text='<%# Eval("Tecnologia") %>' 
                                        Visible="False"></asp:Label>
                                        <asp:Label ID="lblCategoria" runat="server" Text='<%# Eval("Categoria") %>' 
                                        Visible="False"></asp:Label>
                                         <asp:Label ID="lblResolucion" runat="server" Text='<%# Eval("Resolucion") %>' 
                                        Visible="False"></asp:Label>
                                            <asp:Label ID="lblPulgadas" runat="server" Text='<%# Eval("Pulgadas") %>' 
                                        Visible="False"></asp:Label>
                                        <asp:Label ID="lblCaracteristicas" runat="server" Text='<%# Eval("Caracteristicas") %>' 
                                        Visible="False"></asp:Label>
                                        S/.<asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("Precio") %>'></asp:Label>
                                        <br />
                                        <asp:Label ID="lblStock" runat="server" Text='<%# Eval("Stock") %>' 
                                        Visible="False"></asp:Label>

                                 
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
    </table>
    </div>
        
</asp:Content>
