using ConsoleApp1.DAL.Repositories;
using Project.DAL;
using Project.DAL.Entities;

namespace ConsoleApp1.Services
{
    public class StudentService
    {
        private StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }


        public List<Student> GetStudents()
        {
            return _studentRepository.GetAllStudents().ToList();
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents().ToList();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }


        public Student GetStudentByName(string name)
        {
            return _studentRepository.GetStudentByName(name);
        }


        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }
        public void AddStudents(List<Student> students)
        {
            _studentRepository.AddStudents(students);
        }

        public void UpdateName(int id, string name)
        {
            var student = _studentRepository.GetAllStudents()
                        .FirstOrDefault(s => s.Id == id);
            student.Name = name;
            _studentRepository.UpdateStudent(student);
        }
        public void UpdateDesc(int id, string desc)
        {
            var student = _studentRepository.GetAllStudents()
                                    .FirstOrDefault(s => s.Id == id);

            student.Description = desc;
            _studentRepository.UpdateStudent(student);
        }
        public void DeleteStudent(Student student)
        {
            _studentRepository.DeleteStudent(student);
        }


        public void DeleteById(int id)
        {
            var student = _studentRepository.GetAllStudents()
                       .FirstOrDefault(s => s.Id == id);
            _studentRepository.DeleteStudent(student);
        }
        public void DeleteByName(string name)
        {
            var student = _studentRepository.GetAllStudents()
                            .FirstOrDefault(s => s.Name == name);
            _studentRepository.DeleteStudent(student);

        }
    }
}