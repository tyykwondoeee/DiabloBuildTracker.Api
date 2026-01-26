using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class RogueSkillUpgradeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillUpgrade>().HasData(
                new SkillUpgrade
                {
                    Id = 451,
                    SkillId = 388, // Blade Shift
                    Name = "Enhanced Blade Shift",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 452,
                    SkillId = 388, // Blade Shift
                    Name = "Fundamental Blade Shift",
                    RequiredUpgradeId = 451,
                },
                new SkillUpgrade
                {
                    Id = 453,
                    SkillId = 388, // Blade Shift
                    Name = "Primary Blade Shift",
                    RequiredUpgradeId = 451,
                },
                new SkillUpgrade
                {
                    Id = 454,
                    SkillId = 389, // Invigorating Stirke
                    Name = "Enhanced Invigorating Strike",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 455,
                    SkillId = 389, // Invigorating Strike
                    Name = "Fundamental Invigorating Strike",
                    RequiredUpgradeId = 454,
                },
                new SkillUpgrade
                {
                    Id = 456,
                    SkillId = 389, // Invigorating Strike
                    Name = "Primary Invigorating Strike",
                    RequiredUpgradeId = 454,
                },
                new SkillUpgrade
                {
                    Id = 457,
                    SkillId = 390, // Forceful Arrow
                    Name = "Enhanced Forceful Arrow",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 458,
                    SkillId = 390, // Forceful Arrow
                    Name = "Fundamental Forceful Arrow",
                    RequiredUpgradeId = 457,
                },
                new SkillUpgrade
                {
                    Id = 459,
                    SkillId = 390, // Forceful Arrow
                    Name = "Primary Forceful Arrow",
                    RequiredUpgradeId = 457,
                },
                new SkillUpgrade
                {
                    Id = 460,
                    SkillId = 391, // Heartseeker
                    Name = "Enhanced Heartseeker",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 461,
                    SkillId = 391, // Heartseeker
                    Name = "Fundamental Heartseeker",
                    RequiredUpgradeId = 460,
                },
                new SkillUpgrade
                {
                    Id = 462,
                    SkillId = 391, // Heartseeker
                    Name = "Primary Heartseeker",
                    RequiredUpgradeId = 460,
                },
                new SkillUpgrade
                {
                    Id = 463,
                    SkillId = 392, // Puncture
                    Name = "Enhanced Puncture",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 464,
                    SkillId = 392, // Puncture
                    Name = "Fundamental Puncture",
                    RequiredUpgradeId = 463,
                },
                new SkillUpgrade
                {
                    Id = 465,
                    SkillId = 392, // Puncture
                    Name = "Primary Puncture",
                    RequiredUpgradeId = 463,
                },
                new SkillUpgrade
                {
                    Id = 466,
                    SkillId = 393, // Flurry
                    Name = "Enhanced Flurry",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 467,
                    SkillId = 393, // Flurry
                    Name = "Advanced Flurry",
                    RequiredUpgradeId = 466,
                },
                new SkillUpgrade
                {
                    Id = 468,
                    SkillId = 393, // Flurry
                    Name = "Improved Flurry",
                    RequiredUpgradeId = 466,
                },
                new SkillUpgrade
                {
                    Id = 469,
                    SkillId = 394, // Twisting Blades
                    Name = "Enhanced Twisting Blades",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 470,
                    SkillId = 394, // Twisting Blades
                    Name = "Advanced Twisting Blades",
                    RequiredUpgradeId = 469,
                },
                new SkillUpgrade
                {
                    Id = 471,
                    SkillId = 394, // Twisting Blades
                    Name = "Improved Twisting Blades",
                    RequiredUpgradeId = 469,
                },
                new SkillUpgrade
                {
                    Id = 472,
                    SkillId = 395, // Barrage
                    Name = "Enhanced Barrage",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 473,
                    SkillId = 395, // Barrage
                    Name = "Advanced Barrage",
                    RequiredUpgradeId = 472,
                },
                new SkillUpgrade
                {
                    Id = 474,
                    SkillId = 395, // Barrage
                    Name = "Improved Barrage",
                    RequiredUpgradeId = 472,
                },
                new SkillUpgrade
                {
                    Id = 475,
                    SkillId = 396, // Penetrating Shot
                    Name = "Enhanced Penetrating Shot",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 476,
                    SkillId = 396, // Penetrating Shot
                    Name = "Advanced Penetrating Shot",
                    RequiredUpgradeId = 475,
                },
                new SkillUpgrade
                {
                    Id = 477,
                    SkillId = 396, // Penetrating Shot
                    Name = "Improved Penetrating Shot",
                    RequiredUpgradeId = 475,
                },
                new SkillUpgrade
                {
                    Id = 478,
                    SkillId = 397, // Rapid Fire
                    Name = "Enhanced Rapid Fire",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 479,
                    SkillId = 397, // Rapid Fire
                    Name = "Advanced Rapid Fire",
                    RequiredUpgradeId = 478,
                },
                new SkillUpgrade
                {
                    Id = 480,
                    SkillId = 397, // Rapid Fire
                    Name = "Improved Rapid Fire",
                    RequiredUpgradeId = 478,
                },
                new SkillUpgrade
                {
                    Id = 481,
                    SkillId = 398, // Dance Of Knives
                    Name = "Enhanced Dance Of Knives",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 482,
                    SkillId = 398, // Dance Of Knives
                    Name = "Methodical Dance Of Knives",
                    RequiredUpgradeId = 481,
                },
                new SkillUpgrade
                {
                    Id = 483,
                    SkillId = 398, // Dance Of Knives
                    Name = "Disciplined Dance Of Knives",
                    RequiredUpgradeId = 481,
                },
                new SkillUpgrade
                {
                    Id = 484,
                    SkillId = 399, // Shadow Step
                    Name = "Enhanced Shadow Step",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 485,
                    SkillId = 399, // Shadow Step
                    Name = "Methodical Shadow Step",
                    RequiredUpgradeId = 484,
                },
                new SkillUpgrade
                {
                    Id = 486,
                    SkillId = 399, // Shadow Step
                    Name = "Disciplined Shadow Step",
                    RequiredUpgradeId = 484,
                },
                new SkillUpgrade
                {
                    Id = 487,
                    SkillId = 400, // Caltrops
                    Name = "Enhanced Caltrops",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 488,
                    SkillId = 400, // Caltrops
                    Name = "Methodical Caltrops",
                    RequiredUpgradeId = 487,
                },
                new SkillUpgrade
                {
                    Id = 489,
                    SkillId = 400, // Caltrops
                    Name = "Disciplined Caltrops",
                    RequiredUpgradeId = 487,
                },
                new SkillUpgrade
                {
                    Id = 490,
                    SkillId = 401, // Dash
                    Name = "Enhanced Dash",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 491,
                    SkillId = 401, // Dash
                    Name = "Methodical Dash",
                    RequiredUpgradeId = 490,
                },
                new SkillUpgrade
                {
                    Id = 492,
                    SkillId = 401, // Dash
                    Name = "Disciplined Dash",
                    RequiredUpgradeId = 490,
                },
                new SkillUpgrade
                {
                    Id = 493,
                    SkillId = 402, // Concealment
                    Name = "Enhanced Concealment",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 494,
                    SkillId = 402, // Concealment
                    Name = "Countering Concealment",
                    RequiredUpgradeId = 493,
                },
                new SkillUpgrade
                {
                    Id = 495,
                    SkillId = 402, // Concealment
                    Name = "Subvverting Concealment",
                    RequiredUpgradeId = 493,
                },
                new SkillUpgrade
                {
                    Id = 496,
                    SkillId = 403, // Dark Shroud
                    Name = "Enhanced Dark Shroud",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 497,
                    SkillId = 403, // Dark Shroud
                    Name = "Countering Dark Shroud",
                    RequiredUpgradeId = 496,
                },
                new SkillUpgrade
                {
                    Id = 498,
                    SkillId = 403, // Dark Shroud
                    Name = "Subverting Dark Shroud",
                    RequiredUpgradeId = 496,
                },
                new SkillUpgrade
                {
                    Id = 499,
                    SkillId = 404, // Poison Trap
                    Name = "Enhanced Poison Trap",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 500,
                    SkillId = 404, // Poison Trap
                    Name = "Countering Poison Trap",
                    RequiredUpgradeId = 499,
                },
                new SkillUpgrade
                {
                    Id = 501,
                    SkillId = 404, // Poison Trap
                    Name = "Subverting Poison Trap",
                    RequiredUpgradeId = 499,
                },
                new SkillUpgrade
                {
                    Id = 502,
                    SkillId = 405, // Smoke Grenade
                    Name = "Enhanced Smoke Grenade",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 503,
                    SkillId = 405, // Smoke Grenade
                    Name = "Countering Smoke Grenade",
                    RequiredUpgradeId = 502,
                },
                new SkillUpgrade
                {
                    Id = 504,
                    SkillId = 405, // Smoke Grenade
                    Name = "Subverting Smoke Grenade",
                    RequiredUpgradeId = 502,
                },
                new SkillUpgrade
                {
                    Id = 505,
                    SkillId = 406, // Cold Imbuement
                    Name = "Enhanced Cold Imbuement",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 506,
                    SkillId = 406, // Cold Imbuement
                    Name = "Blended Cold Imbuement",
                    RequiredUpgradeId = 505,
                },
                new SkillUpgrade
                {
                    Id = 507,
                    SkillId = 406, // Cold Imbuement
                    Name = "Mixed Cold Imbuement",
                    RequiredUpgradeId = 505,
                },
                new SkillUpgrade
                {
                    Id = 508,
                    SkillId = 407, // Poison Imbuement
                    Name = "Enhanced Poison Imbuement",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 509,
                    SkillId = 407, // Poison Imbuement
                    Name = "Blended Poison Imbuement",
                    RequiredUpgradeId = 508,
                },
                new SkillUpgrade
                {
                    Id = 510,
                    SkillId = 407, // Poison Imbuement
                    Name = "Mixed Poison Imbuement",
                    RequiredUpgradeId = 508,
                },
                new SkillUpgrade
                {
                    Id = 511,
                    SkillId = 408, // Shadow Imbuement
                    Name = "Enhanced Shadow Imbuement",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 512,
                    SkillId = 408, // Shadow Imbuement
                    Name = "Blended Shadow Imbuement",
                    RequiredUpgradeId = 511,
                },
                new SkillUpgrade
                {
                    Id = 513,
                    SkillId = 408, // Shadow Imbuement
                    Name = "Mixed Poison Imbuement",
                    RequiredUpgradeId = 511,
                },
                new SkillUpgrade
                {
                    Id = 514,
                    SkillId = 409, // Death Trap
                    Name = "Prime Death Trap",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 515,
                    SkillId = 409, // Death Trap
                    Name = "Surpreme Death Trap",
                    RequiredUpgradeId = 514,
                },
                new SkillUpgrade
                {
                    Id = 516,
                    SkillId = 410, // Rain Of Arrows
                    Name = "Prime Rain Of Arrows",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 517,
                    SkillId = 410, // Rain Of Arrows
                    Name = "Supreme Rain Of Arrows",
                    RequiredUpgradeId = 516,
                },
                new SkillUpgrade
                {
                    Id = 518,
                    SkillId = 411, // Shadow Clone
                    Name = "Prime Shadow Clone",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 519,
                    SkillId = 411, // Shadow Clone
                    Name = "Supreme Shadow Clone",
                    RequiredUpgradeId = 518
                }
                    );
        }
    }
}
