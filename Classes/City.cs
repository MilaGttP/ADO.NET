
namespace ADO.NET
{
    public class City
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double? Population { get; set; }
        public int CountryID { get; set; }

        public City(int iD, string? name, double? population, int countryID)
        {
            ID = iD;
            Name = name;
            Population = population;
            CountryID = countryID;
        }
    }
}
