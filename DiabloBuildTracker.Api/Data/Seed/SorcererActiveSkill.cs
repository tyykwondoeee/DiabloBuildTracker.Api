using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SorcererActiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 520,
                    Name = "Fire Bolt",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 521,
                    Name = "Frost Bolt",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 522,
                    Name = "Arc Lash",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 523,
                    Name = "Spark",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 524,
                    Name = "Fireball",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 525,
                    Name = "Incinerate",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 526,
                    Name = "Frozen Orb",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 527,
                    Name = "Ice Shards",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 528,
                    Name = "Chain Lightning",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 529,
                    Name = "Charged Bolts",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 3, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 530,
                    Name = "Flame Shield",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 531,
                    Name = "Frost Nova",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 532,
                    Name = "Ice Armor",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 533,
                    Name = "Teleport",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 534,
                    Name = "Familiar",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 17, // Conjuration Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 535,
                    Name = "Hydra",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 17, // Conjuration Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 536,
                    Name = "Ice Blades",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 17, // Conjuration Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 537,
                    Name = "Lightning Spear",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 17, // Conjuration Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 538,
                    Name = "Firewall",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 18, // Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 539,
                    Name = "Meteor",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 18, // Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 540,
                    Name = "Blizzard",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 18, // Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 541,
                    Name = "Ball Lightning",
                    MaxRank = 5,
                    ClassId = 5,
                    SkillCategoryId = 18, // Mastery Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 542,
                    Name = "Inferno",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 543,
                    Name = "Deep Freeze",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 544,
                    Name = "Unstable Currents",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 8, //Ultimate Skill
                    SkillType = SkillType.Active
                }
                );
        }
    }
}
