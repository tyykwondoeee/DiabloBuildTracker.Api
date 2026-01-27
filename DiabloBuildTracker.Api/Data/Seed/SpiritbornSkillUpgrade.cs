using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SpiritbornSkillUpgradeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillUpgrade>().HasData(
                new SkillUpgrade
                {
                    Id = 717,
                    SkillId = 659, // Rock Splitter
                    Name = "Enhanced Fire Bolt",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 718,
                    SkillId = 659, // Rock Splitter
                    Name = "Accelerated Rock Splitter",
                    RequiredUpgradeId = 717,
                },
                new SkillUpgrade
                {
                    Id = 719,
                    SkillId = 659, // Rock Splitter
                    Name = "Sharp Rock Splitter",
                    RequiredUpgradeId = 717,
                },
                new SkillUpgrade
                {
                    Id = 720,
                    SkillId = 660, // Thunderspike
                    Name = "Enhanced Thunderspike",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 721,
                    SkillId = 660, // Thunderspike
                    Name = "Accelerated Thunderspike",
                    RequiredUpgradeId = 720,
                },
                new SkillUpgrade
                {
                    Id = 722,
                    SkillId = 660, // Thunderspike
                    Name = "Sharp Thunderspike",
                    RequiredUpgradeId = 720,
                },
                new SkillUpgrade
                {
                    Id = 723,
                    SkillId = 661, // Thrash
                    Name = "Enhanced Thrash",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 724,
                    SkillId = 661, // Thrash
                    Name = "Accelerated Thrash",
                    RequiredUpgradeId = 723,
                },
                new SkillUpgrade
                {
                    Id = 725,
                    SkillId = 661, // Thrash
                    Name = "Sharp Thrash",
                    RequiredUpgradeId = 723,
                },
                new SkillUpgrade
                {
                    Id = 726,
                    SkillId = 662, // Withering Fist
                    Name = "Enhanced Withering Fist",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 727,
                    SkillId = 662, // Withering Fist
                    Name = "Accelerated Withering Fist",
                    RequiredUpgradeId = 726,
                },
                new SkillUpgrade
                {
                    Id = 728,
                    SkillId = 662, // Withering Fist
                    Name = "Sharp Withering Fist",
                    RequiredUpgradeId = 726,
                },
                new SkillUpgrade
                {
                    Id = 729,
                    SkillId = 663, // Crushing Hand
                    Name = "Enhanced Crushing Hand",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 730,
                    SkillId = 663, // Crushing Hand
                    Name = "Rampant Crushing Hand",
                    RequiredUpgradeId = 729,
                },
                new SkillUpgrade
                {
                    Id = 731,
                    SkillId = 663, // Crushing Hand
                    Name = "Advantageous Crushing Hand",
                    RequiredUpgradeId = 729,
                },
                new SkillUpgrade
                {
                    Id = 732,
                    SkillId = 664, // Quill Volley
                    Name = "Enhanced Quill Volley",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 733,
                    SkillId = 664, // Quill Volley
                    Name = "Rampant Quill Volley",
                    RequiredUpgradeId = 732,
                },
                new SkillUpgrade
                {
                    Id = 734,
                    SkillId = 664, // Quill Volley
                    Name = "Advantageous Quill Volley",
                    RequiredUpgradeId = 732,
                },
                new SkillUpgrade
                {
                    Id = 735,
                    SkillId = 665, // Rake
                    Name = "Enhanced Rake",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 736,
                    SkillId = 665, // Rake
                    Name = "Rampant Rake",
                    RequiredUpgradeId = 735,
                },
                new SkillUpgrade
                {
                    Id = 737,
                    SkillId = 665, // Rake
                    Name = "Advantageous Rake",
                    RequiredUpgradeId = 735,
                },
                new SkillUpgrade
                {
                    Id = 738,
                    SkillId = 666, // Stinger
                    Name = "Enhanced Stinger",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 739,
                    SkillId = 666, // Stinger
                    Name = "Rampant Stinger",
                    RequiredUpgradeId = 738,
                },
                new SkillUpgrade
                {
                    Id = 740,
                    SkillId = 666, // Stinger
                    Name = "Advantageous Stinger",
                    RequiredUpgradeId = 738,
                },
                new SkillUpgrade
                {
                    Id = 741,
                    SkillId = 667, // Vortex
                    Name = "Enhanced Vortex",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 742,
                    SkillId = 667, // Vortex
                    Name = "Replenishing Vortex",
                    RequiredUpgradeId = 741,
                },
                new SkillUpgrade
                {
                    Id = 743,
                    SkillId = 667, // Vortex
                    Name = "Measured Vortex",
                    RequiredUpgradeId = 741,
                },
                new SkillUpgrade
                {
                    Id = 744,
                    SkillId = 668, // Soar
                    Name = "Enhanced Soar",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 745,
                    SkillId = 668, // Soar
                    Name = "Replenishing Soar",
                    RequiredUpgradeId = 744,
                },
                new SkillUpgrade
                {
                    Id = 746,
                    SkillId = 668, // Soar
                    Name = "Measured Soar",
                    RequiredUpgradeId = 744,
                },
                new SkillUpgrade
                {
                    Id = 747,
                    SkillId = 669, // Ravager
                    Name = "Enhanced Raveager",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 748,
                    SkillId = 669, // Ravager
                    Name = "Replenishing Ravager",
                    RequiredUpgradeId = 747,
                },
                new SkillUpgrade
                {
                    Id = 749,
                    SkillId = 669, // Ravager
                    Name = "Measured Ravager",
                    RequiredUpgradeId = 747,
                },
                new SkillUpgrade
                {
                    Id = 750,
                    SkillId = 670, // Toxic Skin
                    Name = "Enhanced Toxic Skin",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 751,
                    SkillId = 670, // Toxic Skin
                    Name = "Replenishing Toxic Skin",
                    RequiredUpgradeId = 750,
                },
                new SkillUpgrade
                {
                    Id = 752,
                    SkillId = 670, // Toxic Skin
                    Name = "Measured Toxic Skin",
                    RequiredUpgradeId = 750,
                },
                new SkillUpgrade
                {
                    Id = 753,
                    SkillId = 671, // Armored Hide
                    Name = "Enhanced Armored Hide",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 754,
                    SkillId = 671, // Armored Hide
                    Name = "Adaptable Armor Hide",
                    RequiredUpgradeId = 753,
                },
                new SkillUpgrade
                {
                    Id = 755,
                    SkillId = 671, // Armored Hide
                    Name = "Reinforced Armored Hide",
                    RequiredUpgradeId = 753,
                },
                new SkillUpgrade
                {
                    Id = 756,
                    SkillId = 672, // Concussive Stomp
                    Name = "Enhanced Concussive Stomp",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 757,
                    SkillId = 672, // Concussive Stomp
                    Name = "Adaptable Concussive Stomp",
                    RequiredUpgradeId = 756,
                },
                new SkillUpgrade
                {
                    Id = 758,
                    SkillId = 672, // Concussive Stomp
                    Name = "Reinforced Concussive Stomp",
                    RequiredUpgradeId = 756,
                },
                new SkillUpgrade
                {
                    Id = 759,
                    SkillId = 673, // Counterattack
                    Name = "Enhanced Counterattack",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 760,
                    SkillId = 674, // Scourge
                    Name = "Adaptable Scourge",
                    RequiredUpgradeId = 759,
                },
                new SkillUpgrade
                {
                    Id = 761,
                    SkillId = 674, // Scourge
                    Name = "Reinforced Scourge",
                    RequiredUpgradeId = 759,
                },
                new SkillUpgrade
                {
                    Id = 762,
                    SkillId = 675, // Payback
                    Name = "Enhanced Payback",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 763,
                    SkillId = 675, // Payback
                    Name = "Poised Payback",
                    RequiredUpgradeId = 762,
                },
                new SkillUpgrade
                {
                    Id = 764,
                    SkillId = 675, // Payback
                    Name = "Invasive Payback",
                    RequiredUpgradeId = 762,
                },
                new SkillUpgrade
                {
                    Id = 765,
                    SkillId = 676, // Razor Wings
                    Name = "Enhanced Razor Wings",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 766,
                    SkillId = 676, // Razor Wings
                    Name = "Poised Razor Wings",
                    RequiredUpgradeId = 765,
                },
                new SkillUpgrade
                {
                    Id = 767,
                    SkillId = 676, // Razor Wings
                    Name = "Invasive Razor Wings",
                    RequiredUpgradeId = 765,
                },
                new SkillUpgrade
                {
                    Id = 768,
                    SkillId = 677, // Rushing Claw
                    Name = "Enhanced Rushing Claw",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 769,
                    SkillId = 677, // Rushing Claw
                    Name = "Poised Rushing Claw",
                    RequiredUpgradeId = 768,
                },
                new SkillUpgrade
                {
                    Id = 770,
                    SkillId = 677, // Rushing Claw
                    Name = "Invasive Rushing Claw",
                    RequiredUpgradeId = 768,
                },
                new SkillUpgrade
                {
                    Id = 771,
                    SkillId = 678, // Touch Of Death
                    Name = "Enhanced Touch Of Death",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 772,
                    SkillId = 678, // Touch Of Death
                    Name = "Poised Touch Of Death",
                    RequiredUpgradeId = 771,
                },
                new SkillUpgrade
                {
                    Id = 773,
                    SkillId = 678, // Touch Of Death
                    Name = "Invasive Touch Of Death",
                    RequiredUpgradeId = 771,
                },
                new SkillUpgrade
                {
                    Id = 774,
                    SkillId = 679, // The Protector 
                    Name = "Harmonious Protector",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 775,
                    SkillId = 679, // The Protector
                    Name = "Exalted Protector",
                    RequiredUpgradeId = 774,
                },
                new SkillUpgrade
                {
                    Id = 776,
                    SkillId = 680, // The Seeker
                    Name = "Harmonious Seeker",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 777,
                    SkillId = 680, // The Seeker
                    Name = "Exalted Seeker",
                    RequiredUpgradeId = 776,
                },
                new SkillUpgrade
                {
                    Id = 778,
                    SkillId = 681, // The Hunter
                    Name = "Harmonious Hunter",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 779,
                    SkillId = 681, // The Hunter
                    Name = "Exalted Hunter",
                    RequiredUpgradeId = 778,
                },
                new SkillUpgrade
                {
                    Id = 780,
                    SkillId = 682, // The Devourer
                    Name = "Harmonious Devourer",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 781,
                    SkillId = 682, // The Devourer
                    Name = "Exalted Devourer",
                    RequiredUpgradeId = 780,
                }
                    );
        }
    }
}