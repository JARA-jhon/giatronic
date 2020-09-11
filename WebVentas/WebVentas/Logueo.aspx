<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="Logueo.aspx.cs" Inherits="WebVentas.Logueo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

      <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
    
    <style type="text/css">
        .style8
        {
            height: 23px;
        }
        .style10
        {
            height: 23px;
            color: #0099FF;
        }
        .style11
        {
            height: 23px;
            text-align: right;
            color: #0099FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br>
      <br>
    <div class="dashboard clearfix">
        
        <table class="style1">
            <tr>
                <td align="center" class="style8" colspan="4">
                </td>
                <td align="center" class="style8" colspan="4">
                </td>
            </tr>
            <tr>
                <td align="center" class="style10" colspan="8">
                    Ingrese su Usuario y Contraseña</td>
            </tr>
            <tr>
                <td align="center" class="style8" colspan="4">
                    </td>
                <td align="center" class="style8" colspan="4">
                    </td>
            </tr>
            <tr>
                <td align="center" class="style8" width="10%">
                    &nbsp;</td>
                <td align="center" class="style8" width="10%">
                    &nbsp;</td>
                <td align="center" class="style8" width="10%">
                    &nbsp;</td>
                <td class="style11" width="13%">
                    Usuario:</td>
                <td class="style8" width="10%" style="text-align: center">
                    <asp:TextBox ID="txtUsuario" runat="server" TabIndex="1"></asp:TextBox>
                </td>
                <td class="style8" width="5%" style="text-align: center">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsuario" Display="Dynamic" ErrorMessage="*" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td align="left" class="style8" width="15%">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Ingresar" BackColor="#0099FF" BorderColor="White" Font-Bold="True" 
                        ForeColor="White" Width="75px" TabIndex="3" />
                </td>
                <td align="center" class="style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style8">
                    &nbsp;</td>
                <td align="center" class="style8">
                    &nbsp;</td>
                <td align="center" class="style8">
                    &nbsp;</td>
                <td class="style11">
                    Password:</td>
                <td class="style8" style="text-align: center">
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" TabIndex="2"></asp:TextBox>
                </td>
                <td class="style8" width="5%" style="text-align: center">&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPass" Display="Dynamic" ErrorMessage="*" 
                        Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td align="left" class="style8">
                    &nbsp;</td>
                <td align="center" class="style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="8">
                    <asp:Label ID="lblMensaje" runat="server" style="color: #0099FF"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style8" colspan="4">
                    </td>
                <td align="center" class="style8" colspan="4">
                    </td>
            </tr>
            <tr>
                <td align="center" class="style10" colspan="8">
                    Aun no te has Registrado? Qué Esperas! Registrate 
                    <a href="RegistrarUsuario.aspx" tabindex="4">Aquí</a></td>
            </tr>
        </table>        
    </div>
</asp:Content>
