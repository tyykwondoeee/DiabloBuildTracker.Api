using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class RogueActiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 388,
                    Name = "Blade Shift",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 389,
                    Name = "Invigorating Strike",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 390,
                    Name = "Forceful Arrow",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 391,
                    Name = "Heartseeker",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 392,
                    Name = "Puncture",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 393,
                    Name = "Flurry",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 394,
                    Name = "Twisting Blades",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 395,
                    Name = "Barrage",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 396,
                    Name = "Penetrating Shot",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 397,
                    Name = "Rapid Fire",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 3, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 398,
                    Name = "Dance Of Knives",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 14, // Agility Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 399,
                    Name = "Shadow Step",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 14, // Agility Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 400,
                    Name = "Caltrops",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 14, // Agility Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 401,
                    Name = "Dash",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 14, // Agility Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 402,
                    Name = "Concealment",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 15, // Sunterfuge Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 403,
                    Name = "Dark Shroud",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 15, // Subterfuge Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 404,
                    Name = "Poison Trap",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 15, // Subterfuge Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 405,
                    Name = "Smoke Grenade",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 15, // Subterfuge Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 406,
                    Name = "Cold Imbuement",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 16, // Imbuement Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 407,
                    Name = "Poison Imbuement",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 16, // Imbuement Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 408,
                    Name = "Shadow Imbuement",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 16, // Imbuement Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 409,
                    Name = "Death Trap",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 410,
                    Name = "Rain Of Arrows",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 411,
                    Name = "Shadow Clone",
                    MaxRank = 5,
                    ClassId = 4,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                }
                );
        }
    }
}
