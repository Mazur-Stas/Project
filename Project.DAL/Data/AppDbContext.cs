﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.DAL.Enteties;
using Project.DAL.Entities;
using System;

namespace Project.DAL.Data
{
    public class AppDbContext : DbContext
    {
        private string _connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = UN; Integrated Security = True; Connect Timeout = 30;";
        public DbSet<Student> Students { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();


           //var _connectionString = connection.GetConnectionString("DefualtConection");

            optionsBuilder.UseSqlServer(_connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
