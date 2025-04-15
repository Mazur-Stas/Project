using Microsoft.Win32.SafeHandles;
using Project.DAL;
using Project.DAL.Enteties;
using Project.DAL.Entities;
using Project.DAL.Repositories;

namespace Project.Services
{
    public class OrderAndUserService
    {
        private UserRepository _userRepository;
        private OrderRepository _orderRepository;

        public OrderAndUserService()
        {
            _userRepository = new UserRepository();
            _orderRepository = new OrderRepository();
        }
        public List<User> GetUsers()
        {
            return _userRepository.GetAllUsers().ToList();
        }
        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }
        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }


    }
}
