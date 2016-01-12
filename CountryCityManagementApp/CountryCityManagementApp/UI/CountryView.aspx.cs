using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementApp.BusinessLogic;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp
{
    public partial class CountryView : System.Web.UI.Page
    {
        CountryViewManager aCountryViewManager = new CountryViewManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountryViewList();
            }
        }

        private void LoadCountryViewList()
        {
            List<CountryViewModel> countryViewes = new List<CountryViewModel>();
            countryViewes = aCountryViewManager.GetCountryViewByNmae();

            countryGridView.DataSource = countryViewes;
            countryGridView.DataBind();
            countryGridView.UseAccessibleHeader = true;
            countryGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string countryName = countryNameTextBox.Text.Trim();
            List<CountryViewModel> countryViewes = new List<CountryViewModel>();
            countryViewes = aCountryViewManager.GetCountryViewByNmae(countryName);

            countryGridView.DataSource = countryViewes;
            countryGridView.DataBind();
            countryGridView.UseAccessibleHeader = true;
            countryGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}