namespace DevHobby.Models.Entities
{
    public class Faq
    {
        public int FaqId { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;

        public int CourseId { get; set; }
    }
}