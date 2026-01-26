using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class NecromancerActiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 272,
                    Name = "Bone Splinters",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 273,
                    Name = "Decompose",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 274,
                    Name = "Hemorrhage",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 275,
                    Name = "Reap",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 276,
                    Name = "Blight",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 277,
                    Name = "Blood Lance",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 278,
                    Name = "Blood Surge",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 279,
                    Name = "Bone Spear",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 280,
                    Name = "Sever",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 281,
                    Name = "Blood Mist",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 13, // Corpse & Macabre Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 282,
                    Name = "Bone Prison",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 13, // Corpse & Macabre Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 283,
                    Name = "Corpse Explosion",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 13, // Corpse & Macabre Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 284,
                    Name = "Decrepify",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 12, // Curse Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 285,
                    Name = "Iron Maiden",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 12, // Curse Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 286,
                    Name = "Bone Spirit",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 13, // Corpse & Macabre Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 287,
                    Name = "Corpse Tendrils",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 13, // Corpse & Macabre Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 288,
                    Name = "Army Of The Dead",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 289,
                    Name = "Blood Wave",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 290,
                    Name = "Bone Storm",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 291,
                    Name = "Soulrift",
                    MaxRank = 5,
                    ClassId = 3,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                }
                );
        }
    }
}
