using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class DruidPassiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 159,
                    Name = "Heart Of The Wind",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 160,
                    Name = "Wild Impulses",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 161,
                    Name = "Abundance",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 162,
                    Name = "Predatory Instinct",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 163,
                    Name = "Digitigrade Gait",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 164,
                    Name = "Iron Fur",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 165,
                    Name = "Ancestral Fortitude",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 166,
                    Name = "Vigilance",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 167,
                    Name = "Nature's Reach",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 168,
                    Name = "Call Of The Wind",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 169,
                    Name = "Clarity",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 170,
                    Name = "Elemental Exposure",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 171,
                    Name = "Charged Atmosphere",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 172,
                    Name = "Electric Shock",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 173,
                    Name = "Bad Omen",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 174,
                    Name = "Endless Tempest",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 175,
                    Name = "Crushing Earth",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 176,
                    Name = "Safeguard",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 177,
                    Name = "Stone Guard",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 178,
                    Name = "Mending",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 179,
                    Name = "Provocation",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 180,
                    Name = "Toxic",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 181,
                    Name = "Neurotoxin",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 182,
                    Name = "Envenom",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 183,
                    Name = "Defensive Posture",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 184,
                    Name = "Thick Hide",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 185,
                    Name = "Unrestrained",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 186,
                    Name = "Nature's Resolve",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 187,
                    Name = "Quickshift",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 188,
                    Name = "Natural Fortitude",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 189,
                    Name = "Heightened Senses",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 190,
                    Name = "Defiance",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 191,
                    Name = "Circle Of Life",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 192,
                    Name = "Resonance",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 193,
                    Name = "Natural Disaster",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 194,
                    Name = "Bestial Rampage",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 195,
                    Name = "Earthen Might",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 196,
                    Name = "Lupine Ferocity",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 197,
                    Name = "Nature's Fury",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 198,
                    Name = "Perfect Storm",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 199,
                    Name = "Ursine Strength",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 200,
                    Name = "One With Nature",
                    MaxRank = 3,
                    ClassId = 2,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                }
                );
        }
    }
}
