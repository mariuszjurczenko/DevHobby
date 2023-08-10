namespace DevHobby.Models.Entities
{
    public class Description
    {
        public int DescriptionId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<WhatWillYouLearn> WhatWillYouLearn { get; set; }
        public ICollection<Requirement>? Requirements { get; set; }
        public ICollection<WhoIsThisCourseFor>? WhoIsThisCourseFor { get; set; }
        public string Content { get; set; } = string.Empty;

        public int CourseId { get; set; }
    }
}