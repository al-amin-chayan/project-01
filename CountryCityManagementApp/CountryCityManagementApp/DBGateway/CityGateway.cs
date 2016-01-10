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
    public class CityGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["cityManagementconnectionString"].ConnectionString;

        public void AddCity(City newCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "INSERT INTO Cities (Name, About, NoOfDwellers, Location, Weather, CountryID) VALUES (@name, @about, @dwellers, @location, @weather, @countryId)";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Clear();
            command.Parameters.Add("name", sqlDbType: SqlDbType.VarChar);
            command.Parameters["name"].Value = newCity.Name;

            command.Parameters.Add("about", sqlDbType: SqlDbType.VarChar);
            command.Parameters["about"].Value = newCity.About;

            command.Parameters.Add("dwellers", sqlDbType: SqlDbType.Int);
            command.Parameters["dwellers"].Value = newCity.NoOfDwellers;

            command.Parameters.Add("location", sqlDbType: SqlDbType.VarChar);
            command.Parameters["location"].Value = newCity.Location;

            command.Parameters.Add("weather", sqlDbType: SqlDbType.VarChar);
            command.Parameters["weather"].Value = newCity.Weather;

            command.Parameters.Add("countryId", sqlDbType: SqlDbType.Int);
            command.Parameters["countryId"].Value = newCity.CountryId;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}