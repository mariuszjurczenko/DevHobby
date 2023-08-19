using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories;

public interface IShoppingCart
{
    void AddToCart(Course course);

    int RemoveFromCart(Course course);

    List<ShoppingCartItem> GetShoppingCartItems();

    void ClearCart();

    decimal GetShoppingCartTotal();

    List<ShoppingCartItem> ShoppingCartItems { get; set; }
}
