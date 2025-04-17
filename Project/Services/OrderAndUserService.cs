using Project.DAL;
using Project.DAL.Enteties;
using Project.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Diagnostics;
public class UserSOrderService
{
    public readonly UserRepository _userRepository;
    public readonly OrderRepository _orderRepository;

    public UserSOrderService()
    {
        _userRepository = new UserRepository();
        _orderRepository = new OrderRepository();
    }


    //========== Users ===========


    public void AddUser(string name)
    {
        var user = new User { Name = name };
        _userRepository.Add(user);
    }

    public void UpdateUser(int id, string name)
    {
        var user = _userRepository.GetAll().FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            user.Name = name;
            _userRepository.Update(user);
        }
    }

    public void DeleteUser(int id)
    {
        var user = _userRepository.GetAll().FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            _userRepository.Delete(user);
        }
    }
    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAll();
    }
    public void ShowAllUsers()
    {
        var users = GetAllUsers();
        foreach (var user in users)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}");
        }
    }



    //========= Orders ==============


    public void AddOrder(string name, int userId)
    {
       // var order = new Order { Product = name, UserId = userId  };
       // _orderRepository.Add(order);
    }
    public void UpdateOrder(int id, string name)
    {
        var order = _orderRepository.GetAll().FirstOrDefault(o => o.Id == id);
        if (order != null)
        {
            order.Product.Name= name;
            _orderRepository.Update(order);
        }
    }

    public void DeleteOrder(int id)
    {
        var order = _orderRepository.GetAll().FirstOrDefault(o => o.Id == id);
        if (order != null)
        {
            _orderRepository.Delete(order);
        }
    }

    public IEnumerable<Order> GetAllOrders()
    {
        return _orderRepository.GetAll();
    }

    public void ShowAllOrders()
    {
        var orders = GetAllOrders();
        foreach (var order in orders)
        {
            Console.WriteLine($"Id: {order.Id}, Name: {order.Product.Name}, UserId: {order.UserId}");
        }
    }

    public void ShowAllUsersWithOrders()
    {
        var users = GetAllUsers();
        foreach (var user in users)
        {
            Console.WriteLine($" User id: {user.Id} ,User: {user.Name}");
            var orders = GetAllOrders().Where(o => o.UserId == user.Id);
            foreach (var order in orders)
            {
               Console.WriteLine($"\tOrder: {order.Product.Name}");
            }
        }
    }


}