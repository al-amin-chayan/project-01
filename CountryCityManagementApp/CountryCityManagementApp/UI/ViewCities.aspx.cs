using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryCityManagementApp
{
    public partial class ViewCities : System.Web.UI.Page
    {
        ViewCitiesManager manager = new ViewCitiesManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllCities();
                GetAllCountries();
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
           // GetAllCities();
            if (searchByCityNameRadioButton.Checked)
            {
                outputGridView.DataSource = manager.GetAllCiteiesByCityName(cityNameTextBox.Text);
                outputGridView.DataBind();
            }
            else if (searchByCountryNameRadioButton.Checked)
            {
                outputGridView.DataSource = manager.GetAllCiteiesByCountryName(countryDropDownList.SelectedValue);
                outputGridView.DataBind();
            }
            else
            {
                outputGridView.DataSource = manager.GetAllCiteies();
                outputGridView.DataBind();
            }
            outputGridView.UseAccessibleHeader = true;
            outputGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (searchByCityNameRadioButton.Checked)
            {
                outputGridView.DataSource = manager.GetAllCiteiesByCityName(cityNameTextBox.Text);
                outputGridView.DataBind();
            }
            else if (searchByCountryNameRadioButton.Checked)
            {
                outputGridView.DataSource = manager.GetAllCiteiesByCountryName(countryDropDownList.SelectedValue);
                outputGridView.DataBind();
            }
            else
            {
                outputGridView.DataSource = manager.GetAllCiteies();
                outputGridView.DataBind();
            }
        }

        private void GetAllCities()
        {
            outputGridView.DataSource = manager.GetAllCiteies();
            outputGridView.DataBind();
        }

        private void GetAllCountries()
        {
            countryDropDownList.DataSource = manager.GetAllCountries();
            countryDropDownList.DataValueField = "CountryId";
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataBind();
        }

        protected void outputGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            outputGridView.PageIndex = e.NewPageIndex;
            LoadGridData();
        }
    }
}