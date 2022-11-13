
namespace ADO.NET
{
    public class FruitsAndVegetables
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public string ? Type { get; set; }
        public string ? Color { get; set; }
        public int ? CaloricContent { get; set; }

        public FruitsAndVegetables(int iD, string? name, string? type, string? color, int? caloricContent)
        {
            ID = iD;
            Name = name;
            Type = type;
            Color = color;
            CaloricContent = caloricContent;
        }
    }
}
