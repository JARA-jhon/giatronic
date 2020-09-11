<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebVentas.cabezera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <br>
  
       <!DOCTYPE html>
<html>
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  <title>Windows-8-like Animations with CSS3 and jQuery</title>

  <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

</head>

<body>
<br>
<div class="demo-wrapper">

  <div class="s-page random-restored-page">
    <h2 class="page-title">Some minimized App</h2>
    <div class="close-button s-close-button">x</div>
  </div>
  <div class="s-page custom-page">
    <h2 class="page-title">Thank You!</h2>
    <div class="close-button s-close-button">x</div>
  </div>

  <div class="r-page random-r-page">
      
    <div class="page-content">
      <h2 class="page-title">Horario Nacional para Colombia</h2>
      <center><div style="text-align:center;width:350px;padding:0.5em 0;"> <h2><a style="text-decoration:none;" href="http://www.zeitverschiebung.net/es/city/3936456"><span style="color:gray;">Hora actual en</span><br />Bogota, Lima </a></h2>
          <iframe src="http://www.zeitverschiebung.net/clock-widget-iframe?language=es&timezone=America%2FLima" height="130" frameborder="0" seamless style="width: 186%"></iframe> <small style="color:gray;">&copy; <a href="http://www.zeitverschiebung.net/es/" style="color: gray;">Diferencia horaria</a></small> </div></center>
    </div>
    
    <div class="close-button r-close-button">x</div>
  </div>
<!--each tile should specify what page type it opens (to determine which animation) and the corresponding page name it should open-->
  <div class="dashboard clearfix">
    <ul class="tiles">
      <div class="col1 clearfix">

          <a href="Nosotros.aspx">
        <li class="tile tile-big tile-1 slideTextUp">
          <div><p>Precio y Garantia en un solo lugar</p></div>
          <div><p>Nosotros</p></div>
        </li></a>
          <a href="Calendario.aspx">
        <li class="tile tile-small tile tile-2 slideTextRight">
          <div><p class="icon-arrow-right"></p></div>
          <div><p>Calendario a tu disposicion</p></div>
        </li></a>

        <li class="tile tile-small last tile-3" data-page-type="r-page" data-page-name="random-r-page">
          <p class="icon-calendar-alt-fill"></p>
        </li>

           <a href="Contacto.aspx">
        <li class="tile tile-big tile-4 fig-tile" >
          <figure>
            <img src="images/contactenos.jpg" />
            <figcaption class="tile-caption caption-left">Contactenos Estamos a tu disposicion</figcaption>
          </figure>
        </li>
               </a>

      </div>

      <div class="col2 clearfix">
           <a href="Ofertas.aspx">
        <li class="tile tile-big tile-5" >
          <div><p><span class="icon-cloudy"></span>Ofertas del Día</p></div>
        </li>
               </a>
          <a href="Chat.html">
        <li class="tile tile-big tile-6 slideTextLeft">
          <div><p><span class="icon-skype"></span>MyChat</p></div>
          <div><p>Chatea Ahora</p></div>
        </li>
              </a>
        <!--Tiles with a 3D effect should have the following structure:
            1) a container inside the tile with class of .faces
            2) 2 figure elements, one with class .front and the other with class .back-->
         <a href="Fotos.aspx">
          <li class="tile tile-small tile-7 rotate3d rotate3dX">
          <div class="faces">
            <div class="front"><span class="icon-picassa"></span></div>
            <div class="back"><p>Coleccion Imagenes</p></div>
          </div>
        </li>
             </a>

        <li class="tile tile-small last tile-8 rotate3d rotate3dY" data-page-type="r-page" data-page-name="random-r-page">
          <div class="faces">
            <div class="front"><span class="icon-instagram"></span></div>
            <div class="back"><p>Launch Instagram</p></div>
          </div>
        </li>
      </div>
        
      <div class="col3 clearfix">      
          <a href="ConsultarTelevision.aspx">
        <li class="tile tile-2xbig tile-9 fig-tile">
          <figure>
            <img src="images/carrito-compras.jpg" />
            <figcaption class="tile-caption caption-bottom">Carrito de compras: Visualize nuestros productos y registrese para poder comprarlos 
            </figure>
        </li>
          </a>

        <li class="tile tile-big tile-10" data-page-type="s-page" data-page-name="custom-page">
          <div><p>Windows-8-like Animations with CSS3 &amp; jQuery &copy; Sara Soueidan. Licensed under MIT.</p></div>
        </li>
      </div>
    </ul>
  </div><!--end dashboard-->

</div>
<!--====================================end demo wrapper================================================-->
  <script src="js/jquery-1.8.2.min.js"></script>
  <script src="js/scripts.js"></script>

   
          &nbsp;

</body>
</html>

</asp:Content>
