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
            MenuService menu = new MenuService();
            menu.Menu();

            var context = new AppDbContext();

            var user = new User()
            {
                Name = "Stas"
            };


            var order1 = new Order()
            {
                ProductName = "SmartPhone",
                CreatedDate = DateTime.Now
            };


            var order2 = new Order()
            {
                ProductName = "Xbox",
                CreatedDate = DateTime.Now
            };

            //user.Orders.Add(order1);
            //user.Orders.Add(order2);

            //context.User.Add(user);
            //context.SaveChanges();

            //var userWithOrders = context.User.Include(x => x.Orders);

            //foreach (var u in userWithOrders)
            //{
            //    Console.WriteLine($"User: {u.Name} \n \t orders: ");

            //    foreach (var o in u.Orders)
            //    {
            //        Console.WriteLine($"\t\t Product: {o.ProductName} - DataCreate: {o.CreatedDate}");
            //    }
            //}


        }
    }
}