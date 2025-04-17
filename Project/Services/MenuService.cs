using Project.DAL.Entities;
using Project;
using System.ComponentModel;
using Project.DAL;
using System.Xml.Serialization;

namespace Project.Services
{
    public class MenuService
    {
        private readonly  StudentService _studentService;
        private readonly UserSOrderService _UserSOrderService;
        private readonly ProductService _productService;


        public MenuService()
        {
            _studentService = new StudentService();
            _UserSOrderService = new UserSOrderService();
            _productService = new ProductService();
        }

        public void Menu()
        {
            string choice;
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n\n0.Exit ");
                Console.WriteLine("======= Student =======");
                Console.WriteLine("1. Add Studnet");
                Console.WriteLine("2. Update Student by Id");
                Console.WriteLine("3. Delete Student by Id");
                Console.WriteLine("4. Get all Student");
                Console.WriteLine("5. Get student by Id");

                Console.WriteLine("======= Orders and Users =======");
                Console.WriteLine("6.Show all Users");
                Console.WriteLine("7.Add new Users");
                Console.WriteLine("8.Edit Users");
                Console.WriteLine("9.Delete Users");
                Console.WriteLine("10.Show all Orders");
                Console.WriteLine("11.Edit Orders");
                Console.WriteLine("12.Delete Orders");
                Console.WriteLine("13.Show all User with Ordes");

                Console.WriteLine("======= Product =======");
                Console.WriteLine("14.Show all Product");
                Console.WriteLine("15.Add new Product");
                Console.WriteLine("16.Edit Product");
                Console.WriteLine("17.Delete Product");


                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        
                        Console.WriteLine("Exit program");
                        isRunning = false;
                        break;

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
                        Console.WriteLine("Enter Id to update:");
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
                        Console.WriteLine("Enter Id to delete:");
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


                    //Users and Orders

                    case "6":
                        Console.Clear();
                        _UserSOrderService.ShowAllUsers();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Enter name:");
                        string userName = Console.ReadLine();
                        _UserSOrderService.AddUser(userName);
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Enter user Id to update:");
                        int userIdToUpdate = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new name:");
                        string newUserName = Console.ReadLine();
                        _UserSOrderService.UpdateUser(userIdToUpdate, newUserName);
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Enter user ID to delete:");
                        int userIdToRemove = int.Parse(Console.ReadLine());
                        _UserSOrderService.DeleteUser(userIdToRemove);
                        break;

                    case "10":
                        Console.Clear();
                        _UserSOrderService.ShowAllOrders();
                        break;

                    case "11":
                        Console.Clear();
                        Console.WriteLine("Enter order Id to update:");
                        int orderIdToUpdate = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new name:");
                        string newOrderName = Console.ReadLine();
                        _UserSOrderService.UpdateOrder(orderIdToUpdate, newOrderName);
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Enter order ID to delete:");
                        int orderIdToRemove = int.Parse(Console.ReadLine());
                        _UserSOrderService.DeleteOrder(orderIdToRemove);
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine("Users with Orders:");
                        _UserSOrderService.ShowAllUsersWithOrders();
                        break;

                    case "14":
                        Console.Clear();
                        Console.WriteLine("All product:");
                        _productService.ShowAllProduct();
                        break;

                    case "15":

                        Console.WriteLine("Enter Name:");
                        string name2 = Console.ReadLine();

                        Console.WriteLine("Enter Price:");
                        string price2 = Console.ReadLine();
                        int.TryParse(price2, out int res2);


                        Console.Clear();
                        var prod = new Product { Name = name2, Price = res2  };
                        _productService.AddProduct(prod);
                        Console.WriteLine("Adding succeed");
                        break;

                    case "16":
                        Console.WriteLine("Enter id to update:");
                        string Id3 = Console.ReadLine();
                        int.TryParse(Id3, out int resId);


                        Console.WriteLine("Enter new Name:");
                        string name3 = Console.ReadLine();

                        Console.WriteLine("Enter new Price:");
                        string price3 = Console.ReadLine();
                        int.TryParse(price3, out int res3);


                        Console.Clear();
                        var prod1 = new Product { Name = name3, Price = res3};
                        _productService.UpdateProduct(resId,prod1);
                        Console.WriteLine("Update succeed");
                        break;

                    case "17":
                        Console.WriteLine("Enter Id to delete:");
                        string del1 = Console.ReadLine();
                        int.TryParse(del1, out int res11);

                        Console.Clear();
                        _productService.DeleteById(res11);
                        Console.WriteLine("Delete succeed");

                        break;
                    default:
                        Console.WriteLine("error, try again.");
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
