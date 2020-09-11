﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="Fotos.aspx.cs" Inherits="WebVentas.Fotos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

      <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="dashboard clearfix">
     <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

    <head>
       
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <meta name="description" content="Hover Slide Effect with jQuery" />
        <meta name="keywords" content="jquery, slide, hover, effect, animation, fancy, entry page, fade in"/>
		<link rel="shortcut icon" href="../favicon.ico" type="image/x-icon"/>
        <link rel="stylesheet" href="css/galeria.css" type="text/css" media="screen"/>
		<script src="js/cufon-yui.js" type="text/javascript"></script>
		<script src="js/Cantarell.font.js" type="text/javascript"></script>
		<script type="text/javascript">
		    Cufon.replace('a,h3');
		    Cufon.replace('h1', {
		        textShadow: '0px 1px #fff'
		    });
		    Cufon.replace('h2', {
		        textShadow: '0px 1px #fff'
		    });
		</script>
        <style type="text/css">
			*{
				margin:0;
				padding:0;
			}
			body{
				background:#FFF url(bg.gif) repeat top left;
				font-family:Arial, Helvetica, sans-serif;
				font-size:12px;
			}
			h1,h2{
				font-weight:normal;

			}
			h2{
				float:right;
				margin-top:35px;
				color:#999;
			}
			h1{
				color:#777;
				font-size:45px;
				float:left;
				margin:10px;
			}
			h3{
				color:#777;
				display:block;
				clear:both;
				font-weight:normal;
				font-size:16px;
				margin:10px;
				font-style:italic;
				text-align:center;
}
			.content{
				width:900px;
				position:relative;
				margin:20px auto 0px auto;
			}
			span.reference{
				font-family:Arial;
				text-align:center;
				font-size:12px;
				display:block;
				margin-top:20px;
			}
			span.reference a{
				color:#999;
				text-transform:uppercase;
				text-decoration:none;
				margin-right:20px;
			}
		</style>
    </head>

    <body>
		    <br>
        <br><br>
		<div class="content">
					
			<div id="hs_container" class="hs_container">
				<div class="hs_area hs_area1">
					<img class="hs_visible" src="images/area1/1.jpg" alt=""/>
					<img src="images/area1/2.jpg" alt=""/>
					<img src="images/area1/3.jpg" alt=""/>
				</div>
				<div class="hs_area hs_area2">
					<img class="hs_visible" src="images/area2/1.jpg" alt=""/>
					<img src="images/area2/2.jpg" alt=""/>
					<img src="images/area2/3.jpg" alt=""/>
				</div>
				<div class="hs_area hs_area3">
					<img class="hs_visible" src="images/area3/1.jpg" alt=""/>
					<img src="images/area3/2.jpg" alt=""/>
					<img src="images/area3/3.jpg" alt=""/>
				</div>
				<div class="hs_area hs_area4">
					<img class="hs_visible" src="images/area4/1.jpg" alt=""/>
					<img src="images/area4/2.jpg" alt=""/>
					<img src="images/area4/3.jpg" alt=""/>
				</div>
				<div class="hs_area hs_area5">
					<img class="hs_visible" src="images/area5/1.jpg" alt=""/>
					<img src="images/area5/2.jpg" alt=""/>
					<img src="images/area5/3.jpg" alt=""/>
				</div>
			</div>

			<div>
			
				<span class="reference">
					
				</span>
			</div>
		</div>
		
        <!-- The JavaScript -->
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.min.js"></script>
		<script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
        <script type="text/javascript">
            $(function () {
                //custom animations to use
                //in the transitions
                var animations = ['right', 'left', 'top', 'bottom', 'rightFade', 'leftFade', 'topFade', 'bottomFade'];
                var total_anim = animations.length;
                //just change this to one of your choice
                var easeType = 'swing';
                //the speed of each transition
                var animSpeed = 450;
                //caching
                var $hs_container = $('#hs_container');
                var $hs_areas = $hs_container.find('.hs_area');

                //first preload all images
                $hs_images = $hs_container.find('img');
                var total_images = $hs_images.length;
                var cnt = 0;
                $hs_images.each(function () {
                    var $this = $(this);
                    $('<img/>').load(function () {
                        ++cnt;
                        if (cnt == total_images) {
                            $hs_areas.each(function () {
                                var $area = $(this);
                                //when the mouse enters the area we animate the current
                                //image (random animation from array animations),
                                //so that the next one gets visible.
                                //"over" is a flag indicating if we can animate 
                                //an area or not (we don't want 2 animations 
                                //at the same time for each area)
                                $area.data('over', true).bind('mouseenter', function () {
                                    if ($area.data('over')) {
                                        $area.data('over', false);
                                        //how many images in this area?
                                        var total = $area.children().length;
                                        //visible image
                                        var $current = $area.find('img:visible');
                                        //index of visible image
                                        var idx_current = $current.index();
                                        //the next image that's going to be displayed.
                                        //either the next one, or the first one if the current is the last
                                        var $next = (idx_current == total - 1) ? $area.children(':first') : $current.next();
                                        //show next one (not yet visible)
                                        $next.show();
                                        //get a random animation
                                        var anim = animations[Math.floor(Math.random() * total_anim)];
                                        switch (anim) {
                                            //current slides out from the right
                                            case 'right':
                                                $current.animate({
                                                    'left': $current.width() + 'px'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'left': '0px'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the left
                                            case 'left':
                                                $current.animate({
                                                    'left': -$current.width() + 'px'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'left': '0px'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the top	
                                            case 'top':
                                                $current.animate({
                                                    'top': -$current.height() + 'px'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'top': '0px'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the bottom	
                                            case 'bottom':
                                                $current.animate({
                                                    'top': $current.height() + 'px'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'top': '0px'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the right	and fades out
                                            case 'rightFade':
                                                $current.animate({
                                                    'left': $current.width() + 'px',
                                                    'opacity': '0'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'left': '0px',
												        'opacity': '1'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the left and fades out	
                                            case 'leftFade':
                                                $current.animate({
                                                    'left': -$current.width() + 'px', 'opacity': '0'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'left': '0px',
												        'opacity': '1'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the top and fades out	
                                            case 'topFade':
                                                $current.animate({
                                                    'top': -$current.height() + 'px',
                                                    'opacity': '0'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'top': '0px',
												        'opacity': '1'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                                //current slides out from the bottom and fades out	
                                            case 'bottomFade':
                                                $current.animate({
                                                    'top': $current.height() + 'px',
                                                    'opacity': '0'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'top': '0px',
												        'opacity': '1'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                            default:
                                                $current.animate({
                                                    'left': -$current.width() + 'px'
                                                },
												animSpeed,
												easeType,
												function () {
												    $current.hide().css({
												        'z-index': '1',
												        'left': '0px'
												    });
												    $next.css('z-index', '9999');
												    $area.data('over', true);
												});
                                                break;
                                        }
                                    }
                                });
                            });

                            //when clicking the hs_container all areas get slided
                            //(just for fun...you would probably want to enter the site
                            //or something similar)
                            $hs_container.bind('click', function () {
                                $hs_areas.trigger('mouseenter');
                            });
                        }
                    }).attr('src', $this.attr('src'));
                });


            });
        </script>
    </body>
       </div>
</asp:Content>
