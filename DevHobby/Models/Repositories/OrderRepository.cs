using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly DevHobbyDbContext _devHobbyDbContext;
    private readonly IShoppingCart _shoppingCart;

    public OrderRepository(DevHobbyDbContext devHobbyDbContext, IShoppingCart shoppingCart)
    {
        _devHobbyDbContext = devHobbyDbContext;
        _shoppingCart = shoppingCart;
    }

    public void CreateOrder(Order order)
    {
        order.OrderPlaced = DateTime.Now;
        order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
        order.OrderDetails = new List<OrderDetail>();

        List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;

        foreach (var shoppingCartItem in shoppingCartItems)
        {
            var orderDetail = new OrderDetail
            {
                Amount = shoppingCartItem.Amount,
                CourseId = shoppingCartItem.Course.CourseId,
                Price = shoppingCartItem.Course.Price
            };

            order.OrderDetails.Add(orderDetail);
        }

        _devHobbyDbContext.Orders.Add(order);
        _devHobbyDbContext.SaveChanges();
    }
}
