namespace DiabloBuildTracker.Api.Models
{
    public class SkillCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();
    }
}
