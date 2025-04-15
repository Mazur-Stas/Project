using Project.DAL.Entities;
using Project;
using System.ComponentModel;
using Project.DAL;
using System.Xml.Serialization;

namespace Project.Services
{
    public class MenuService
    {
        private  StudentService _studentService;

        public MenuService()
        {
            _studentService = new StudentService();
        }

        public void Menu()
        {
            
            while (true)
            {
                Console.WriteLine("1. Add Studnet");
                Console.WriteLine("2. Update Student by Id");
                Console.WriteLine("3. Delete Student by Id");
                Console.WriteLine("4. Get all Student");
                Console.WriteLine("5. Get student by Id");
                Console.WriteLine("6. Get student by name");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Description:");
                        string desc = Console.ReadLine();

                        Console.Clear();
                        var student = new Student { Name = name, Description = desc };
                        _studentService.AddStudent(student);
                        Console.WriteLine("Adding succeed");

                        break;

                    case "2":
                        Console.WriteLine("Enter Id:");
                        string s = Console.ReadLine();
                        int.TryParse(s, out int res);

                        Console.WriteLine("Enter Name:");
                        string name1 = Console.ReadLine();

                        Console.WriteLine("Enter Description:");
                        string desc1 = Console.ReadLine();

                        Console.Clear();
                        _studentService.UpdateStudent(res, name1, desc1);
                        Console.WriteLine("Update succeed");
                        break;


                    case "3":
                        Console.WriteLine("Enter Id:");
                        string del = Console.ReadLine();
                        int.TryParse(del, out int res1);

                        Console.Clear();
                        _studentService.DeleteById(res1);
                        Console.WriteLine("Delete succeed");

                        break;


                    case "4":
                        Console.Clear();
                        GetAllStudents();
                        break;

                    case "5":
                        Console.Clear();
                        GetStudentById();
                        break;

                    case "6":
                        Console.Clear();
                        GetStudentByName();
                        break;
                }
            }
        }


        void GetStudentByName()
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            var student = _studentService.GetStudentByName(name);
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Desc: {student.Description}");
        }
        void GetStudentById()
        {
            Console.WriteLine("Enter Id:");
            string s = Console.ReadLine();
            int.TryParse(s, out int id);
            Student student = _studentService.GetStudentById(id);  
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Desc: {student.Description}");
        }

        void GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            foreach (var student in students)
            { 
                Console.WriteLine($"id: {student.Id}, Name: {student.Name}, Desc: {student.Description}");
            }
        }

    }
}
