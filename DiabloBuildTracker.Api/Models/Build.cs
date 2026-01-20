namespace DiabloBuildTracker.Api.Models
{
    public class Build
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;
        public int Level { get; set; }
        public string Difficulty { get; set; } = null!;
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<BuildSkill> BuildSkills { get; set; } = new List<BuildSkill>();
        public ICollection<BuildItem> BuildItems { get; set; } = new List<BuildItem>();
    }
}
