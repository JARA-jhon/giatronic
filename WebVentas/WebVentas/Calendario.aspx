<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalUsuario.Master" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="WebVentas.Calendario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="js/modernizr-1.5.min.js"></script>

      <link rel="stylesheet" type="text/css" href="mb/css/metro-bootstrap.css">
	<link rel="stylesheet" href="mb/docs/font-awesome.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="dashboard clearfix">
    <!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<title>Shamcey - Metro Style Admin Template</title>
    <link rel="stylesheet" href="css/styles.css" type="text/css" />
<script type="text/javascript" src="jsc/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="jsc/jquery-migrate-1.1.1.min.js"></script>
<script type="text/javascript" src="jsc/jquery-ui-1.9.2.min.js"></script>
<script type="text/javascript" src="jsc/modernizr.min.js"></script>
<script type="text/javascript" src="jsc/bootstrap.min.js"></script>
<script type="text/javascript" src="jsc/fullcalendar.min.js" ></script>
<script type="text/javascript" src="jsc/jquery.cookie.js"></script>
<script type="text/javascript" src="jsc/custom.js"></script>
<script type='text/javascript'>

    jQuery(document).ready(function () {

        var date = new Date();
        var d = date.getDate();
        var m = date.getMonth();
        var y = date.getFullYear();

        var calendar = jQuery('#calendar').fullCalendar({
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            buttonText: {
                prev: '&laquo;',
                next: '&raquo;',
                prevYear: '&nbsp;&lt;&lt;&nbsp;',
                nextYear: '&nbsp;&gt;&gt;&nbsp;',
                today: 'today',
                month: 'month',
                week: 'week',
                day: 'day'
            },
            selectable: true,
            selectHelper: true,
            select: function (start, end, allDay) {
                var title = prompt('Event Title:');
                if (title) {
                    calendar.fullCalendar('renderEvent',
						{
						    title: title,
						    start: start,
						    end: end,
						    allDay: allDay
						},
						true // make the event "stick"
					);
                }
                calendar.fullCalendar('unselect');
            },
            editable: true,
            events: [
				{
				    title: 'All Day Event',
				    start: new Date(y, m, 1)
				},
				{
				    title: 'Meeting',
				    start: new Date(y, m, d, 10, 30),
				    allDay: false
				},
				{
				    title: 'Lunch',
				    start: new Date(y, m, d, 12, 0),
				    end: new Date(y, m, d, 14, 0),
				    allDay: false
				},
				{
				    title: 'Birthday Party',
				    start: new Date(y, m, d + 1, 19, 0),
				    end: new Date(y, m, d + 1, 22, 30),
				    allDay: false
				},
				{
				    title: 'Click for Google',
				    start: new Date(y, m, 28),
				    end: new Date(y, m, 29),
				    url: 'http://google.com/'
				}
            ]
        });

    });

</script>
</head>

<body>
      <br>
        <br><br>
<div class="mainwrapper">
    
       
    
    <div class="rightpanel">

        <div class="pageheader">
      
            <div class="pageicon"><span class="iconfa-calendar"></span></div>
            <div class="pagetitle">
                <h5>Events</h5>
                <h1>My Calendar</h1>
            </div>            
        </div><!--pageheader-->
        
        <div class="maincontent">
            <div class="maincontentinner">
                <div id='calendar'></div>
                
        
            </div><!--maincontentinner-->
        </div><!--maincontent-->
        
        
    </div><!--rightpanel-->
    
</div><!--mainwrapper-->

</body>
</html>
           
         </div>
</asp:Content>
