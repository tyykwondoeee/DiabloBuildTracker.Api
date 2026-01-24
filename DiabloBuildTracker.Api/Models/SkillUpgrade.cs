using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Models
{
    public class SkillUpgrade
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RequiredUpgradeId { get; set; }
    }
}
