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
    public class DatabaseGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["cityManagementconnectionString"].ConnectionString;

        public int Save(Country country) {
            //string query = "INSERT INTO Countries VALUES ('" + country.CountryName + "','" + country.CountryAbout + "')";

            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Countries  VALUES(@countryName, @countryAbout)";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("countryName", SqlDbType.NVarChar);
            sqlCommand.Parameters["countryName"].Value = country.CountryName;
            sqlCommand.Parameters.Add("countryAbout", SqlDbType.NVarChar);
            sqlCommand.Parameters["countryAbout"].Value = country.CountryAbout;


            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected;
        }

        public bool SearchCountryByName(string name) {
            string query = "SELECT * FROM Countries WHERE Name = @countryName";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();


            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("countryName", SqlDbType.NVarChar);
            sqlCommand.Parameters["countryName"].Value = name;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read()) {
                sqlConnection.Close();
                return true;
            }
            sqlConnection.Close();
            return false;
        }
        public bool SearchCityByName(string name)
        {
            string query = "SELECT * FROM Cities WHERE Name = @cityName";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();


            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("cityName", SqlDbType.NVarChar);
            sqlCommand.Parameters["cityName"].Value = name;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public List<Country> LoadAllCountries()
        {
            List<Country> allCountries = new List<Country>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Countries ORDER BY 'Name' ASC";

            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Country newCountry = new Country();
                newCountry.CountryId = Convert.ToInt32(sqlDataReader["Id"].ToString());
                newCountry.CountryName = sqlDataReader["Name"].ToString();
                newCountry.CountryAbout =sqlDataReader["About"].ToString();
                allCountries.Add(newCountry);
            }
            sqlConnection.Close();
            return allCountries;
        }

        //public List<CountryViewModel> LoadAllCities()
        //{
        //    List<CountryViewModel> allCities = new List<CountryViewModel>();

        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    string query = "SELECT * FROM GetCountryCityTogether ORDER BY 'Name' ASC";

        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //    sqlConnection.Open();

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //    while (sqlDataReader.Read())
        //    {
        //        CountryViewModel newCity = new CountryViewModel();
        //        newCity.CityName = sqlDataReader["Name"].ToString();
        //        newCity.CityAbout = sqlDataReader["About"].ToString();
        //        newCity.NoOfDwellers = Convert.ToInt32(sqlDataReader["NoOfDwellers"]);
        //        newCity.Location = sqlDataReader["Location"].ToString();
        //        newCity.Weather = sqlDataReader["Weather"].ToString();
        //        newCity.CountryName = sqlDataReader["CountryName"].ToString();
        //        allCities.Add(newCity);
        //    }
        //    sqlConnection.Close();
        //    return allCities;
        //}

        //public int SaveCity(City newCity)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    string query = "INSERT INTO Cities  VALUES(@cityName, @cityAbout,@cityNoOfDwellers,@cityLocation,@cityWeather,@cityCountryId)";

        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //    sqlCommand.Parameters.Clear();
        //    sqlCommand.Parameters.Add("cityName", SqlDbType.NVarChar);
        //    sqlCommand.Parameters["cityName"].Value = newCity.CityName;
        //    sqlCommand.Parameters.Add("cityAbout", SqlDbType.NVarChar);
        //    sqlCommand.Parameters["cityAbout"].Value = newCity.CityAbout;
        //    sqlCommand.Parameters.Add("cityNoOfDwellers", SqlDbType.Int);
        //    sqlCommand.Parameters["cityNoOfDwellers"].Value = newCity.NoOfDwellers;
        //    sqlCommand.Parameters.Add("cityLocation", SqlDbType.NVarChar);
        //    sqlCommand.Parameters["cityLocation"].Value = newCity.Location;
        //    sqlCommand.Parameters.Add("cityWeather", SqlDbType.NVarChar);
        //    sqlCommand.Parameters["cityWeather"].Value = newCity.Weather;
        //    sqlCommand.Parameters.Add("cityCountryId", SqlDbType.Int);
        //    sqlCommand.Parameters["cityCountryId"].Value = newCity.CountryId;


        //    sqlConnection.Open();
        //    int rowAffected = sqlCommand.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    return rowAffected;
        //}
    }
}