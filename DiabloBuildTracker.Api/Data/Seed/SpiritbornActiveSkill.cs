using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SpiritbornActiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 659,
                    Name = "Rock Splitter",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 660,
                    Name = "Thunderspike",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 661,
                    Name = "Thrash",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 662,
                    Name = "Withering Fist",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 1, // Basic Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 663,
                    Name = "Crushing Hand",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 664,
                    Name = "Quill Volley",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 665,
                    Name = "Rake",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 666,
                    Name = "Stinger",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 2, // Core Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 667,
                    Name = "Vortex",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 19, // Focus Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 668,
                    Name = "Soar",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 19, // Focus Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 669,
                    Name = "Ravager",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 19, // Focus Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 670,
                    Name = "Toxic Skin",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 19, // Focus Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 671,
                    Name = "Armored Hide",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 672,
                    Name = "Concussive Stomp",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 673,
                    Name = "Counterattack",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 674,
                    Name = "Scourge",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 3, // Defensive Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 675,
                    Name = "Payback",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 20, // Potency Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 676,
                    Name = "Razor Wings",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 20, // Potency Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 677,
                    Name = "Rushing Claw",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 20, // Potency Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 678,
                    Name = "Touch Of Death",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 20, // Potency Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 679,
                    Name = "The Protector",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 680,
                    Name = "The Seeker",
                    MaxRank = 5,
                    ClassId = 6,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 681,
                    Name = "The Hunter",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 682,
                    Name = "The Devourer",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 8, // Ultimate Skill
                    SkillType = SkillType.Active
                }
                );
        }
    }
}
