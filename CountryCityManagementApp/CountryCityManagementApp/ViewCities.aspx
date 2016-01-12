<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryCityManagementApp.ViewCities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
</head>
<body>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/ViewCities.css" rel="stylesheet" />

    <form id="form1" runat="server">
        
        <div class="">
        <div class="panel panel-default" >
        <div class="panel-heading">
            View Cities
        </div>
         <div class="panel-body">
              <fieldset>
                   <legend>Search Criteria:</legend>
                    <div class="row">
                        <div class="col-md-3">
                            <asp:RadioButton ID="searchByCityNameRadioButton" GroupName="a" Text="City Name" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:TextBox ID="cityNameTextBox" CssClass="form-control input-sm" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                            <asp:RadioButton ID="searchByCountryNameRadioButton" GroupName="a" Text=" Country Name" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="countryDropDownList" runat="server" CssClass="form-control input-sm"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="searchButton" runat="server" CssClass="btn btn-primary input-sm" Text="Search" OnClick="searchButton_Click"/>
                        </div>
                    </div>
             </fieldset>
             <div class="col-lg-12">
                 <div class="table-responsive">
                     <asp:GridView ID="outputGridView" AutoGenerateColumns="False" AllowPaging="True" runat="server" Height="135px" PageSize="8" OnPageIndexChanging="outputGridView_PageIndexChanging" CssClass="table table-striped table-bordered table-hover" style="margin-top: 5px" ItemStyle-CssClass="hidden-xs" HeaderStyle-CssClass="hidden-xs"  >
                    <Columns>
                        <asp:TemplateField HeaderText="SL#">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="City Name">
                            <ItemTemplate><%# Eval("CityName") %></ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="About">
                            <ItemTemplate><%# Eval("CityAbout") %></ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="No Of Dwellers">
                            <ItemTemplate><%# Eval("NoOfDwellers") %></ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Location">
                            <ItemTemplate><%# Eval("Location") %></ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Weather">
                            <ItemTemplate><%# Eval("Weather") %></ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Country">
                            <ItemTemplate><%# Eval("CountryName") %></ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="About Country">
                            <ItemTemplate><%# Eval("CountryAbout") %></ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerStyle CssClass="pagination-ys" />
                </asp:GridView>
                </div>
            </div>
         </div>
    </div>
    </div>
    </form>
</body>
</html>
