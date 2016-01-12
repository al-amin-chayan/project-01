<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CountryCityManagementApp.Index" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="" />

    <title>CountryDropDown City Information Management System</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
    <link href="css/main.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <div class="container">
        <!-- #include file ="Inc/nav.html" --> 
        <!-- Jumbotron -->
        <div class="jumbotron">
            <h1>Project 01</h1>
            <p class="lead">This web application is for storing and retrieving information of several countries and their cities. Noted that, you are not authorized person for changing any specification.</p>
            <%--<p><a class="btn btn-lg btn-success" href="#" role="button">Get started today</a></p>--%>
        </div>

        <!-- Example row of columns -->
        <div class="row">
            <div class="col-lg-4">
                <h2 class="text-center">Nasrat Sharif Aveek</h2>
                <img src="img/nasrat_sharif.jpg" class="img-circle img-responsive img-thumbnail profile-pic" />
                <p class="text-justify" style="margin-top: 15px;">If time is money, Mr. Aveek is running out of time. Sometimes he prefer to use his face for emoticons. <span class="text-danger">WARNING: he has an attitude and he knows how to use it!</span> His daily routine: Get up, be awesome, go back to bed.</p>
                <p>
                    <a class="btn btn-default" href="https://bd.linkedin.com/in/nsaveek" target="_blank" role="button">
                        <i class="fa fa-linkedin-square"></i> View details &raquo;
                    </a>
                </p>
            </div>
            <div class="col-lg-4">
                <h2 class="text-center">Alamin Ahmed</h2>
                <img src="img/alamin_ahmed.jpg" class="img-circle img-responsive img-thumbnail profile-pic"  />
                <p class="text-justify" style="margin-top: 15px;">Mr Alamin is an energetic and enthusiastic person who enjoys a challenge and achieving personal goals. His present career aim is to work within IT because he enjoy working with computers, he enjoy the environment and find the work interesting and satisfying. The opportunity to learn new skills and work with new technologies is particularly attractive to him.</p>
                <p>
                    <a class="btn btn-default" href="https://bd.linkedin.com/in/nsaveek" target="_blank" role="button">
                        <i class="fa fa-facebook-official"></i> View details &raquo;
                    </a>
                </p>
            </div>
            <div class="col-lg-4">
                <h2 class="text-center">Al Amin Chayan</h2>
                <img src="img/chayan.jpg" class="img-circle img-responsive img-thumbnail profile-pic" />
                <p class="text-justify" style="margin-top: 15px;">Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa.</p>
                <p>
                    <a class="btn btn-default" href="http://stackoverflow.com/users/3113693/chayan?tab=profile" target="_blank" role="button">
                        <i class="fa fa-stack-overflow"></i> View details &raquo;
                    </a>
                </p>
            </div>
        </div>

        <!-- Site footer -->
        <!-- #include file ="Inc/footer.html" -->

    </div>
    <!-- /container -->
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
