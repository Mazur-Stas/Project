using Project.DAL.Entities;

using Project;
using Project.DAL.Data;

namespace Project.DAL.Repositories
{
    public class StudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students;
        }

        public Student? GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);

        }

        public Student? GetStudentByName(string name)
        {
            return _context.Students.FirstOrDefault(s => s.Name == name);
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void AddStudents(List<Student> students)
        {
            _context.Students.AddRange(students);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
