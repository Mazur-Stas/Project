﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Entities;
using Project.DAL.Data;
using Project.DAL.Enteties;

namespace Project.DAL
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<User> GetAll()
        {
            return _context.User;
        }

        public void Add(User User)
        {
            _context.User.Add(User);
            _context.SaveChanges();
        }
        public void Update(User User)
        {
            _context.User.Update(User);
            _context.SaveChanges();
        }
        public void Delete(User User)
        {
            _context.User.Remove(User);
            _context.SaveChanges();
        }
    }
}