using DevHobby.Models.Repositories;

namespace DevHobby.ViewModels;

public class ShoppingCartSummaryViewModel
{
    public ShoppingCartSummaryViewModel(IShoppingCart shoppingCart, int amount)
    {
        ShoppingCart = shoppingCart;
        Amount = amount;
    }

    public IShoppingCart ShoppingCart { get; }
    public int Amount { get; set; }
}
