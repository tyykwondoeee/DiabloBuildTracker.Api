namespace DiabloBuildTracker.Api.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public ICollection<Build> Builds { get; set; } = new List<Build>();
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

    }
}
