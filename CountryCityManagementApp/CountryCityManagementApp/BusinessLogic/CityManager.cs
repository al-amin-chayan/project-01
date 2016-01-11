using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityManagementApp.DBGateway;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp.BusinessLogic
{
    public class CityManager
    {
        CityGateway aCityGateway = new CityGateway();
        public Message Save(City newCity)
        {
            Message message = new Message();
            if (newCity.Name.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "City name is required.";
                return message;
            }
            bool isCityExists = IsCityExists(newCity);

            if (isCityExists)
            {
                message.Status = "alert alert-danger";
                message.Details = "City name [" + newCity.Name + "] is already exists.";
                return message;
            }

            if (newCity.About.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "About field name is required.";
                return message;
            }

            if (newCity.Location.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "Location field name is required.";
                return message;
            }

            if (newCity.Weather.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "Weather field name is required.";
                return message;
            }

            if (newCity.CountryId == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "Select a Country of the city.";
                return message;
            }

            try
            {
                aCityGateway.AddCity(newCity);
                message.Status = "alert alert-success";
                message.Details = "City Added Successfully";
            }
            catch (SqlException ex)
            {
                message.Status = "alert alert-danger";
                message.Details = ex.Message;
            }

            return message;
        }

        private bool IsCityExists(City newCity)
        {
            City aCity = aCityGateway.GetCityByName(newCity.Name);
            if (aCity != null)
            {
                return true;
            }
            return false;
        }

        public List<CityListModel> GetCityList()
        {
            return aCityGateway.GetCityList();
        }
    }
}