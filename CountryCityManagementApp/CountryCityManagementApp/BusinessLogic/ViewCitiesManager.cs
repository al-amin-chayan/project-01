using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp
{
    public class ViewCitiesManager
    {
        ViewCitiesGateway viewCitiesGateway=new ViewCitiesGateway();
        public List<CitiesViewModel> GetAllCiteies()
        {
            return viewCitiesGateway.GetAllCities();
        }
        public List<CitiesViewModel> GetAllCiteiesByCityName(string cityName)
        {
            return viewCitiesGateway.GetAllCitiesByCityName(cityName);
        }

        public List<CitiesViewModel> GetAllCiteiesByCountryName(string countryId)
        {
            return viewCitiesGateway.GetAllCitiesByCountryName(countryId);
        }

        public List<Country> GetAllCountries()
        {
            return viewCitiesGateway.GetAllCountries();
        }

    }
}