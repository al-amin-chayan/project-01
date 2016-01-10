<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryView.aspx.cs" Inherits="CountryCityManagementApp.CountryView" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content=""/>

    <title>View Countries</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <div class="container">
        <!-- The justified navigation menu is meant for single line per list item.
           Multiple lines will require custom code not provided by Bootstrap. -->
        <div class="masthead">
            <h3 class="text-muted">Country City Information Management System</h3>
            <nav>
                <ul class="nav nav-justified">
                    <li><a href="Index.aspx">Home</a></li>
                    <li><a href="Index.aspx">Country Entry</a></li>
                    <li><a href="CityEntry.aspx">City Entry</a></li>
                    <li><a href="Index.aspx">View Cities</a></li>
                    <li class="active"><a href="CountryView.aspx">View Countries</a></li>
                </ul>
            </nav>
        </div>
        <form id="CountrySearchForm" runat="server" class="form-horizontal">
            <div class="row" style="margin-top: 20px;">
                <div class="col-xs-6 col-xs-offset-3">
                    <div class="panel panel-default">
                        <div class="panel-heading">Search Criteria</div>
                        <div class="panel-body">
                            <div class="form-group">
                                <label for="countryNameTextBox" class="col-sm-2 control-label">Name</label>
                                <div class="col-sm-10">
                                    <div class="input-group">
                                        <asp:TextBox ID="countryNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                        <span class="input-group-btn">
                                            <asp:Button ID="searchButton" runat="server" Text="Search" CssClass="btn btn-default" OnClick="searchButton_Click" />
                                        </span>
                                    </div>
                                    <!-- /input-group -->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix"></div>
            <div class="row">
                
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Country List</h3>
                    </div>
                    <div class="panel-body">
                        <asp:GridView ID="countryGridView" runat="server"
                            CssClass="table table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False" PageSize="3">
                            <Columns>
                                <asp:BoundField DataField="Sl" HeaderText="Sl#" />
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="About" HeaderText="About" />
                                <asp:BoundField DataField="TotalCities" HeaderText="No. of Cities" />
                                <asp:BoundField DataField="TotalCityDwellers" HeaderText="No. of City Dwellers" />
                            </Columns>
                            <RowStyle CssClass="cursor-pointer" />
                        </asp:GridView>
                    </div>
                </div>

            </div>
        </form>
        <!-- Site footer -->
        <!-- #include file ="Inc/footer.html" -->

    </div>
    <!-- /container -->
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
