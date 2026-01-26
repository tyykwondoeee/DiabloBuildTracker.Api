using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SorcererPassiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 545,
                    Name = "Devastation",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 546,
                    Name = "Elemental Dominance",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 547,
                    Name = "Potent Warding",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 548,
                    Name = "Elemental Attunment",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 549,
                    Name = "Glass Cannon",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 550,
                    Name = "Energy Focus",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 551,
                    Name = "Dampen Layer",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 552,
                    Name = "Align The Elements",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 553,
                    Name = "Mana Shield",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 554,
                    Name = "Protection",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 555,
                    Name = "Primordial Binding",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 556,
                    Name = "Precision Magic",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 557,
                    Name = "Inner Flames",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 558,
                    Name = "Crippling Flames",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 559,
                    Name = "Devouring Flames",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 560,
                    Name = "Icy Veil",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 561,
                    Name = "Cold Front",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 562,
                    Name = "Snap Freeze",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 563,
                    Name = "Static Discharge",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 564,
                    Name = "Invigorating Conduit",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 565,
                    Name = "Shocking Impact",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 566,
                    Name = "Elemental Synergies",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 567,
                    Name = "Evocation",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 568,
                    Name = "Fiery Surge",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 569,
                    Name = "Endless Pyre",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 570,
                    Name = "Soulfire",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 571,
                    Name = "Warmth",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 572,
                    Name = "Permafrost",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 573,
                    Name = "Hoarfrost",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 574,
                    Name = "Icy Touch",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 575,
                    Name = "Frigid Breeze",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 576,
                    Name = "Coursing Currents",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 577,
                    Name = "Conduction",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 578,
                    Name = "Electrocution",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 579,
                    Name = "Convulsions",
                    MaxRank = 3,
                    ClassId = 5,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 580,
                    Name = "Enlightenment",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 581,
                    Name = "Combustion",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 582,
                    Name = "Esu's Ferocity",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 583,
                    Name = "Avalanche",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill 
                {
                    Id = 584,
                    Name = "Shatter",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 585,
                    Name = "Overflowing Energy",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 586,
                    Name = "Vyr's Mastery",
                    MaxRank = 1,
                    ClassId = 5,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                }
                );
        }
    }
}
