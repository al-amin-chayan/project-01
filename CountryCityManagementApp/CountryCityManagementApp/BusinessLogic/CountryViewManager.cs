using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityManagementApp.DBGateway;
using CountryCityManagementApp.Models;

namespace CountryCityManagementApp.BusinessLogic
{
    public class CountryViewManager
    {
        CountryViewGateway aCountryViewGateway = new CountryViewGateway();
        public List<CountryViewModel> GetCountryViewByNmae(string name = "")
        {
            return aCountryViewGateway.GetCourseViewByNmae(name);
        }
    }
}