using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApp
{
    public class CitiesViewModel
    {
        public int Sl { get; set; }
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
    }
}