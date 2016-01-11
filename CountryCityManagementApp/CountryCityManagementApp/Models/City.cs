namespace CountryCityManagementApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryId { get; set; }

        public City(string name, string about, int noDewllers, string location, string weather, int countryId)
        {
            Name = name;
            About = about;
            NoOfDwellers = noDewllers;
            Location = location;
            Weather = weather;
            CountryId = countryId;
        }

        public City()
        {
            
        }

    }
}