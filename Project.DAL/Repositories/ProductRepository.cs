using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Entities;
using Project.DAL.Data;
using Project.DAL.Enteties;

namespace Project.DAL
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Product> GetAllProduct()
        {
            return _context.Products;
        }
        public void Add(Product Product)
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
        }
        public void Update(Product Product)
        {
            _context.Products.Update(Product);
            _context.SaveChanges();
        }
        public void Delete(Product Product)
        {
            _context.Products.Remove(Product);
            _context.SaveChanges();
        }
    }
}
