namespace ADO.NET
{
    public class Goods
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public string ? Type { get; set; }
        public string ? Supplier { get; set; }
        public string ? Quantity { get; set; }
        public string ? Date { get; set; }

        public Goods(int iD, string? name, string? type, string? supplier, string? quantity, string? date)
        {
            ID = iD;
            Name = name;
            Type = type;
            Supplier = supplier;
            Quantity = quantity;
            Date = date;
        }
    }
}
