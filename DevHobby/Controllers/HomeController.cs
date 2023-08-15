using DevHobby.Models.Repositories;
using DevHobby.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Controllers;

public class HomeController : Controller
{
    private readonly ICourseRepository _courseRepository;

    public HomeController(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public IActionResult Index()
    {
        var courseOfTheMonth = _courseRepository.CourseOfTheMonth;
        var homeViewModel = new HomeViewModel(courseOfTheMonth);

        return View(homeViewModel);
    }
}
