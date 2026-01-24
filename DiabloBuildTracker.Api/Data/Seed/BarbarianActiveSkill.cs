using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class BarbarianActiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 1,
                    Name = "Bash",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 2,
                    Name = "Lunging Strike",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 3,
                    Name = "Frenzy",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 4,
                    Name = "Flay",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 5,
                    Name = "Whirlwind",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 6,
                    Name = "Hammer of the Ancients",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 7,
                    Name = "Upheaval",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 8,
                    Name = "Double Swing",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 9,
                    Name = "Rend",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 10,
                    Name = "Ground Stomp",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 11,
                    Name = "Rallying Cry",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 12,
                    Name = "Iron Skin",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 13,
                    Name = "Challenging Shout",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 14,
                    Name = "Kick",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 5, // Brawl Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 15,
                    Name = "War Cry",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 5, // Brawl Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 16,
                    Name = "Charge",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 5, // Brawl Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 17,
                    Name = "Leap",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 5, // Brawl Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 18,
                    Name = "Rupture",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 6, // Weapon Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 19,
                    Name = "Steel Grasp",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 6, // Weapon Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 20,
                    Name = "Death Blow",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 6, // Weapon Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 21,
                    Name = "Mighty Throw",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 6, // Weapon Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 22,
                    Name = "Call Of The Ancients",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 23,
                    Name = "Iron Maelstrom",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 24,
                    Name = "Wrath Of The Berserker",
                    MaxRank = 5,
                    ClassId = 1,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                }
                );
        }
    }
}
