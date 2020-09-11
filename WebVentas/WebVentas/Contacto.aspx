<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="WebVentas.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
     <link rel="stylesheet" href="css/demo-stylescontacto.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         <br>
        <br><br>
    <div>
    <iframe src="https://mapsengine.google.com/map/embed?mid=zEAJgn2sVc0U.kzhJwuOBBLug" width="1350" height="340"></iframe>
        </div>   
     <div class="dashboard clearfix">
         <center>SIGANOS EN NUESTRAR PAGINAS OFICIALES</center>
    <div class="container cont cent">
    	<div class="well">
	
            <ul class="thumbnails">

		    <li class="span3 tile tile-double">
		        <a href="https://www.facebook.com/profile.php?id=100006343365734" target="_blank">
		            <img src="images/iconmonstr-facebook-4-icon.png">
		            <h2>Facebook</h2>                    
                    
		        </a>
		    </li>
		    <li class="span3 tile tile-purple" >
		        <a href="#" >
		            <img src="images/g+.png">
		            <h2>Google+</h2>
		        </a>
		    </li>
		    <li class="span3 tile tile-red">
		        <a href="http://www.youtube.com/" target="_blank">                     
		            <img src="images/youtube-xxl.png">
		            <h2>YouTube</h2>
		        </a>
		    </li>	
		    <li class="span3 tile tile-teal tile-double">
		        <a href="https://www.facebook.com/l.php?u=https%3A%2F%2Ftwitter.com%2FTocles123&h=fAQGlTujU" target="_blank">
		            <img src="images/4589749544.png">
		            <h2>Twitter</h2>
		        </a>
		    </li>
		    <li class="span3 tile tile-green">
		        <a href="#" >
		            <img src="images/in.png">
		            <h2>Linked In</h2>
		        </a>
		    </li>	
                
		  </ul>
	</div>
            <!-- Do not change the code! -->
<a id="foxyform_embed_link_174724" href="http://es.foxyform.com/">foxyform</a>
<script type="text/javascript">
    (function (d, t) {
        var g = d.createElement(t),
            s = d.getElementsByTagName(t)[0];
        g.src = "http://es.foxyform.com/js.php?id=174724&sec_hash=ccf990f1787&width=350px";
        s.parentNode.insertBefore(g, s);
    }(document, "script"));
</script>
        <div>
            <div id="after_submit"></div>
<form id="contact_form" action="#" method="POST" enctype="multipart/form-data">
  <div class="row">
    <label class="required" for="name">Your name:</label><br />
    <input id="name" class="input" name="name" type="text" value="" size="30" /><br />
    <span id="name_validation" class="error_message"></span>
  </div>
  <div class="row">
    <label class="required" for="email">Your email:</label><br />
    <input id="email" class="input" name="email" type="text" value="" size="30" /><br />
    <span id="email_validation" class="error_message"></span>
  </div>
  <div class="row">
    <label class="required" for="message">Your message:</label><br />
    <textarea id="message" class="input" name="message" rows="7" cols="30"></textarea><br />
    <span id="message_validation" class="error_message"></span>
  </div>
    
    <input id="submit_button" type="submit" value="Send email" />
</form>
        </div>

<!-- Do not change the code! -->


               </div>
</div>

 
  
</asp:Content>
