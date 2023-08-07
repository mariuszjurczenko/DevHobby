namespace DevHobby.Models.Entities
{
    public class Content
    {
        public int ContentId { get; set; }
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

        public int CourseId { get; set; }
    }
}