using DevHobby.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevHobby.Models
{
    public class DevHobbyDbContext : IdentityDbContext
    {
        public DevHobbyDbContext(DbContextOptions<DevHobbyDbContext> options) : base(options)
        {
        }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<WhatWillYouLearn> WhatWillYouLearn { get; set; }
        public DbSet<WhoIsThisCourseFor> WhoIsThisCourseFor { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
