namespace DevHobby.Models.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsCourseOfTheMonth { get; set; }
        public bool IsRecommended { get; set; }
        public Description Description { get; set; } = default!;
        public ICollection<Content> CourseContent { get; set; } = new List<Content>();
        public ICollection<Faq>? Faq { get; set; }
        public ICollection<Announcement>? Announcements { get; set; }
        public ICollection<Opinion>? Opinions { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
