namespace DevHobby.Models.Entities
{
    public class Opinion
    {
        public int OpinionId { get; set; }
        public string Content { get; set; } = string.Empty;
        public byte NumberOfStars { get; set; }

        public int CourseId { get; set; }
    }
}