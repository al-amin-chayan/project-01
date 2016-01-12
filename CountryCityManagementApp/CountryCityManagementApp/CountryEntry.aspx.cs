using System;
using CountryCityManagementApp.BusinessLogic;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        Manager countryCityManager = new Manager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadAllCountries();
                ClearText();
            }
            
            
        }


        private void LoadAllCountries()
        {
            if (countryCityManager.LoadAllCountries() != null)
            {
                
                countryGridView.DataSource = countryCityManager.LoadAllCountries();
                countryGridView.DataBind();
            }
            else
            {
                messageLabel.Text = "No Data to View";
            }

        }

        protected void saveCountryButton_Click(object sender, EventArgs e)
        {
            Country newCountry = new Country();
            newCountry.CountryName = nameCountryTextBox.Text;
            newCountry.CountryAbout = textAboutCountry.Value;
            
            string message = countryCityManager.Save(newCountry);
            messageLabel.Text = message;
            
            LoadAllCountries();
            ClearText();
        }

        private void ClearText()
        {
            nameCountryTextBox.Text = "";
            textAboutCountry.Value = "";
            
        }

        protected void cancelCountryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}