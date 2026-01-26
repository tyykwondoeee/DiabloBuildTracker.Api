using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class RoguePassiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 412,
                    Name = "Target Practice",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 413,
                    Name = "Stutter Step",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 414,
                    Name = "Sturdy",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 415,
                    Name = "Siphoning Strikes",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 416,
                    Name = "Unstable Elixirs",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 417,
                    Name = "Rapid Gambits",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 418,
                    Name = "Trick Attacks",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 419,
                    Name = "Balestra",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 420,
                    Name = "Weapon Mastery",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 421,
                    Name = "Rugged",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 422,
                    Name = "Reactive Defense",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 423,
                    Name = "Agile",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 424,
                    Name = "Mending Obscurity",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 425,
                    Name = "Evasive",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 426,
                    Name = "Exploit",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 427,
                    Name = "Malice",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 428,
                    Name = "Frigid Finesse",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 429,
                    Name = "Chilling Weight",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 430,
                    Name = "Precision Imbuement",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 431,
                    Name = "Deadly Venom",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 432,
                    Name = "Alchemical Advantage",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 433,
                    Name = "Debilitating Toxins",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 434,
                    Name = "Shadow Crash",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 435,
                    Name = "Consuming Shadows",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 436,
                    Name = "Trap Mastery",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 437,
                    Name = "Innervation",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 438,
                    Name = "Alchemist's Fortune",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 439,
                    Name = "Second Wind",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 440,
                    Name = "Aftermath",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 441,
                    Name = "Unto Dawn",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 442,
                    Name = "Adrenaline Rush",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 443,
                    Name = "Haste",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 444,
                    Name = "Impetus",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 445,
                    Name = "Alchemical Admixture",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 446,
                    Name = "Close Quarters Combat",
                    MaxRank = 3,
                    ClassId = 4,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 447,
                    Name = "Exposure",
                    MaxRank = 1,
                    ClassId = 4,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 448,
                    Name = "Momentum",
                    MaxRank = 1,
                    ClassId = 4,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 449,
                    Name = "Precision",
                    MaxRank = 1,
                    ClassId = 4,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 450,
                    Name = "Victimize",
                    MaxRank = 1,
                    ClassId = 4,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                }
                );
        }
    }
}
