namespace DevHobby.Models.Entities
{
    public class WhatWillYouLearn
    {
        public int WhatWillYouLearnId { get; set; }
        public string Content { get; set; } = string.Empty;

        public int DescriptionId { get; set; }
    }
}