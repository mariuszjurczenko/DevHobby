using DevHobby.Models.Entities;

namespace DevHobby.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Course> CoursesOfTheMonth { get; }

    public HomeViewModel(IEnumerable<Course> coursesOfTheMonth)
    {
        CoursesOfTheMonth = coursesOfTheMonth;
    }
}
