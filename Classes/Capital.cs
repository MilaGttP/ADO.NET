
namespace ADO.NET
{
    public class Capital
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double? Population { get; set; }

        public Capital(int iD, string? name, double? population)
        {
            ID = iD;
            Name = name;
            Population = population;
        }
    }
}
