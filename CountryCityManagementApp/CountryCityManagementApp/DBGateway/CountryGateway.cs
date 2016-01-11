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

        public List<Country> CountryList()
        {
            List<Country> countries = new List<Country>();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Countries ORDER BY Name ASC";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Country aCountry = new Country();
                aCountry.Id = Convert.ToInt32(reader["Id"].ToString());
                aCountry.Name = reader["Name"].ToString();
                aCountry.About = reader["About"].ToString();
                countries.Add(aCountry);
            }
            reader.Close();
            connection.Close();
            return countries;
        }
    }
}