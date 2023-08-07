namespace DevHobby.Models.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;

        public int ChapterId { get; set; }
    }
}