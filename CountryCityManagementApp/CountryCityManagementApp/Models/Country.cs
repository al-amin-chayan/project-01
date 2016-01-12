using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApp.Models
{
    public class Country
    {
        
        public string CountryName { get; set; }
        
        public string CountryAbout { get; set; }

        public int CountryId { get; set; }

        public Country(string countryName, string countryAbout)
        {
            CountryName = countryName;
            CountryAbout = countryAbout;

        }
        
        public Country()
        {

        }
    }
}