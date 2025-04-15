using Project.DAL.Data;
using Project.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories
{
    internal class OrederRepository
    {
        
        private readonly AppDbContext _context;
        public OrederRepository() 
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders;
        }
        public Order? GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }
        public void AddOrder(Order orders)
        {
            _context.Orders.Add(orders);
            _context.SaveChanges();
        }
        public void AddOrder(List<Order> orders)
        {
            _context.Orders.AddRange(orders);
            _context.SaveChanges();
        }
        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
        public void UpdateOrders(List<Order> orders) 
        {
            _context.Orders.AddRange(orders);
        }


    }
}
