using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApp.Models
{
    public class CountryViewModel
    {
        public int Sl { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int TotalCities { get; set; }
        public int TotalCityDwellers { get; set; }
    }
}