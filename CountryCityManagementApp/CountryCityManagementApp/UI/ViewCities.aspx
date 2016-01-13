<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryCityManagementApp.ViewCities" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="" />

    <title>View Cities</title>

    <!-- Bootstrap core CSS -->
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
    <link href="//cdn.datatables.net/1.10.10/css/jquery.dataTables.min.css" rel="stylesheet" />

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
                    <li><a href="CountryEntry.aspx">Country Entry</a></li>
                    <li><a href="CityEntry.aspx">City Entry</a></li>
                    <li class="active"><a href="ViewCities.aspx">View Cities</a></li>
                    <li><a href="CountryView.aspx">View Countries</a></li>
                </ul>
            </nav>
        </div>

        <form id="CityViewForm" runat="server" class="form-horizontal">
            <div class="row" style="margin-top: 20px;">
                <div class="col-xs-6 col-xs-offset-3">
                    <div class="panel panel-default">
                        <div class="panel-heading">Search Criteria</div>
                        <div class="panel-body">
                            <div class="col-xs-12">
                                <div class="form-group">
                                    <div class="input-group">
                                        <span class="input-group-addon">
                                            <asp:RadioButton ID="searchByCityNameRadioButton" GroupName="a" Checked="True" runat="server" />
                                        </span>
                                        <span class="input-group-addon" id="sizing-addon1">City Name</span>
                                        <asp:TextBox ID="cityNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="clearfix"></div>
                                    <!-- /input-group -->
                                    <div class="input-group" style="margin-top: 15px;">
                                        <span class="input-group-addon">
                                            <asp:RadioButton ID="searchByCountryNameRadioButton" GroupName="a" runat="server" />
                                        </span>
                                        <span class="input-group-addon" id="sizing-addon2">Country&nbsp;&nbsp;&nbsp;&nbsp;</span>
                                        <asp:DropDownList ID="countryDropDownList" runat="server" CssClass="form-control input-sm"></asp:DropDownList>
                                    </div>
                                    <!-- /input-group -->
                                    <div class="clearfix"></div>
                                    <div class="form-group" style="margin-top: 15px;">
                                        <div class="col-sm-12">
                                            <asp:Button ID="searchButton" runat="server" CssClass="btn btn-primary pull-right" Text="Search" OnClick="searchButton_Click" />
                                        </div>
                                    </div>
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
                        <h3 class="panel-title">View Cities</h3>
                    </div>
                    <div class="panel-body">
                        <asp:GridView ID="outputGridView" runat="server"
                            CssClass="table table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False" PageSize="3">
                            <Columns>
                                <asp:BoundField DataField="Sl" HeaderText="Sl#" />
                                <asp:BoundField DataField="CityName" HeaderText="City Name" />
                                <asp:BoundField DataField="CityAbout" HtmlEncode="False" HeaderText="About" />
                                <asp:BoundField DataField="NoOfDwellers" HeaderText="No. Of Dwellers" />
                                <asp:BoundField DataField="Location" HeaderText="Location" />
                                <asp:BoundField DataField="Weather" HeaderText="Weather" />
                                <asp:BoundField DataField="CountryName" HeaderText="Country" />
                                <asp:BoundField DataField="CountryAbout" HtmlEncode="False" HeaderText="About Country" />
                            </Columns>
                            <RowStyle CssClass="cursor-pointer" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </form>
        <!-- Site footer -->
        <!-- #include file ="../Inc/footer.html" -->
    </div>
    <!-- /container -->
    <script src="../js/jquery-2.1.4.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery.dataTables.min.js"></script>
    <script>
        $(function () {
            $('#outputGridView').DataTable();
        });
    </script>
</body>
</html>
