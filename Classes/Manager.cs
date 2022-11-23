
namespace ADO.NET
{
    public class Manager
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public int ? Age { get; set; }

        public Manager(int id, string? name, string? description, int? age)
        {
            ID = id;
            Name = name;
            Description = description;
            Age = age;
        }
    }
}
