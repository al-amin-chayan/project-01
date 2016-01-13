using System.Collections.Generic;
using System.Data.SqlClient;
using CountryCityManagementApp.DBGateway;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp.BusinessLogic
{
    public class CountryManager
    {
        CountryGateway aCountryGateway = new CountryGateway();

        public List<CountryListModel> LoadAllCountries()
        {
            return aCountryGateway.LoadAllCountries();
        }

        public Message Save(Country newCountry)
        {
            Message message = new Message();

            if (newCountry.CountryName.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "Name is Blank.";
                return message;
            }

            bool alreadyExists = aCountryGateway.SearchCountryByName(newCountry.CountryName);

            if (alreadyExists)
            {
                message.Status = "alert alert-danger";
                message.Details = "Country name [" + newCountry.CountryName + "] is already exists.";
                return message;
            }

            if (newCountry.CountryAbout.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "About field is required.";
                return message;
            }

            try
            {
                aCountryGateway.Save(newCountry);
                message.Status = "alert alert-success";
                message.Details = "Country Added Successfully";
            }
            catch (SqlException ex)
            {
                message.Status = "alert alert-danger";
                message.Details = ex.Message;
            }

            return message;
        }

        public List<CountryDropDown> GetCountryList()
        {
            return aCountryGateway.CountryList();
        }
    }
}