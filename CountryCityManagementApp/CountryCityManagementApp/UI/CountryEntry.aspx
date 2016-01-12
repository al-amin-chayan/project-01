<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CountryCityManagementApp.CountryEntry" ValidateRequest="false" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />

    <title>Country Entry</title>

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
                    <li class="active"><a href="CountryEntry.aspx">Country Entry</a></li>
                    <li><a href="CityEntry.aspx">City Entry</a></li>
                    <li><a href="ViewCities.aspx">View Cities</a></li>
                    <li><a href="CountryView.aspx">View Countries</a></li>
                </ul>
            </nav>
        </div>
        <form id="CountryEntryForm" runat="server">
            <div class="row" style="margin-top: 20px;">
                <div class="col-xs-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Country Entry</h3>
                        </div>
                        <div class="panel-body">
                            <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                            <div class="clearfix"></div>
                            <div class="row">
                                <div class="form-group">
                                    <label for="nameCountryTextBox" class="col-sm-2 control-label">Name</label>
                                    <div class="col-sm-12 col-md-4">
                                        <asp:TextBox ID="nameCountryTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <label for="aboutCountryTextBox" class="col-sm-2 control-label">About</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox ID="aboutCountryTextBox" runat="server" Style="margin-top: 30px;" CssClass="form-control" Rows="10" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <asp:Button ID="saveCountryButton" runat="server" Text="Save" CssClass="btn btn-default" OnClick="saveCountryButton_Click" />
                                        <asp:Button ID="cancelCountryButton" runat="server" Text="Cancel" CssClass="btn btn-default" OnClick="cancelCountryButton_Click" />
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
                            <h3 class="panel-title">Country List</h3>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="countryGridView" runat="server"
                                CssClass="table table-hover table-striped" GridLines="None"
                                AutoGenerateColumns="False" PageSize="3">
                                <Columns>
                                    <asp:BoundField DataField="Sl" HeaderText="Sl#" />
                                    <asp:BoundField DataField="CountryName" HeaderText="Country Name" />
                                    <asp:BoundField DataField="CountryAbout" HtmlEncode="False" HeaderText="About" />
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
            $('#aboutCountryTextBox').froalaEditor({
                toolbarButtons: ['fullscreen', 'bold', 'italic', 'underline', 'strikeThrough', 'subscript', 'superscript', 'fontFamily', 'fontSize', '|', 'color', 'emoticons', 'inlineStyle', 'paragraphStyle', '|', 'paragraphFormat', 'align', 'formatOL', 'formatUL', 'outdent', 'indent', '-', 'insertLink', 'insertImage', 'insertVideo', 'insertFile', 'insertTable', '|', 'quote', 'insertHR', 'undo', 'redo', 'clearFormatting', 'selectAll', 'html']
            });
            $('#countryGridView').DataTable();

            //Form Validation
            $("#CountryEntryForm").validate({
                rules: {
                    nameCountryTextBox: "required",
                    aboutCountryTextBox: "required"
                },
                messages: {
                    nameCountryTextBox: "Please enter country name",
                    aboutCountryTextBox: "Please enter country information."
                }
            });
        });
    </script>
</body>
</html>
