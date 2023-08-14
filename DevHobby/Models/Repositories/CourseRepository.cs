using DevHobby.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevHobby.Models.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DevHobbyDbContext _devHobbyDbContext;

        public CourseRepository(DevHobbyDbContext devHobbyDbContext)
        {
            _devHobbyDbContext = devHobbyDbContext;
        }

        public IEnumerable<Course> AllCourses 
            => _devHobbyDbContext.Courses
                .Include(c => c.Category)
                .Include(c => c.Description);

        public IEnumerable<Course> CourseOfTheMonth 
            => _devHobbyDbContext.Courses
                .Include(c => c.Category)
                .Include(c => c.Description)
                .Include(c => c.CourseContent)
                .Where(c => c.IsCourseOfTheMonth);

        public IEnumerable<Course> Recommended 
            => _devHobbyDbContext.Courses
               .Include(c => c.Category)
               .Include(c => c.Description)
               .Include(c => c.CourseContent)
               .Where(c => c.IsRecommended);

        public Course? GetCourseById(int courseId) 
            => _devHobbyDbContext.Courses
                .Include(c => c.Category)
                .Include(c => c.Description.WhoIsThisCourseFor)
                .Include(c => c.Description.WhatWillYouLearn)
                .Include(c => c.Description.Requirements)
                .Include(c => c.CourseContent).ThenInclude(c => c.Chapters!).ThenInclude(c => c.Lessons)
                .Include(c => c.Faq)
                .Include(c => c.Announcements)
                .Include(c => c.Opinions)
                .FirstOrDefault(c => c.CourseId == courseId);

    }
}
