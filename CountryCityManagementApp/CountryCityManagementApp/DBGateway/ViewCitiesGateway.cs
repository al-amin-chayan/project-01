using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp
{
    public class ViewCitiesGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["cityManagementconnectionString"].ConnectionString;
        public List<CitiesViewModel> GetAllCities()
        {

            SqlConnection connection=new SqlConnection(connectionString);

            string query = @"SELECT a.Name AS CityName,a.About AS CityAbout,a.NoOfDwellers,a.Location,a.Weather,b.Name AS CountryName,b.About AS CountryAbout FROM Cities a LEFT OUTER JOIN Countries b ON a.CountryID=b.Id";

            connection.Open();

            SqlCommand command=new SqlCommand(query,connection);

            SqlDataReader reader = command.ExecuteReader();

            List<CitiesViewModel> cities=new List<CitiesViewModel>();

            int sl = 1;
            while (reader.Read())
            {
                CitiesViewModel city=new CitiesViewModel();
                city.Sl = sl++;
                city.CityName = reader["CityName"].ToString();
                city.CityAbout = reader["CityAbout"].ToString();
                city.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"].ToString());
                city.Location = reader["Location"].ToString();
                city.Weather = reader["Weather"].ToString();
                city.CountryName = reader["CountryName"].ToString();
                city.CountryAbout = reader["CountryAbout"].ToString();

                cities.Add(city);
            }

            return cities;
        }


        public List<CitiesViewModel> GetAllCitiesByCityName(string cityName)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT a.Name AS CityName,a.About AS CityAbout,a.NoOfDwellers,a.Location,a.Weather,b.Name AS CountryName,b.About AS CountryAbout FROM Cities a LEFT OUTER JOIN Countries b ON a.CountryID=b.Id WHERE a.Name like '%'+'"+ cityName +"'+'%' ORDER BY a.Name ";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<CitiesViewModel> cities = new List<CitiesViewModel>();

            int sl = 1;
            while (reader.Read())
            {
                CitiesViewModel city = new CitiesViewModel();
                city.Sl = sl++;
                city.CityName = reader["CityName"].ToString();
                city.CityAbout = reader["CityAbout"].ToString();
                city.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"].ToString());
                city.Location = reader["Location"].ToString();
                city.Weather = reader["Weather"].ToString();
                city.CountryName = reader["CountryName"].ToString();
                city.CountryAbout = reader["CountryAbout"].ToString();

                cities.Add(city);
            }

            return cities;
        }


        public List<CitiesViewModel> GetAllCitiesByCountryName(string countryId)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT a.Name AS CityName,a.About AS CityAbout,a.NoOfDwellers,a.Location,a.Weather,b.Name AS CountryName,b.About AS CountryAbout FROM Cities a LEFT OUTER JOIN Countries b ON a.CountryID=b.Id WHERE b.Id='" + countryId + "' ORDER BY a.Name ";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<CitiesViewModel> cities = new List<CitiesViewModel>();

            while (reader.Read())
            {
                CitiesViewModel city = new CitiesViewModel();
                city.CityName = reader["CityName"].ToString();
                city.CityAbout = reader["CityAbout"].ToString();
                city.NoOfDwellers = Convert.ToInt32(reader["NoOfDwellers"].ToString());
                city.Location = reader["Location"].ToString();
                city.Weather = reader["Weather"].ToString();
                city.CountryName = reader["CountryName"].ToString();
                city.CountryAbout = reader["CountryAbout"].ToString();

                cities.Add(city);
            }

            return cities;
        }


        public List<Country> GetAllCountries()
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT * FROM Countries ORDER BY Name";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Country> countries = new List<Country>();

            while (reader.Read())
            {
                Country country = new Country();
                country.CountryId = Convert.ToInt32(reader["Id"].ToString());
                country.CountryName = reader["Name"].ToString();

                countries.Add(country);
            }

            return countries;
        }
    }
}