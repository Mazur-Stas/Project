

namespace Project.DAL.Enteties
{
    public class Order
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
