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
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager aCityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = cityNameTextBox.Text;
            string about = aboutTextBox.Text;

            Message message = new Message();

            City aCity = new City(name, about, 10, "", "", 1);
            message = aCityManager.Save(aCity);

            messageLabel.CssClass = message.Status;
            messageLabel.Text = message.Details;

            if (message.Status == "alert alert-success")
            {
                ClearFormData();
            }
        }

        private void ClearFormData()
        {
            cityNameTextBox.Text = "";
            aboutTextBox.Text = "";
        }

        protected void saveButton1_Click(object sender, EventArgs e)
        {
            string name = cityNameTextBox.Text;
            string about = aboutTextBox.Text;

            Message message = new Message();

            City aCity = new City(name, about, 10, "", "", 1);
            message = aCityManager.Save(aCity);

            messageLabel.CssClass = message.Status;
            messageLabel.Text = message.Details;

            if (message.Status == "alert alert-success")
            {
                ClearFormData();
            }
        }
    }
}