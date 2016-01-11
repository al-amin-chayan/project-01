namespace CountryCityManagementApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public Country(string name, string about)
        {
            Name = name;
            About = about;
        }

        public Country()
        {
            
        }
    }
}