using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class SorcererSkillUpgradeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillUpgrade>().HasData(
                new SkillUpgrade
                {
                    Id = 587,
                    SkillId = 520, // Fire Bolt
                    Name = "Enhanced Fire Bolt",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 588,
                    SkillId = 520, // Fire Bolt
                    Name = "Flickering Fire Bolt",
                    RequiredUpgradeId = 587,
                },
                new SkillUpgrade
                {
                    Id = 589,
                    SkillId = 520, // Fire Bolt
                    Name = "Glinting Fire Bolt",
                    RequiredUpgradeId = 587,
                },
                new SkillUpgrade
                {
                    Id = 590,
                    SkillId = 521, // Frost Bolt
                    Name = "Enhanced Frost Bolt",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 591,
                    SkillId = 521, // Frost Bolt
                    Name = "Flickering Frost Bolt",
                    RequiredUpgradeId = 590,
                },
                new SkillUpgrade
                {
                    Id = 592,
                    SkillId = 521, // Frost Bolt
                    Name = "Glinting Frost Bolt",
                    RequiredUpgradeId = 590,
                },
                new SkillUpgrade
                {
                    Id = 593,
                    SkillId = 522, // Arc Lash
                    Name = "Enhanced Arc Lash",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 594,
                    SkillId = 522, // Arc Lash
                    Name = "Flickering Arc Lash",
                    RequiredUpgradeId = 593,
                },
                new SkillUpgrade
                {
                    Id = 595,
                    SkillId = 522, // Arc Lash
                    Name = "Glinting Arc Lash",
                    RequiredUpgradeId = 593,
                },
                new SkillUpgrade
                {
                    Id = 596,
                    SkillId = 523, // Spark
                    Name = "Enhanced Spark",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 597,
                    SkillId = 523, // Spark
                    Name = "Flickering Spark",
                    RequiredUpgradeId = 596,
                },
                new SkillUpgrade
                {
                    Id = 598,
                    SkillId = 523, // Spark
                    Name = "Glinting Spark",
                    RequiredUpgradeId = 596,
                },
                new SkillUpgrade
                {
                    Id = 599,
                    SkillId = 524, // Fireball
                    Name = "Enhanced Fireball",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 600,
                    SkillId = 524, // Fireball
                    Name = "Destructive Fireball",
                    RequiredUpgradeId = 599,
                },
                new SkillUpgrade
                {
                    Id = 601,
                    SkillId = 524, // Fireball
                    Name = "Greater Fireball",
                    RequiredUpgradeId = 599,
                },
                new SkillUpgrade
                {
                    Id = 602,
                    SkillId = 525, // Incinerate
                    Name = "Enhanced Incinerate",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 603,
                    SkillId = 525, // Incinerate
                    Name = "Destructive Incinerate",
                    RequiredUpgradeId = 602,
                },
                new SkillUpgrade
                {
                    Id = 604,
                    SkillId = 525, // Incinerate
                    Name = "Greater Incinerate",
                    RequiredUpgradeId = 602,
                },
                new SkillUpgrade
                {
                    Id = 605,
                    SkillId = 526, // Frozen Orb
                    Name = "Enhanced Frozen Orb",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 606,
                    SkillId = 526, // Frozen Orb
                    Name = "Destructive Frozen Orb",
                    RequiredUpgradeId = 605,
                },
                new SkillUpgrade
                {
                    Id = 607,
                    SkillId = 526, // Frozen Orb
                    Name = "Greater Frozen Orb",
                    RequiredUpgradeId = 605,
                },
                new SkillUpgrade
                {
                    Id = 608,
                    SkillId = 527, // Ice Shards
                    Name = "Enhanced Ice Shards",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 609,
                    SkillId = 527, // Ice Shards
                    Name = "Destructive Ice Shards",
                    RequiredUpgradeId = 608,
                },
                new SkillUpgrade
                {
                    Id = 610,
                    SkillId = 527, // Ice Shards
                    Name = "Greater Ice Shards",
                    RequiredUpgradeId = 608,
                },
                new SkillUpgrade
                {
                    Id = 611,
                    SkillId = 528, // Chain Lightning
                    Name = "Enhanced Chain Lightning",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 612,
                    SkillId = 528, // Chain Lightning
                    Name = "Destructive Chain Lightning",
                    RequiredUpgradeId = 611,
                },
                new SkillUpgrade
                {
                    Id = 613,
                    SkillId = 528, // Chain Lightning
                    Name = "Greater Chain Lightning",
                    RequiredUpgradeId = 611,
                },
                new SkillUpgrade
                {
                    Id = 614,
                    SkillId = 529, // Charged Bolts
                    Name = "Enhanced Charged Bolts",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 615,
                    SkillId = 529, // Charged Bolts
                    Name = "Destructive Charged Bolts",
                    RequiredUpgradeId = 614,
                },
                new SkillUpgrade
                {
                    Id = 616,
                    SkillId = 529, // Charged Bolts
                    Name = "Greater Charged Bolts",
                    RequiredUpgradeId = 614,
                },
                new SkillUpgrade
                {
                    Id = 617,
                    SkillId = 530, // Flame Shield
                    Name = "Enhanced Flame Shield",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 618,
                    SkillId = 530, // Flame Shield
                    Name = "Mystical Flame Shield",
                    RequiredUpgradeId = 617,
                },
                new SkillUpgrade
                {
                    Id = 619,
                    SkillId = 530, // Flame Shield
                    Name = "Shimmering Flame Shield",
                    RequiredUpgradeId = 617,
                },
                new SkillUpgrade
                {
                    Id = 620,
                    SkillId = 531, // Frost Nova
                    Name = "Enhanced Frost Nova",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 621,
                    SkillId = 531, // Frost Nova
                    Name = "Mystical Frost Nova",
                    RequiredUpgradeId = 620,
                },
                new SkillUpgrade
                {
                    Id = 622,
                    SkillId = 531, // Frost Nova
                    Name = "Shimmering Frost Nova",
                    RequiredUpgradeId = 620,
                },
                new SkillUpgrade
                {
                    Id = 623,
                    SkillId = 532, // Ice Armor
                    Name = "Enhanced Ice Armor",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 624,
                    SkillId = 532, // Ice Armor
                    Name = "Mystical Ice Armor",
                    RequiredUpgradeId = 623,
                },
                new SkillUpgrade
                {
                    Id = 625,
                    SkillId = 532, // Ice Armor
                    Name = "Shimmering Ice Armor",
                    RequiredUpgradeId = 623,
                },
                new SkillUpgrade
                {
                    Id = 626,
                    SkillId = 533, // Teleport
                    Name = "Enhanced Teleport",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 627,
                    SkillId = 533, // Teleport
                    Name = "Mystical Teleport",
                    RequiredUpgradeId = 626,
                },
                new SkillUpgrade
                {
                    Id = 628,
                    SkillId = 533, // Teleport
                    Name = "Shimmering Teleport",
                    RequiredUpgradeId = 626,
                },
                new SkillUpgrade
                {
                    Id = 629,
                    SkillId = 534, // Familiar
                    Name = "Enhanced Familiar",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 630,
                    SkillId = 534, // Familiar
                    Name = "Roaring Familiar",
                    RequiredUpgradeId = 629,
                },
                new SkillUpgrade
                {
                    Id = 631,
                    SkillId = 534, // Familiar
                    Name = "Invoked Familar",
                    RequiredUpgradeId = 629,
                },
                new SkillUpgrade
                {
                    Id = 632,
                    SkillId = 535, // Hydra
                    Name = "Enhanced Hydra",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 633,
                    SkillId = 535, // Hydra
                    Name = "Roaring Hydra",
                    RequiredUpgradeId = 632,
                },
                new SkillUpgrade
                {
                    Id = 634,
                    SkillId = 535, // Hydra
                    Name = "Invoked Hydra",
                    RequiredUpgradeId = 632,
                },
                new SkillUpgrade
                {
                    Id = 635,
                    SkillId = 536, // Ice Blades
                    Name = "Enhanced Ice Blades",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 636,
                    SkillId = 536, // Ice Blades
                    Name = "Roaring Ice Blades",
                    RequiredUpgradeId = 635,
                },
                new SkillUpgrade
                {
                    Id = 637,
                    SkillId = 536, // Ice Blades
                    Name = "Invoked Ice Blades",
                    RequiredUpgradeId = 635,
                },
                new SkillUpgrade
                {
                    Id = 638,
                    SkillId = 537, // Lightning Spear
                    Name = "Enhanced Lightning Spear",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 639,
                    SkillId = 537, // Lightning Spear
                    Name = "Roaring Lightning Spear",
                    RequiredUpgradeId = 638,
                },
                new SkillUpgrade
                {
                    Id = 640,
                    SkillId = 537, // Lightning Spear
                    Name = "Invoke Lightning Spear",
                    RequiredUpgradeId = 638,
                },
                new SkillUpgrade
                {
                    Id = 641,
                    SkillId = 538, // Firewall
                    Name = "Enhanced Firewall",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 642,
                    SkillId = 538, // Firewall
                    Name = "Mage's Firewall",
                    RequiredUpgradeId = 641,
                },
                new SkillUpgrade
                {
                    Id = 643,
                    SkillId = 538, // Firewall
                    Name = "Wizard's Firewall",
                    RequiredUpgradeId = 641,
                },
                new SkillUpgrade
                {
                    Id = 644,
                    SkillId = 539, // Meteor
                    Name = "Enhanced Meteor",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 645,
                    SkillId = 539, // Meteor
                    Name = "Mage's Meteor",
                    RequiredUpgradeId = 644,
                },
                new SkillUpgrade
                {
                    Id = 646,
                    SkillId = 539, // Meteor
                    Name = "Wizard's Meteor",
                    RequiredUpgradeId = 644,
                },
                new SkillUpgrade
                {
                    Id = 647,
                    SkillId = 540, // Blizzard
                    Name = "Enhanced Blizzard",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 648,
                    SkillId = 540, // Blizzard
                    Name = "Mage's Blizzard",
                    RequiredUpgradeId = 647,
                },
                new SkillUpgrade
                {
                    Id = 649,
                    SkillId = 540, // Blizzard
                    Name = "Wizard's Blizzard",
                    RequiredUpgradeId = 647,
                },
                new SkillUpgrade
                {
                    Id = 650,
                    SkillId = 541, // Ball Lightning
                    Name = "Enhanced Ball Lightning",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 651,
                    SkillId = 541, // Ball Lightning
                    Name = "Mage's Ball Lightning",
                    RequiredUpgradeId = 650,
                },
                new SkillUpgrade
                {
                    Id = 652,
                    SkillId = 541, // Ball Lightning
                    Name = "Wizard's Ball Lightning",
                    RequiredUpgradeId = 650,
                },
                new SkillUpgrade
                {
                    Id = 653,
                    SkillId = 542, // Inferno
                    Name = "Prime Inferno",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 654,
                    SkillId = 542, // Inferno
                    Name = "Supreme Inferno",
                    RequiredUpgradeId = 653,
                },
                new SkillUpgrade
                {
                    Id = 655,
                    SkillId = 543, // Deep Freeze
                    Name = "Prime Deep Freeze",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 656,
                    SkillId = 543, // Deep Freeze
                    Name = "Supreme Deep Freeze",
                    RequiredUpgradeId = 655,
                },
                new SkillUpgrade
                {
                    Id = 657,
                    SkillId = 544, // Unstable Currents
                    Name = "Prime Unstable Currents",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 658,
                    SkillId = 544, // Unstable Currents
                    Name = "Supreme Unstable Currents",
                    RequiredUpgradeId = 657,
                }
                    );
        }
    }
}