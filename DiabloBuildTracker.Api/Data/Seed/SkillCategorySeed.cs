using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SkillCategorySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillCategory>().HasData(
                new SkillCategory { Id = 1, Name = "Basic" },
                new SkillCategory { Id = 2, Name = "Core" },
                new SkillCategory { Id = 3, Name = "Defensive" },
                new SkillCategory { Id = 4, Name = "Passive" },
                new SkillCategory { Id = 5, Name = "Brawling" },
                new SkillCategory { Id = 6, Name = "Weapon Mastery" },
                new SkillCategory { Id = 7, Name = "Upgrades" },
                new SkillCategory { Id = 8, Name = "Ultimate" },
                new SkillCategory { Id = 9, Name = "Key Passive" },
                new SkillCategory { Id = 10, Name = "Companion" },
                new SkillCategory { Id = 11, Name = "Wrath" },
                new SkillCategory { Id = 12, Name = "Curse" },
                new SkillCategory { Id = 13, Name = "Corpse & Macabre" },
                new SkillCategory { Id = 14, Name = "Agility"},
                new SkillCategory { Id = 15, Name = "Subterfuge"},
                new SkillCategory { Id = 16, Name = "Imbuement"},
                new SkillCategory { Id = 17, Name = "Conjuration"},
                new SkillCategory { Id =18, Name = "Mastery"}
                );
        }
    }
}
