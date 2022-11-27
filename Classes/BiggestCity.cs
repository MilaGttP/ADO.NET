
namespace ADO.NET
{
    public class BiggestCity
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public double ? Population { get; set; }
        public double ? Square { get; set; }
        public int CountryID { get; set; }

        public BiggestCity(int iD, string? name, double? population, double? square, int countryID)
        {
            ID = iD;
            Name = name;
            Population = population;
            Square = square;
            CountryID = countryID;
        }
    }
}
