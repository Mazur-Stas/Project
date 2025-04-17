using Project.DAL;
using Project.DAL.Enteties;
using Project.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;

namespace Project.Services
{
    public class ProductService
    {
        public readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public List<Product> GetAllProduct()
        {
            return _productRepository.GetAllProduct().ToList();
        }

        public void AddProduct(Product Product)
        {
            _productRepository.Add(Product);
        }
        public void UpdateProduct(int Id,Product Product)
        {
            var prod = _productRepository.GetAllProduct().FirstOrDefault(o => o.id == Id);
            if (prod != null)
            {
                prod.Name = Product.Name;
                prod.Price = Product.Price;
                _productRepository.Update(prod);
            }
        }
        public void DeleteById(int id)
        {
            var product = _productRepository.GetAllProduct()
                       .FirstOrDefault(p => p.id == id);
            _productRepository.Delete(product);
        }

        public void ShowAllProduct()
        {
            var products = GetAllProduct();
            foreach (var prod in products)
            {
                Console.WriteLine($"Id: {prod.id}, Name: {prod.Name}, Price: {prod.Price}");
            }
        }
    }
}
