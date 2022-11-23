
namespace ADO.NET
{
    public class Stationery
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public string ? Type { get; set; }
        public int ? Quantity { get; set; }
        public double ? Price { get; set; }

        public Stationery(int id, string? name, string? type, int? quantity, double? price)
        {
            ID = id;
            Name = name;
            Type = type;
            Quantity = quantity;
            Price = price;
        }
    }
}
