
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.DAL.Entities;

namespace Project
{
    public class StudentSevice
    {
        private StudentRepository _studentRepository;
        public StudentSevice()
        {
            _studentRepository = new StudentRepository();
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll().ToList();
        }

        public List<Student> GetAllById(int id)
        {
            return _studentRepository.GetAll()
                                     .Where(s => s.Id == id)
                                     .ToList();
        }
        public List<Student> GetAllByName(string name)
        {
            return _studentRepository.GetAll()
                                     .Where(s => s.Name == name)
                                     .ToList();
        }
        public Student? GetByName(string name)
        {
            return _studentRepository.GetAll().FirstOrDefault(s => s.Name == name);
        }

        public void Add(Student student)
        {
            _studentRepository.Add(student);

        }
        public void AddList(List<Student> students)
        {
            _studentRepository.AddList(students);

        }
        public void Delete(Student student)
        {
            _studentRepository.Delete(student);
           
        }
        public void DeleteById(int id)
        {
            var student = _studentRepository.GetAll().FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _studentRepository.Delete(student);
            }
        }
        public void DeleteByName(string name)
        {
            var student = _studentRepository.GetAll().FirstOrDefault(s => s.Name == name);
            if (student != null)
            {
                _studentRepository.Delete(student);
            }
        }
        public void Update(Student student)
        {
            _studentRepository.Update(student);
            
        }
        public void UpdateById(int id)
        {
            var student = _studentRepository.GetAll().FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _studentRepository.Update(student);
            }
        }
        public void UpdateByName(string name)
        {
            var student = _studentRepository.GetAll().FirstOrDefault(s => s.Name == name);
            if (student != null)
            {
                student.Name = name;
                _studentRepository.Update(student);
            }
        }
    }
}
