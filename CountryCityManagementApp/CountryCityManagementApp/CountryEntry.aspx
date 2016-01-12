<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" validateRequest="false" Inherits="CountryCityManagementApp.CountryEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CountryDropDown Entry</title>
    <!-- Include Font Awesome. -->
  <link href="//cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

  <!-- Include Editor style. -->
  <link href="css/froala_editor.min.css" rel="stylesheet" type="text/css" />
  <link href="css/froala_style.min.css" rel="stylesheet" type="text/css" />

  <!-- Include Editor Plugins style. -->
    <link rel="stylesheet" href="css/plugins/char_counter.css"/>
    <link rel="stylesheet" href="css/plugins/code_view.css" />
    <link rel="stylesheet" href="css/plugins/colors.css"/>
    <link rel="stylesheet" href="css/plugins/emoticons.css"/>
    <link rel="stylesheet" href="css/plugins/file.css"/>
    <link rel="stylesheet" href="css/plugins/fullscreen.css"/>
    <link rel="stylesheet" href="css/plugins/image.css"/>
    <link rel="stylesheet" href="css/plugins/image_manager.css"/>
    <link rel="stylesheet" href="css/plugins/line_breaker.css"/>
    <link rel="stylesheet" href="css/plugins/table.css"/>
    <link rel="stylesheet" href="css/plugins/video.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="nameLabelCountry" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameCountryTextBox" runat="server"></asp:TextBox> <br/><br/>
        <asp:Label ID="aboutLabel" runat="server" Text="About"></asp:Label>
        <div class="fr-view">
            <textarea id="textAboutCountry" runat="server" name="nameTextAboutCountryDropDown"></textarea>
        </div><br/><br/>
        <asp:Button ID="saveCountryButton" runat="server" Text="Save" OnClick="saveCountryButton_Click" />
        <asp:Button ID="cancelCountryButton" runat="server" Text="Cancel" OnClick="cancelCountryButton_Click" />
        <asp:Label ID="messageLabel" runat="server" ></asp:Label>
        <br/><br/>
        <asp:GridView ID="countryGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                    <asp:TemplateField HeaderText="Serial No." HeaderStyle-Width="5%" HeaderStyle-HorizontalAlign="Center"> 
                          
                        <ItemTemplate>
                             <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country About">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>

        </asp:GridView>
    </div>
    </form>
    
    
    
    <!-- Include jQuery. -->
  <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>

  <!-- Include JS files. -->
  <script src="js/froala_editor.min.js"></script>

  <!-- Include Plugins. -->
  <script type="text/javascript" src="js/plugins/align.min.js"></script>
  <script type="text/javascript" src="js/plugins/char_counter.min.js"></script>
  <script type="text/javascript" src="js/plugins/code_view.min.js"></script>
  <script type="text/javascript" src="js/plugins/colors.min.js"></script>
  <script type="text/javascript" src="js/plugins/emoticons.min.js"></script>
  <script type="text/javascript" src="js/plugins/entities.min.js"></script>
  <script type="text/javascript" src="js/plugins/file.min.js"></script>
  <script type="text/javascript" src="js/plugins/font_family.min.js"></script>
  <script type="text/javascript" src="js/plugins/font_size.min.js"></script>
  <script type="text/javascript" src="js/plugins/fullscreen.min.js"></script>
  <script type="text/javascript" src="js/plugins/image.min.js"></script>
  <script type="text/javascript" src="js/plugins/image_manager.min.js"></script>
  <script type="text/javascript" src="js/plugins/inline_style.min.js"></script>
  <script type="text/javascript" src="js/plugins/line_breaker.min.js"></script>
  <script type="text/javascript" src="js/plugins/link.min.js"></script>
  <script type="text/javascript" src="js/plugins/lists.min.js"></script>
  <script type="text/javascript" src="js/plugins/paragraph_format.min.js"></script>
  <script type="text/javascript" src="js/plugins/paragraph_style.min.js"></script>
  <script type="text/javascript" src="js/plugins/quote.min.js"></script>
  <script type="text/javascript" src="js/plugins/table.min.js"></script>
  <script type="text/javascript" src="js/plugins/save.min.js"></script>
  <script type="text/javascript" src="js/plugins/url.min.js"></script>
  <script type="text/javascript" src="js/plugins/video.min.js"></script>

  <!-- Include Language file if we'll use it. -->
  <script type="text/javascript" src="js/languages/ro.js"></script>

  <!-- Initialize the editor. -->
  <script>
      $(function() {
          $('#textAboutCountry').froalaEditor();
      });
  </script>
</body>
</html>
