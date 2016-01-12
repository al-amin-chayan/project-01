using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using CountryCityManagementApp.BusinessLogic;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager aCityManager = new CityManager();
        CountryManager aCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityList();
                LoadCountries();
                ClearFormData();
            }
        }

        private void LoadCityList()
        {
            List<CityListModel> cities = new List<CityListModel>();
            cities = aCityManager.GetCityList();
            cityGridView.DataSource = cities;
            cityGridView.DataBind();
            cityGridView.UseAccessibleHeader = true;
            cityGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        private void LoadCountries()
        {
            var firstitem = countryDropDownList.Items[0];
            countryDropDownList.Items.Clear();
            countryDropDownList.Items.Add(firstitem);

            List<CountryDropDown> countries = aCountryManager.GetCountryList();
            countryDropDownList.DataSource = countries;
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Message message = new Message();

            try
            {
                string name = cityNameTextBox.Text.Trim();
                string about = aboutTextBox.Text.Trim();
                int dwellers = Convert.ToInt32(dwellersTextBox.Text);
                string location = locationTextBox.Text.Trim();
                string weather = weatherTextBox.Text.Trim();
                int countryId = Convert.ToInt32(countryDropDownList.SelectedItem.Value);
                City aCity = new City(name, about, dwellers, location, weather, countryId);
                message = aCityManager.Save(aCity);
            }
            catch (Exception ex)
            {
                message.Status = "alert alert-danger";
                message.Details = ex.Message;
            }
            finally
            {
                messageLabel.CssClass = message.Status;
                messageLabel.Text = message.Details;

                if (message.Status == "alert alert-success")
                {
                    ClearFormData();
                }
                LoadCityList();
            }
        }

        private void ClearFormData()
        {
            cityNameTextBox.Text = "";
            aboutTextBox.Text = "";
            dwellersTextBox.Text = "";
            locationTextBox.Text = "";
            weatherTextBox.Text = "";
            countryDropDownList.SelectedIndex = 0;
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}