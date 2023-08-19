using DevHobby.Models.Repositories;
using DevHobby.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Components;

public class ShoppingCartSummary : ViewComponent
{
    private readonly IShoppingCart _shoppingCart;
    private int _amount = 0;

    public ShoppingCartSummary(IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }

    public IViewComponentResult Invoke()
    {
        _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

        foreach (var item in _shoppingCart.ShoppingCartItems)
        {
            _amount += item.Amount;
        }

        return View(new ShoppingCartSummaryViewModel(_shoppingCart, _amount));
    }
}
