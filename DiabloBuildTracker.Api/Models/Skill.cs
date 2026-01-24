using DiabloBuildTracker.Api.Models.Enums;

namespace DiabloBuildTracker.Api.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int MaxRank { get; set; }
        public int SkillCategoryId { get; set; }
        public SkillCategory SkillCategory { get; set; } = null!;
        public SkillType SkillType { get; set; }
        public ICollection<BuildSkill> BuildSkills { get; set; } = new List<BuildSkill>();
        public ICollection<SkillUpgrade> SkillUpgrades { get; set; }
         = new List<SkillUpgrade>();
    }
}
