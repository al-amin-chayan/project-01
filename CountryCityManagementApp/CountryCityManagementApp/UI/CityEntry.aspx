<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryCityManagementApp.CityEntry" ValidateRequest="false" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />

    <title>City Entry</title>

    <!-- Bootstrap core CSS -->
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
    <link href="//cdn.datatables.net/1.10.10/css/jquery.dataTables.min.css" rel="stylesheet" />

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="../css/froala_editor.css" />
    <link rel="stylesheet" href="../css/froala_style.css" />
    <link rel="stylesheet" href="../css/plugins/code_view.css" />
    <link rel="stylesheet" href="../css/plugins/image_manager.css" />
    <link rel="stylesheet" href="../css/plugins/image.css" />
    <link rel="stylesheet" href="../css/plugins/table.css" />
    <link rel="stylesheet" href="../css/plugins/video.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/codemirror/5.3.0/codemirror.min.css" />
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        #messageLabel {
            display: block;
        }
    </style>
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
                    <li class="active"><a href="CityEntry.aspx">City Entry</a></li>
                    <li><a href="ViewCities.aspx">View Cities</a></li>
                    <li><a href="CountryView.aspx">View Countries</a></li>
                </ul>
            </nav>
        </div>
        <form id="CityEntryForm" runat="server" class="form-horizontal">
            <div class="row" style="margin-top: 20px;">
                <div class="col-xs-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">City Entry</h3>
                        </div>
                        <div class="panel-body">
                            <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                            <div class="clearfix"></div>
                            <div class="row">
                                <div class="form-group">
                                    <label for="cityNameTextBox" class="col-sm-2 control-label">Name</label>
                                    <div class="col-sm-12 col-md-4">
                                        <asp:TextBox ID="cityNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <label for="aboutTextBox" class="col-sm-2 control-label">About</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="aboutTextBox" runat="server" Style="margin-top: 30px;" CssClass="form-control" Rows="10" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <label for="dwellersTextBox" class="col-sm-2 control-label">No. of Dwellers</label>
                                    <div class="col-sm-12 col-md-4">
                                        <asp:TextBox ID="dwellersTextBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <label for="locationTextBox" class="col-sm-2 control-label">Location</label>
                                    <div class="col-sm-12 col-md-4">
                                        <asp:TextBox ID="locationTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <label for="weatherTextBox" class="col-sm-2 control-label">Weather</label>
                                    <div class="col-sm-12 col-md-4">
                                        <asp:TextBox ID="weatherTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <label for="countryDropDownList" class="col-sm-2 control-label">Country</label>
                                    <div class="col-sm-12 col-md-4">
                                        <asp:DropDownList ID="countryDropDownList" runat="server" CssClass="form-control" AppendDataBoundItems="True">
                                            <asp:ListItem Text="<Select Country>" Value="0" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <asp:Button ID="saveButton" runat="server" Text="Save" CssClass="btn btn-default" OnClick="saveButton_Click" />
                                        <a href="Index.aspx" role="button" class="btn btn-default">Cancel</a>
                                        <%--<asp:Button ID="cancelButton" runat="server" Text="Cancel" CssClass="btn btn-default" OnClick="cancelButton_Click" />--%>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

            <div class="row" style="margin-top: 20px;">
                <div class="col-xs-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">City List</h3>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="cityGridView" runat="server"
                                CssClass="table table-hover table-striped" GridLines="None"
                                AutoGenerateColumns="False" PageSize="3">
                                <Columns>
                                    <asp:BoundField DataField="Sl" HeaderText="Sl#" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="NoOfDwellers" HeaderText="No. Of Dwellers" />
                                    <asp:BoundField DataField="Country" HeaderText="Country" />
                                </Columns>
                                <RowStyle CssClass="cursor-pointer" />
                            </asp:GridView>
                        </div>
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

    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/codemirror/5.3.0/codemirror.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/codemirror/5.3.0/mode/xml/xml.min.js"></script>
    <script type="text/javascript" src="../js/froala_editor.min.js"></script>
    <script type="text/javascript" src="../js/plugins/align.min.js"></script>
    <script type="text/javascript" src="../js/plugins/code_beautifier.min.js"></script>
    <script type="text/javascript" src="../js/plugins/code_view.min.js"></script>
    <script type="text/javascript" src="../js/plugins/image.min.js"></script>
    <script type="text/javascript" src="../js/plugins/image_manager.min.js"></script>
    <script type="text/javascript" src="../js/plugins/link.min.js"></script>
    <script type="text/javascript" src="../js/plugins/lists.min.js"></script>
    <script type="text/javascript" src="../js/plugins/paragraph_format.min.js"></script>
    <script type="text/javascript" src="../js/plugins/paragraph_style.min.js"></script>
    <script type="text/javascript" src="../js/plugins/table.min.js"></script>
    <script type="text/javascript" src="../js/plugins/video.min.js"></script>
    <script type="text/javascript" src="../js/plugins/url.min.js"></script>
    <script type="text/javascript" src="../js/plugins/entities.min.js"></script>
    <script src="../js/jquery.validate.min.js"></script>
    <script src="../js/jquery.dataTables.min.js"></script>
    <script>
        $.validator.setDefaults({
            highlight: function (element) {
                $(element).closest('.form-group').addClass('has-error');
            },
            unhighlight: function (element) {
                $(element).closest('.form-group').removeClass('has-error');
            },
            errorElement: 'span',
            errorClass: 'help-block',
            errorPlacement: function (error, element) {
                if (element.parent('.input-group').length) {
                    error.insertAfter(element.parent());
                } else {
                    error.insertAfter(element);
                }
            }
        });

        $(function () {
            $('#aboutTextBox').froalaEditor({
                toolbarButtons: ['fullscreen', 'bold', 'italic', 'underline', 'strikeThrough', 'subscript', 'superscript', 'fontFamily', 'fontSize', '|', 'color', 'emoticons', 'inlineStyle', 'paragraphStyle', '|', 'paragraphFormat', 'align', 'formatOL', 'formatUL', 'outdent', 'indent', '-', 'insertLink', 'insertImage', 'insertVideo', 'insertFile', 'insertTable', '|', 'quote', 'insertHR', 'undo', 'redo', 'clearFormatting', 'selectAll', 'html']
            });
            $('#cityGridView').DataTable();

            //Form Validation
            $("#CityEntryForm").validate({
                rules: {
                    cityNameTextBox: "required",
                    aboutTextBox: "required",
                    dwellersTextBox: {
                        required: true,
                        number: true,
                        min: 1
                    },
                    locationTextBox: "required",
                    weatherTextBox: "required",
                    countryDropDownList: {
                        required: true,
                        min: 1
                    }
                },
                messages: {
                    cityNameTextBox: "Please enter city name",
                    aboutTextBox: "Please enter city information.",
                    dwellersTextBox: {
                        required: "Please enter a valid number",
                        number: "Please enter a valid number",
                        min: "Minimum value is 1"
                    },
                    locationTextBox: "Please enter city location",
                    weatherTextBox: "Please enter city weather information",
                    countryDropDownList: {
                        required: "Select Country of the City",
                        min: "Select Country of the City"
                    }
                }
            });
        });
    </script>
</body>
</html>
