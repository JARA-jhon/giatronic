<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="Ofertas.aspx.cs" Inherits="WebVentas.Ofertas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <link rel="stylesheet" href="css/demo-stylescontacto.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <div class="dashboard clearfix"> 

<div class="container cont">

	<div id="myCarousel" class="carousel slide">
		<div class="carousel-inner">
			<div class="item">
				<img src="images/watch_dogs_banner-HD.jpg" alt="">
				<div class="carousel-caption">
					<h4>VIDEOJUEGO: WATCH DOGS </h4>
					<p>Ambientado en un futuro cercano en el que el jugador tiene en su poder infinidad de gadgets y de artilugios tecnológicos con los que sembrar el caos a su alrededor para llevar a cabo diferentes tipos de misiones.</p>
				</div>
			</div>
			<div class="item">
				<img src="images/Tablet.jpg" alt="">
				<div class="carousel-caption">
					<h4>TABLET: LO MAS IMPORTANTE</h4>
					<p>Todas las consultoras y jefes de las organizaciones se han puesto de acuerdo a la hora de desvelar sus previsiones para este año, y aseguran que si ya en 2013 los tablets fueron protagonistas, en 2014 sus ventas se van a disparar.</p>
				</div>
			</div>
			<div class="item active">
				<img src="images/ps4-portada.jpg" alt="">
				<div class="carousel-caption">
					<h4>PS4: ESTADO PLAY</h4>
					<p>lleva unos meses en las tiendas y ya es la consola favorita de los compradores. Por hardware y sistema operativo se lo merece, pero sorprende lo que está logrando sin apenas juegos capaces de justificar la inversión.</p>
				</div>
			</div>
		</div>
		<a class="left carousel-control" href="#myCarousel" data-slide="prev">‹</a>
		<a class="right carousel-control" href="#myCarousel" data-slide="next">›</a>
	</div>



	<ul class="thumbnails">
		<li class="span4">
			<a class="thumbnail" href="#">
				<img src="images/prod1.jpg" alt="">
			</a>
			<div class="details">
			<h3>COMPUTADORA</h3>
			<p>Motherboard Biostar G31DM7 Procesador Intel Pentium Dual Core (E5300) 2.60 GHz, 800 MHz, 2MB Cache Disco Duro de 500GB SATA2, HITACHI, (3GBPS, 16MB, 7200RPM)
            </p>
			</div>
		</li>
		<li class="span4">
			<a class="thumbnail" href="#">
				<img src="images/prod2.jpg" alt="">
			</a>
			<div class="details">
			<h3>LAPTOP</h3>
			<p>Marca: Compaq Fabricante: Hewlett-Packard Modelo: Compaq CQ50-215NR Procesador: AMD Athlon 64 X2 QL-60 Sistema Operativo: Windows Vista Precio: $450 USD</p>
			</div>
		</li>
		<li class="span4">
			<a class="thumbnail" href="#">
				<img src="images/prod3.jpg" alt="">
			</a>
			<div class="details">
			<h3>VIDEOJUEGO</h3>
			<p>Watch Dogs está ambientado en un futuro cercano en el que el jugador tiene en su poder infinidad de gadgets y de artilugios tecnológicos con los que sembrar el caos a su alrededor para llevar a cabo diferentes tipos de misiones. </p>
			</div>
		</li>
		<li class="span4">
			<a class="thumbnail" href="#">
				<img src="images/prod4.jpg" alt="">
			</a>
			<div class="details">
			<h3>CONSOLA</h3>
			<p>System Memory: Unified 8GB DDR5 RAM Video Memory: 2.2 GB CPU: x86-64 AMD "Jaguar" 8 cores GPU: 1.84 TFLOPS, AMD next-generation "Radeon" based graphics engine Puertos: Super-Speed USB (USB 3.0) AUX, Communication Ethernet (10BASE-T, 100BASE-TX, 1000BASE-T), IEEE 802.11b/g/n, Bluetooth 2.1 (EDR)
            </p>
			</div>
		</li>
		<li class="span4">
			<a class="thumbnail" href="#">
				<img src="images/prod5.jpg" alt="">
			</a>
			<div class="details">
			<h3>TABLET</h3>
			<p>Sistema CPU, VIA  8650( 800MHZ) Sistema Operativo, android 2.2 Memoria RAM,  Hyunda 256MB DDR2 NAND Flash, Samsung 2GB(FAT Disc Format) Memoria externa, Hasta 32 Gb</p>
			</div>
		</li>
		<li class="span4">
			<a class="thumbnail" href="#">
				<img src="images/prod6.jpg" alt="">
			</a>
			<div class="details">
			<h3>ALL IN ONE</h3>
			<p>All in One Acer de 19 pulgadas con procesador AMD E1, 8GB de memoria, 1TB de disco duro y gráfica dedicada AMD Radeon HD de 1GB Precio 499</p>
			</div>
		</li>
	</ul>


</div>

</div>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
<script src="mb/docs/bootstrap-transition.js"></script>
    <script src="mb/docs/bootstrap-carousel.js"></script>
</asp:Content>
