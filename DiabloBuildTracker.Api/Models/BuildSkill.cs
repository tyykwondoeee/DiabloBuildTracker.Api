namespace DiabloBuildTracker.Api.Models
{
    public class BuildSkill
    {
        public int BuildId { get; set; }
        public Build Build { get; set; } = null!;
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
        public int Rank { get; set; }
    }
}
