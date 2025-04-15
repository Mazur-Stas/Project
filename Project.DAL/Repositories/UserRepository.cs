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
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.User;
        }

        public void AddUser(User User)
        {
            _context.User.Add(User);
            _context.SaveChanges();
        }
        public void UpdateUser(User User)
        {
            _context.User.Update(User);
            _context.SaveChanges();
        }
        public void DeleteUser(User User)
        {
            _context.User.Remove(User);
            _context.SaveChanges();
        }
        public User? GetUserById(int id)
        {
            return _context.User.FirstOrDefault(o => o.Id == id);
        }
        public User? GetUserByName(string name)
        {
            return _context.User.FirstOrDefault(o => o.Name == name);
        }
    }
}
