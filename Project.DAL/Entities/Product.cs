
using Project.DAL.Enteties;

namespace Project.DAL.Entities
{
    public class Product
    {
        public int id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
