using Project;
using System;
using Project.Services;
using Project.DAL;
using Project.DAL.Data;
using Project.DAL.Entities;
using Project.DAL.Enteties;
using Microsoft.EntityFrameworkCore;
namespace Project
{


    internal class Program
    {
        static void Main(string[] args)
        {
            MenuService ServiceMenu = new MenuService();
            ServiceMenu.Menu();

            var context = new AppDbContext();


            //var UserAndOrder = context.Orders
            //        .Select(o => $"{o.User.Name}  order {o.Product.Name}   {o.CreatedDate}")
            //        .ToList();

            //foreach(var order in UserAndOrder)
            //{
            //    Console.WriteLine(order);
            //}

            //var user = new User()
            //{
            //    Name = "Stas"
            //};

            //var product = new Product()
            //{
            //    Name = "Xbox",
            //    Price = 2000
            //};

            //var product2 = new Product()
            //{
            //    Name = "Samsung",
            //    Price = 2999
            //};


            //context.User.Add(user);
            //context.Products.AddRange(product,product2);
            //context.SaveChanges();

            //var user1 = context.User.FirstOrDefault();
            //var product1 = context.Products.FirstOrDefault();
            //var prod2 = context.Products.FirstOrDefault(p => p.id == 2);


            //var order = new Order()
            //{
            //    UserId = user1.Id,
            //    ProductId = product1.id,
            //    CreatedDate = DateTime.Now
            //};

            //var order2 = new Order()
            //{
            //    UserId = user1.Id,
            //    ProductId = prod2.id,
            //    CreatedDate = DateTime.Now
            //};

            //context.Orders.AddRange(order, order2);
            //context.SaveChanges();
        }
    }
}