namespace DevHobby.Models.Entities
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

        public int ContentId { get; set; }
    }
}