using DevHobby.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevHobby.Models.Repositories;

public class ShoppingCart : IShoppingCart
{
    private readonly DevHobbyDbContext _devHobbyDbContext;

    public string? ShoppingCartId { get; set; }

    public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

    private ShoppingCart(DevHobbyDbContext devHobbyDbContext)
    {
        _devHobbyDbContext = devHobbyDbContext;
    }

    public static ShoppingCart GetCart(IServiceProvider services)
    {
        ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

        var context = services.GetService<DevHobbyDbContext>()
            ?? throw new Exception("Error initializing");

        var cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

        session?.SetString("CartId", cartId);

        return new ShoppingCart(context) { ShoppingCartId = cartId };
    }

    public void AddToCart(Course course)
    {
        var shoppingCartItem = _devHobbyDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Course.CourseId == course.CourseId
                      && s.ShoppingCartId == ShoppingCartId);

        if (shoppingCartItem == null)
        {
            shoppingCartItem = new ShoppingCartItem
            {
                ShoppingCartId = ShoppingCartId,
                Course = course,
                Amount = 1
            };

            _devHobbyDbContext.ShoppingCartItems.Add(shoppingCartItem);
        }
        else
        {
            shoppingCartItem.Amount++;
        }
        _devHobbyDbContext.SaveChanges();
    }

    public int RemoveFromCart(Course course)
    {
        var shoppingCartItem = _devHobbyDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Course.CourseId == course.CourseId
                      && s.ShoppingCartId == ShoppingCartId);

        var localAmount = 0;

        if (shoppingCartItem != null)
        {
            if (shoppingCartItem.Amount > 1)
            {
                shoppingCartItem.Amount--;
                localAmount = shoppingCartItem.Amount;
            }
            else
            {
                _devHobbyDbContext.ShoppingCartItems.Remove(shoppingCartItem);
            }
        }

        _devHobbyDbContext.SaveChanges();

        return localAmount;
    }

    public List<ShoppingCartItem> GetShoppingCartItems()
    {
        return ShoppingCartItems ??= _devHobbyDbContext.ShoppingCartItems
            .Where(c => c.ShoppingCartId == ShoppingCartId)
            .Include(s => s.Course)
            .Include(s => s.Course.Description)
            .Include(s => s.Course.Description.WhatWillYouLearn)
            .ToList();
    }

    public void ClearCart()
    {
        var cartItems = _devHobbyDbContext.ShoppingCartItems
            .Where(cart => cart.ShoppingCartId == ShoppingCartId);

        _devHobbyDbContext.ShoppingCartItems.RemoveRange(cartItems);

        _devHobbyDbContext.SaveChanges();
    }

    public decimal GetShoppingCartTotal()
    {
        var total = _devHobbyDbContext.ShoppingCartItems
            .Where(c => c.ShoppingCartId == ShoppingCartId)
            .Select(c => c.Course.Price * c.Amount)
            .Sum();

        return total;
    }
}
