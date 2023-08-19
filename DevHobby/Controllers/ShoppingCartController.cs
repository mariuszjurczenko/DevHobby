using DevHobby.Models.Repositories;
using DevHobby.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Controllers;

public class ShoppingCartController : Controller
{
    private readonly ICourseRepository _courseRepository;
    private readonly IShoppingCart _shoppingCart;

    public ShoppingCartController(ICourseRepository courseRepository, IShoppingCart shoppingCart)
    {
        _courseRepository = courseRepository;
        _shoppingCart = shoppingCart;
    }

    public ViewResult Index()
    {
        var items = _shoppingCart.GetShoppingCartItems();
        _shoppingCart.ShoppingCartItems = items;

        var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetShoppingCartTotal());

        return View(shoppingCartViewModel);
    }

    public RedirectToActionResult AddToShoppingCart(int courseId)
    {
        var selectedCourse = _courseRepository.AllCourses.FirstOrDefault(p => p.CourseId == courseId);

        if (selectedCourse != null)
        {
            _shoppingCart.AddToCart(selectedCourse);
        }

        return RedirectToAction("Index");
    }

    public RedirectToActionResult RemoveFromShoppingCart(int courseId)
    {
        var selectedCourse = _courseRepository.AllCourses.FirstOrDefault(p => p.CourseId == courseId);

        if (selectedCourse != null)
        {
            _shoppingCart.RemoveFromCart(selectedCourse);
        }

        return RedirectToAction("Index");
    }
}
