using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class BarbarianPassiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 25,
                    Name = "Pressure Point",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive 
                },
                new Skill
                {
                    Id = 26,
                    Name = "Endless Cry",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive 
                },
                new Skill
                {
                    Id = 27,
                    Name = "Warpath",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive 
                },
                new Skill
                {
                    Id = 28,
                    Name = "Imposing Presence",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive 
                },
                new Skill
                {
                    Id = 29,
                    Name = "Martial Vigor",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive 
                },
                new Skill
                {
                    Id = 30,
                    Name = "Outburst",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 31,
                    Name = "Tough As Nails",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 32,
                    Name = "Belligerence",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 33,
                    Name = "Booming Voice",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 34,
                    Name = "Raid Leader",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 35,
                    Name = "Guttural Yell",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 36,
                    Name = "Aggressive Resistance",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 37,
                    Name = "Battle Fervor",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 38,
                    Name = "Prolific Fury",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 39,
                    Name = "Swiftness",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 40,
                    Name = "Quick Impulses",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 41,
                    Name = "No Mercy",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 42,
                    Name = "Slaying Strike",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 43,
                    Name = "Expose Vulnerability",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 44,
                    Name = "Thick Skin",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 45,
                    Name = "Defensive Stance",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 46,
                    Name = "Counteroffensive",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 47,
                    Name = "Hamstring",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 48,
                    Name = "Cut To The Bone",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 49,
                    Name = "Pit Fighter",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 50,
                    Name = "Irrepressible",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 51,
                    Name = "Heavy Handed",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 52,
                    Name = "Wallop ",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 53,
                    Name = "Brute Force",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 54,
                    Name = "Concussion",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 55,
                    Name = "Tempered Fury",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 56,
                    Name = "Furious Impulse",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 57,
                    Name = "Invigorating Fury",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 58,
                    Name = "Duelist",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 59,
                    Name = "Heavy Hitter",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 60,
                    Name = "Unconstrained",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 61,
                    Name = "Walking Arsenal",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 62,
                    Name = "Unbridled Rage",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 63,
                    Name = "Gushing Wounds",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 64,
                    Name = "Barbed Carapace",
                    MaxRank = 3,
                    ClassId = 1,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                }
                );
        }
    }
}
