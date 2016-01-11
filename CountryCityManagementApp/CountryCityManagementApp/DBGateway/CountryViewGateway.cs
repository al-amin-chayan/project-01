using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp.DBGateway
{
    public class CountryViewGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["cityManagementconnectionString"].ConnectionString;

        public List<CountryViewModel> GetCountryViewByNmae(string name)
        {
            string sql = "SELECT a.Name, a.About, COUNT(b.Id) AS TotalCities, ISNULL(SUM(b.NoOfDwellers),0) AS TotalCityDwellers " +
                         "FROM Countries a " + 
                         "LEFT JOIN Cities b ON a.Id = b.CountryId " +
                         "WHERE a.Name LIKE '%" + name + "%' " +
                         "GROUP BY a.Id, a.Name, a.About " + 
                         "ORDER BY a.Name ASC";

            List<CountryViewModel> countryViewes = new List<CountryViewModel>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            int sl = 1;
            while (reader.Read())
            {
                CountryViewModel aCountryViewModel = new CountryViewModel();
                aCountryViewModel.Sl = sl++;
                aCountryViewModel.Name = reader["Name"].ToString();
                aCountryViewModel.About = reader["About"].ToString();
                aCountryViewModel.TotalCities = Convert.ToInt32(reader["TotalCities"].ToString());
                aCountryViewModel.TotalCityDwellers = Convert.ToInt32(reader["TotalCityDwellers"].ToString());
                countryViewes.Add(aCountryViewModel);
            }
            connection.Close();

            return countryViewes;
        }
    }
}