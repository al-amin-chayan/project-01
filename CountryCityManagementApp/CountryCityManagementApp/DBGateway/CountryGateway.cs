using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<CountryListModel> LoadAllCountries()
        {
            List<CountryListModel> allCountries = new List<CountryListModel>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Countries ORDER BY 'Name' ASC";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            int sl = 1;
            while (sqlDataReader.Read())
            {
                CountryListModel aCountry = new CountryListModel();
                aCountry.Sl = sl++;
                aCountry.CountryName = sqlDataReader["Name"].ToString();
                aCountry.CountryAbout = sqlDataReader["About"].ToString();
                allCountries.Add(aCountry);
            }
            sqlConnection.Close();
            return allCountries;
        }

        public bool SearchCountryByName(string name)
        {
            string query = "SELECT * FROM Countries WHERE Name = @countryName";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();


            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("countryName", SqlDbType.NVarChar);
            sqlCommand.Parameters["countryName"].Value = name;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public void Save(Country country)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Countries (Name, About) VALUES (@countryName, @countryAbout)";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("countryName", sqlDbType: SqlDbType.NVarChar);
            sqlCommand.Parameters["countryName"].Value = country.CountryName;
            sqlCommand.Parameters.Add("countryAbout", sqlDbType: SqlDbType.NVarChar);
            sqlCommand.Parameters["countryAbout"].Value = country.CountryAbout;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}