using Project.DAL.Entities;
using Project;
using System.ComponentModel;
using Project.DAL;
namespace ConsoleApp1.Services
{
    public class MenuService
    {
        private readonly StudentService _studentService;

        public MenuService()
        {
            _studentService = new StudentService();
        }

        public void Menu()
        {
            Console.WriteLine("1. Додати студента");
            Console.WriteLine("2. Додати декілька студентів");
            Console.WriteLine("3. Оновити студента");
            Console.WriteLine("4. Видалити студента");
            Console.WriteLine("5. Отримати всіх студентів");
            Console.WriteLine("6. Отримати студента за ID");
            Console.WriteLine("7. Отримати студента за іменем");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введіть ім'я студента:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Введіть опис студента:");
                    var desc = Console.ReadLine();
                    _studentService.AddStudent(new Student { Name = name, Description = desc });
                    Console.WriteLine("Студента додано!");
                    Console.Clear();
                    break;

                case "2":
                    break;
                    Console.Clear();

                case "3":
                    break;
                    Console.Clear();

                case "4":
                    Console.Clear();
                    break;

                case "5":

                    Console.Clear();
                    break;

                case "6":
                    GetStudentById();
                    Console.Clear();
                    break;

                case "7":
                    GetStudentByName();
                    break;

                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }
        }


        void GetStudentByName()
        {
            Console.WriteLine("Введіть ім'я студента:");
            string name = Console.ReadLine();
            var student = _studentService.GetStudentByName(name);
            Console.WriteLine($"ID: {student.Id}, Ім'я: {student.Name}, Опис: {student.Description}");
        }

        void GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            foreach (var student in students)
            {
                Console.Clear();
                Console.WriteLine($"ID: {student.Id}, Ім'я: {student.Name}, Опис: {student.Description}");
            }
        }
        private void GetStudentById()
        {
            Console.WriteLine("Введіть ID студента:");
            if (int.TryParse(Console.ReadLine(), out var id))
            {
                Console.WriteLine($"ID is: {id}");
            }
            var student = _studentService.GetStudentById(id);
            Console.Clear();
            Console.WriteLine($"ID: {student.Id}, Ім'я: {student.Name}, Опис: {student.Description}");
        }
    }
}
