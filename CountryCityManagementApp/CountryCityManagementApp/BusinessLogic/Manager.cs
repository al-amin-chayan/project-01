using System;
using System.Collections.Generic;
using CountryCityManagementApp.Models;
using CountryCityManagementApp.DBGateway;


namespace CountryCityManagementApp.BusinessLogic
{
    public class Manager
    {
        DatabaseGateway databaseGateway = new DatabaseGateway();
        public List<Country> LoadAllCountries()
        {
            return databaseGateway.LoadAllCountries();
        }

        public string Save(Country newCountry)
        {
            string cleanCountryName = InputChecker.CheckInput(newCountry.CountryName);
            
            if (cleanCountryName == "")
            {
                return "Name is Blank";
            }
            
            else
            {
                newCountry.CountryName = cleanCountryName;

                bool alreadyExists = databaseGateway.SearchCountryByName(newCountry.CountryName);
                if (alreadyExists)
                {
                    return "Name Already Exists";
                }
                else
                {

                    int returnValue = databaseGateway.Save(newCountry);
                    if (returnValue > 0)
                    {
                        return "success";
                    }
                    else {
                        return "failed";
                    }
                }
            } 
        }

        //public List<CountryViewModel> LoadAllCities()
        //{
        //    return databaseGateway.LoadAllCities();
        //}

        //public string SaveCity(City newCity)
        //{
        //    string cityName = InputChecker.CheckInput(newCity.CityName);
        //    if (cityName == "")
        //    {
        //        return "Name is Blank";
        //    }
        //    else
        //    {
        //        bool cityExists = databaseGateway.SearchCityByName(cityName);
        //        if (cityExists)
        //        {
        //            return "City Already Exists";
        //        }
        //        else
        //        {
        //            newCity.CityName = cityName;
        //            int rowAffected = databaseGateway.SaveCity(newCity);
        //            if (rowAffected > 0)
        //            {
        //                return "Successfully Saved";
        //            }
        //            else
        //            {
        //                return "Could not save data";
        //            }
        //        }
        //    }  
        //}
    }
}