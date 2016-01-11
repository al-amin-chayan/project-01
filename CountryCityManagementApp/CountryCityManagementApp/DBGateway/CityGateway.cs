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
            command.Parameters.Add("name", sqlDbType: SqlDbType.NVarChar);
            command.Parameters["name"].Value = newCity.Name;

            command.Parameters.Add("about", sqlDbType: SqlDbType.NVarChar);
            command.Parameters["about"].Value = newCity.About;

            command.Parameters.Add("dwellers", sqlDbType: SqlDbType.Int);
            command.Parameters["dwellers"].Value = newCity.NoOfDwellers;

            command.Parameters.Add("location", sqlDbType: SqlDbType.NVarChar);
            command.Parameters["location"].Value = newCity.Location;

            command.Parameters.Add("weather", sqlDbType: SqlDbType.NVarChar);
            command.Parameters["weather"].Value = newCity.Weather;

            command.Parameters.Add("countryId", sqlDbType: SqlDbType.Int);
            command.Parameters["countryId"].Value = newCity.CountryId;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public City GetCityByName(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Cities WHERE Name = @name";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Clear();
            command.Parameters.Add("name", sqlDbType: SqlDbType.NVarChar);
            command.Parameters["name"].Value = name;

            City aCity = null;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                aCity = new City();
                aCity.Id = Convert.ToInt32(reader["Id"].ToString());
                aCity.Name = reader["Name"].ToString();
                aCity.About = reader["About"].ToString();
                aCity.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"].ToString());
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryId = Convert.ToInt32(reader["CountryID"].ToString());
            }
            reader.Close();
            connection.Close();
            return aCity;
        }

        public List<CityListModel> GetCityList()
        {
            string sql = "SELECT a.Name, a.NoOfDwellers, b.Name AS Country FROM Cities a LEFT JOIN Countries b ON a.CountryID = b.Id ORDER BY a.Name ASC";

            List<CityListModel> cityList = new List<CityListModel>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            int sl = 1;
            while (reader.Read())
            {
                CityListModel aCityList = new CityListModel();
                aCityList.Sl = sl++;
                aCityList.Name = reader["Name"].ToString();
                aCityList.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"].ToString());
                aCityList.Country = reader["Country"].ToString();
                cityList.Add(aCityList);
            }
            connection.Close();

            return cityList;
        }
    }
}