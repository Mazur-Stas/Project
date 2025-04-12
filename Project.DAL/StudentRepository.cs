using Microsoft.EntityFrameworkCore.Diagnostics;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class StudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository()
        {
            _context = new AppDbContext();
        }

        public  IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }



        public void Add (Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

        }
        public void AddList(List<Student> students)
        {
            _context.Students.AddRange(students);
            _context.SaveChanges();

        }


        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}
