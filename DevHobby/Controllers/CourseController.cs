using DevHobby.Models.Entities;
using DevHobby.Models.Repositories;
using DevHobby.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevHobby.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository)
        {
            _courseRepository = courseRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List(string category)
        {
            IEnumerable<Course> courses;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                courses = _courseRepository.AllCourses.OrderBy(p => p.CourseId);
                currentCategory = "Wszystkie";
            }
            else
            {
                courses = _courseRepository.AllCourses
                    .Where(p => p.Category.Name == category)
                    .OrderBy(p => p.CourseId);

                currentCategory = _categoryRepository.AllCategories
                    .FirstOrDefault(c => c.Name == category)?.Name;
            }

            return View(new CourseListViewModel(courses, currentCategory));
        }

        public IActionResult Details(int id)
        {
            var course = _courseRepository.GetCourseById(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }
    }
}
