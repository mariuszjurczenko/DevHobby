namespace DevHobby.Models.Entities
{
    public class WhoIsThisCourseFor
    {
        public int WhoIsThisCourseForId { get; set; }
        public string Content { get; set; } = string.Empty;

        public int DescriptionId { get; set; }
    }
}