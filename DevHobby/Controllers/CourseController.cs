using DevHobby.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IActionResult List()
        {
            ViewBag.Title = "Dev-Hobby - najlepsze kursy programistyczne !";

            var result = _courseRepository.AllCourses;
            return View(result);
        }
    }
}
