namespace CountryCityManagementApp.Models
{
    public class CountryDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public CountryDropDown(string name, string about)
        {
            Name = name;
            About = about;
        }

        public CountryDropDown()
        {
            
        }
    }
}