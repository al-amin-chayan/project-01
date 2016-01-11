using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityManagementApp.DBGateway;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp.BusinessLogic
{
    public class CountryManager
    {
        CountryGateway aCountryGateway = new CountryGateway();
        public List<Country> GetCountryList()
        {
            return aCountryGateway.CountryList();
        }
    }
}