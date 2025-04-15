using Project.DAL.Data;
using Project.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories
{
    public class OrderRepository
    {
        
        private readonly AppDbContext _context;
        public OrderRepository() 
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders;
        }
        public void AddOrder(Order orders)
        {
            _context.Orders.Add(orders);
            _context.SaveChanges();
        }
        public void AddOrders(List<Order> orders)
        {
            _context.Orders.AddRange(orders);
            _context.SaveChanges();
        }
        public Order? GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }
        public Order? GetOrderByProductName(string name)
        {
            return _context.Orders.FirstOrDefault(o => o.ProductName == name);
        }

        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
        public void UpdateOrder(Order order) 
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }



    }
}
