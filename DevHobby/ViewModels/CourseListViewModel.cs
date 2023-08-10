using DevHobby.Models.Entities;

namespace DevHobby.ViewModels
{
    public class CourseListViewModel
    {
        public IEnumerable<Course>? Courses { get; set; }
        public string? Title { get; set; }

        public CourseListViewModel(IEnumerable<Course> courses, string? title)
        {
            Courses = courses;
            Title = title;
        }
    }
}
