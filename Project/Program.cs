using Project;
using System;
using ConsoleApp1.Services;
using Project.DAL;
using Project.DAL.Data;
using Project.DAL.Entities;
using Project.DAL.Enteties;
namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var contex = new AppDbContext();

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


            user.Orders.Add(order1);
            user.Orders.Add(order2);

            contex.User.Add(user);
            contex.SaveChanges();














            /*var start = new MenuService();

            while (true)
            {
                start.Menu();
            }*/



        }
    }
}