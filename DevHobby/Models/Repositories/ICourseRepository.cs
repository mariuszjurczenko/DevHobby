using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> AllCourses { get; }
        IEnumerable<Course> CourseOfTheMonth { get; }
        IEnumerable<Course> Recommended { get; }
        Course? GetCourseById(int courseId);
    }
}
