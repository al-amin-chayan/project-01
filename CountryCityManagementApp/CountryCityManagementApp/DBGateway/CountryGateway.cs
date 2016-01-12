using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp.DBGateway
{
    public class CountryGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["cityManagementconnectionString"].ConnectionString;

        public List<CountryDropDown> CountryList()
        {
            List<CountryDropDown> countries = new List<CountryDropDown>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Countries ORDER BY Name ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CountryDropDown aCountryDropDown = new CountryDropDown();
                aCountryDropDown.Id = Convert.ToInt32(reader["Id"].ToString());
                aCountryDropDown.Name = reader["Name"].ToString();
                aCountryDropDown.About = reader["About"].ToString();
                countries.Add(aCountryDropDown);
            }
            reader.Close();
            connection.Close();
            return countries;
        }
    }
}