namespace DevHobby.Models.Entities
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }
        public string Content { get; set; } = string.Empty;

        public int CourseId { get; set; }
    }
}