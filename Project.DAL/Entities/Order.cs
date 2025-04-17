

using Project.DAL.Entities;

namespace Project.DAL.Enteties
{
    public class Order
    {
        public int Id { get; set; }


        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }


    }
}
