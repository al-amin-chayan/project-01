using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using CountryCityManagementApp.BusinessLogic;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        CountryManager aCountryManager = new CountryManager();
        
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
            List<CountryListModel> countries = new List<CountryListModel>();
            countries = aCountryManager.LoadAllCountries();
            countryGridView.DataSource = countries;
            countryGridView.DataBind();
            countryGridView.UseAccessibleHeader = true;
            countryGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void saveCountryButton_Click(object sender, EventArgs e)
        {
            Message message = new Message();

            try
            {
                string name = nameCountryTextBox.Text.Trim();
                string about = aboutCountryTextBox.Text.Trim();
                Country newCountry = new Country(name, about);
                message = aCountryManager.Save(newCountry);
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
                    ClearText();
                }
                LoadAllCountries();
            }
        }

        private void ClearText()
        {
            nameCountryTextBox.Text = "";
            aboutCountryTextBox.Text = "";
        }

        protected void cancelCountryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}
