using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class DruidActiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 134,
                    Name = "Maul",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 135,
                    Name = "Claw",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 136,
                    Name = "Storm Strike",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 137,
                    Name = "Wind Shear",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 138,
                    Name = "Earth Spike",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 2, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 139,
                    Name = "Lightning Storm",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 140,
                    Name = "Tornado",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 141,
                    Name = "Pulverize",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 142,
                    Name = "Shred",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 143,
                    Name = "Landslide",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 3, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 144,
                    Name = "Earthen Bulwark",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 145,
                    Name = "Cyclone Armor",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 146,
                    Name = "Blood Howl",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 147,
                    Name = "Debilitating Roar",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 5, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 148,
                    Name = "Wolves",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 10, // Companion Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 149,
                    Name = "Ravens",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 10, // Companion Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 150,
                    Name = "Poison Creeper",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 10, // Companion Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 151,
                    Name = "Boulder",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 11, // Wrath Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 152,
                    Name = "Trample",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 11, // Wrath Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 153,
                    Name = "Hurricane",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 11, // Wrath Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 154,
                    Name = "Rabies",
                    MaxRank = 5,
                    ClassId = 2,
                    SkillCategoryId = 11, // Wrath Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 155,
                    Name = "Grizzly Rage",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 156,
                    Name = "Petrify",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 157,
                    Name = "Lacerate",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 158,
                    Name = "Cataclysm",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                }
                );
        }
    }
}
