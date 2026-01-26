using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class NecromancerPassiveSkillSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 292,
                    Name = "Unliving Energy",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 293,
                    Name = "Imperfectly Balanced",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 294,
                    Name = "Hewed Flesh",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 295,
                    Name = "Grim Harvest",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 296,
                    Name = "Fueled By Death",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 297,
                    Name = "Necrotic Fortitude",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 298,
                    Name = "Titan's Fall",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 299,
                    Name = "Skeletal Warrior Mastery",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 300,
                    Name = "Spiked Armor",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 301,
                    Name = "Amplify Damage",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 302,
                    Name = "Death's Embrace",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 303,
                    Name = "Skeletal Mage Mastery",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 304,
                    Name = "Precision Decay",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 305,
                    Name = "Gruesome Mending",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 306,
                    Name = "Coalesced Blood",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 307,
                    Name = "Transfusion",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 308,
                    Name = "Drain Vitality",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 309,
                    Name = "Tides Of Blood",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 310,
                    Name = "Reaper's Pursuit",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 311,
                    Name = "Crippling Darkness",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 312,
                    Name = "Gloom",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 313,
                    Name = "Terror",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 314,
                    Name = "Serration",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 315,
                    Name = "Compound Fracture",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 316,
                    Name = "Evulsion",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 317,
                    Name = "Rapid Ossification",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 318,
                    Name = "Necrotic Carapace",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 319,
                    Name = "Finality",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 320,
                    Name = "Stand Alone",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 321,
                    Name = "Memento Mori",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 322,
                    Name = "Golem Mastery",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 323,
                    Name = "Bonded in Essence",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 324,
                    Name = "Inspiring Leader",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 325,
                    Name = "Death's Defense",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 326,
                    Name = "Hellbent Commander",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 4, // Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 327,
                    Name = "Kalan's Edict",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 328,
                    Name = "Ossified Essence",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 329,
                    Name = "Affliction",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 330,
                    Name = "Rathma;s Vigor",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                },
                new Skill
                {
                    Id = 331,
                    Name = "Shadowblight",
                    MaxRank = 3,
                    ClassId = 3,
                    SkillCategoryId = 9, // Key Passive
                    SkillType = SkillType.Passive
                }
                );
        }
    }
}
