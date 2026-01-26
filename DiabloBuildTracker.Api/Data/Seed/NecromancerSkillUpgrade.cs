using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class NecromancerSkillUpgradeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillUpgrade>().HasData(
                new SkillUpgrade
                {
                    Id = 332,
                    SkillId = 272, // Bone Splinters
                    Name = "Enhanced Bone Splinters",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 333,
                    SkillId = 272, // Bone Splinters
                    Name = "Acolyte's Bone Splinters",
                    RequiredUpgradeId = 332,
                },
                new SkillUpgrade
                {
                    Id = 334,
                    SkillId = 272, // Bone Splinters
                    Name = "Initiate's Bone Splinters",
                    RequiredUpgradeId = 332,
                },
                new SkillUpgrade
                {
                    Id = 335,
                    SkillId = 273, // Decompose
                    Name = "Enhanced Decompose",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 336,
                    SkillId = 273, // Decompose
                    Name = "Acolyte's Decompose",
                    RequiredUpgradeId = 335,
                },
                new SkillUpgrade
                {
                    Id = 337,
                    SkillId = 273, // Decompose
                    Name = "Initiate's Decompose",
                    RequiredUpgradeId = 335,
                },
                new SkillUpgrade
                {
                    Id = 338,
                    SkillId = 274, // Hemorrhage
                    Name = "Enhanced Hemorrhage",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 339,
                    SkillId = 274, // Hemorrhage
                    Name = "Acolyte's Hemorrhage",
                    RequiredUpgradeId = 338,
                },
                new SkillUpgrade
                {
                    Id = 340,
                    SkillId = 274, // Hemorrhage
                    Name = "Initiate's Hemorrhage",
                    RequiredUpgradeId = 338,
                },
                new SkillUpgrade
                {
                    Id = 341,
                    SkillId = 275, // Reap
                    Name = "Enhanced Reap",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 342,
                    SkillId = 275, // Reap
                    Name = "Acolyte's Reap",
                    RequiredUpgradeId = 341,
                },
                new SkillUpgrade
                {
                    Id = 343,
                    SkillId = 275, // Reap
                    Name = "Initiate's Reap",
                    RequiredUpgradeId = 341,
                },
                new SkillUpgrade
                {
                    Id = 344,
                    SkillId = 276, // Blight
                    Name = "Enhanced Blight",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 345,
                    SkillId = 276, // Blight
                    Name = "Paranormal Blight",
                    RequiredUpgradeId = 344,
                },
                new SkillUpgrade
                {
                    Id = 346,
                    SkillId = 276, // Blight
                    Name = "Supernatual Blight",
                    RequiredUpgradeId = 344,
                },
                new SkillUpgrade
                {
                    Id = 347,
                    SkillId = 277, // Blood Lance
                    Name = "Enhanced Blood Lance",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 348,
                    SkillId = 277, // Blood Lance
                    Name = "Paranormal Blood Lance",
                    RequiredUpgradeId = 347,
                },
                new SkillUpgrade
                {
                    Id = 349,
                    SkillId = 277, // Blood Lance
                    Name = "Supernatual Blood Lance",
                    RequiredUpgradeId = 347,
                },
                new SkillUpgrade
                {
                    Id = 350,
                    SkillId = 278, // Blood Surge
                    Name = "Enhanced Blood Surge",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 351,
                    SkillId = 278, // Blood Surge
                    Name = "Paranormal Blood Surge",
                    RequiredUpgradeId = 350,
                },
                new SkillUpgrade
                {
                    Id = 352,
                    SkillId = 278, // Blood Surge
                    Name = "Supernatural Blood Surge",
                    RequiredUpgradeId = 350,
                },
                new SkillUpgrade
                {
                    Id = 353,
                    SkillId = 279, // Bone Spear
                    Name = "Enhanced Bone Spear",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 354,
                    SkillId = 279, // Bone Spear
                    Name = "Paranormal Bone Spear",
                    RequiredUpgradeId = 353,
                },
                new SkillUpgrade
                {
                    Id = 355,
                    SkillId = 279, // Bone Spear
                    Name = "Supernatual Bone Spear",
                    RequiredUpgradeId = 353,
                },
                new SkillUpgrade
                {
                    Id = 356,
                    SkillId = 280, // Sever
                    Name = "Enhanced Sever",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 357,
                    SkillId = 280, // Sever
                    Name = "Paranormal Sever",
                    RequiredUpgradeId = 356,
                },
                new SkillUpgrade
                {
                    Id = 358,
                    SkillId = 280, // Sever
                    Name = "Supernatual Sever",
                    RequiredUpgradeId = 356,
                },
                new SkillUpgrade
                {
                    Id = 359,
                    SkillId = 281, // Blood Mist
                    Name = "Enhanced Blood Mist",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 360,
                    SkillId = 281, // Blood Mist
                    Name = "Dreadful Blood Mist",
                    RequiredUpgradeId = 359,
                },
                new SkillUpgrade
                {
                    Id = 361,
                    SkillId = 281, // Blood Mist
                    Name = "Ghastly Blood Mist",
                    RequiredUpgradeId = 359,
                },
                new SkillUpgrade
                {
                    Id = 362,
                    SkillId = 282, // Bone Prison
                    Name = "Enhanced Bone Prison",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 363,
                    SkillId = 282, // Bone Prison
                    Name = "Dreadful Bone Prison",
                    RequiredUpgradeId = 362,
                },
                new SkillUpgrade
                {
                    Id = 364,
                    SkillId = 282, // Bone Prison
                    Name = "Ghastly Bone Prison",
                    RequiredUpgradeId = 362,
                },
                new SkillUpgrade
                {
                    Id = 365,
                    SkillId = 283, // Corpse Explosion
                    Name = "Enhanced Corpse Explosion",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 366,
                    SkillId = 283, // Corpse Explosion
                    Name = "Dreadful Corpse Explosion",
                    RequiredUpgradeId = 365,
                },
                new SkillUpgrade
                {
                    Id = 367,
                    SkillId = 283, // Corpse Explosion
                    Name = "Ghastly Corpse Explosion",
                    RequiredUpgradeId = 365,
                },
                new SkillUpgrade
                {
                    Id = 368,
                    SkillId = 284, // Decrepify
                    Name = "Enhanced Decrepify",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 369,
                    SkillId = 284, // Decrepify
                    Name = "Abhorrent Decrepify",
                    RequiredUpgradeId = 368,
                },
                new SkillUpgrade
                {
                    Id = 370,
                    SkillId = 284, // Decrepify
                    Name = "Horrid Decrepify",
                    RequiredUpgradeId = 368,
                },
                new SkillUpgrade
                {
                    Id = 371,
                    SkillId = 285, // Iron Maiden
                    Name = "Enhanced Iron Maiden",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 372,
                    SkillId = 285, // Iron Maiden
                    Name = "Abhorrent Iron Maiden",
                    RequiredUpgradeId = 371,
                },
                new SkillUpgrade
                {
                    Id = 373,
                    SkillId = 285, // Iron Maiden
                    Name = "Horrid Iron Maiden",
                    RequiredUpgradeId = 371,
                },
                new SkillUpgrade
                {
                    Id = 374,
                    SkillId = 286, // Bone Spirit
                    Name = "Enhanced Bone Spirit",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 375,
                    SkillId = 286, // Bone Spirit
                    Name = "Dreadful Bone Spirit",
                    RequiredUpgradeId = 374,
                },
                new SkillUpgrade
                {
                    Id = 376,
                    SkillId = 286, // Bone Spirit
                    Name = "Ghastly Bone Spirit",
                    RequiredUpgradeId = 374,
                },
                new SkillUpgrade
                {
                    Id = 377,
                    SkillId = 287, // Corpse Tendrils
                    Name = "Enhanced Corpse Tendrils",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 378,
                    SkillId = 287, // Corpse Tendrils
                    Name = "Dreadful Corpse Tendrils",
                    RequiredUpgradeId = 377,
                },
                new SkillUpgrade
                {
                    Id = 379,
                    SkillId = 287, // Corpse Tendrils
                    Name = "Ghastly Corpse Tendrils",
                    RequiredUpgradeId = 377,
                },
                new SkillUpgrade
                {
                    Id = 380,
                    SkillId = 288, // Army of the Dead
                    Name = "Prime Army of the Dead",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 381,
                    SkillId = 288, // Army of the Dead
                    Name = "Supreme Army of the Dead",
                    RequiredUpgradeId = 380,
                },
                new SkillUpgrade
                {
                    Id = 382,
                    SkillId = 289, // Blood Wave
                    Name = "Prime Blood Wave",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 383,
                    SkillId = 289, // Blood Wave
                    Name = "Supreme Blood Wave",
                    RequiredUpgradeId = 382,
                },
                new SkillUpgrade
                {
                    Id = 384,
                    SkillId = 290, // Bone Storm
                    Name = "Prime Bone Storm",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 385,
                    SkillId = 290, // Bone Storm
                    Name = "Supreme Bone Storm",
                    RequiredUpgradeId = 384,
                },
                new SkillUpgrade
                {
                    Id = 386,
                    SkillId = 291, // Soulrift
                    Name = "Prime Soulrift",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 387,
                    SkillId = 291, // Soulrift
                    Name = "Supreme Soulrift",
                    RequiredUpgradeId = 386,
                }
                    );
        }
    }
}
