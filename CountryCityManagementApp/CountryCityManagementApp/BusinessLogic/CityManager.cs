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
            string name = newCity.Name.Trim();
            if (name.Length == 0)
            {
                message.Status = "alert alert-warning";
                message.Details = "City name is required.";
                return message;
            }
            bool isCityExists = IsCityExists(newCity);

            if (isCityExists)
            {
                message.Status = "alert alert-danger";
                message.Details = "City name [" + name + "] is already exists.";
                return message;
            }

            try
            {
                aCityGateway.AddCity(newCity);
                message.Status = "alert alert-success";
                message.Details = "Book Added Successfully";
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
            return false;
        }
    }
}

