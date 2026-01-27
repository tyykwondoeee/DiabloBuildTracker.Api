using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SpiritbornPassiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 683,
                    Name = "Vigorous",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 684,
                    Name = "Velocity",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 685,
                    Name = "Follow Through",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 686,
                    Name = "Apex",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 687,
                    Name = "Diminishment",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 688,
                    Name = "Mirage",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 689,
                    Name = "Unrestrained Power",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 690,
                    Name = "Swift",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 691,
                    Name = "Endurance",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 692,
                    Name = "Perseverance",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 693,
                    Name = "Fueld",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 694,
                    Name = "Patient Guard",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 695,
                    Name = "Auspicious",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 696,
                    Name = "Bastion",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 697,
                    Name = "Antivenom",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 698,
                    Name = "Nourisment",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 699,
                    Name = "Resilient",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 700,
                    Name = "Dominant",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 701,
                    Name = "Brilliance",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 702,
                    Name = "Acceleration",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 703,
                    Name = "Potent",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 704,
                    Name = "Furnace",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 705,
                    Name = "Ravenous",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 706,
                    Name = "Oppressive",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 707,
                    Name = "Resolution",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 708,
                    Name = "Spiritual Attunement",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 709,
                    Name = "Sustenance",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 710,
                    Name = "Supremacy",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 711,
                    Name = "Initiative",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 712,
                    Name = "Intricacy",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 713,
                    Name = "Vital Strikes",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 714,
                    Name = "Adaptive Stances",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 715,
                    Name = "Prodigy's Tempo",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 716,
                    Name = "Noxious Resonance",
                    MaxRank = 3,
                    ClassId = 6,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                }
                );
        }
    }
}