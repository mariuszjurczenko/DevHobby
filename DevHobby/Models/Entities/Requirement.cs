namespace DevHobby.Models.Entities
{
    public class Requirement
    {
        public int RequirementId { get; set; }
        public string Content { get; set; } = string.Empty;

        public int DescriptionId { get; set; }
    }
}