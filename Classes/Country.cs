using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public class Country
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Region { get; set; }
        public double? Population { get; set; }
        public double? Square { get; set; }
        public int CapitalID { get; set; }
        public List <string> Cities { get; set; }
        public List <string> BiggestCities { get; set; }

        public Country(int iD, string? name, string? region, double? population, double? square, int capitalID, List<string> cities, List<string> biggestCities)
        {
            ID = iD;
            Name = name;
            Region = region;
            Population = population;
            Square = square;
            CapitalID = capitalID;
            Cities = cities;
            BiggestCities = biggestCities;
        }
    }
}
