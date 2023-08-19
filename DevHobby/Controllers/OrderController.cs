using DevHobby.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, IShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout() 
        {
            return View();
        }
    }
}
