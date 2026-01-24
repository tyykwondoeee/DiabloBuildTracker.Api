using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class BarbarianSkillUpgradeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillUpgrade>().HasData(
                new SkillUpgrade
                {
                    Id = 65,
                    SkillId = 1, // Bash
                    Name = "Enhanced Bash",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 66,
                    SkillId = 1, // Bash
                    Name = "Battle Bash",
                    RequiredUpgradeId = 65,
                },
                new SkillUpgrade
                {
                    Id = 67,
                    SkillId = 1, // Bash
                    Name = "Combat Bash",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 68,
                    SkillId = 2, // Lunging Strike
                    Name = "Enhanced Lunging Strike",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 69,
                    SkillId = 2, // Lunging Strike
                    Name = "Battle Lunging Strike",
                    RequiredUpgradeId = 68,
                },
                new SkillUpgrade
                {
                    Id = 70,
                    SkillId = 2, // Lunging Strike
                    Name = "Combat Lunging Strike",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 71,
                    SkillId = 3, // Frenzy
                    Name = "Enhanced Frenzy",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 72,
                    SkillId = 3, // Frenzy
                    Name = "Battle Frenzy",
                    RequiredUpgradeId = 71,
                },
                new SkillUpgrade
                {
                    Id = 73,
                    SkillId = 3, // Frenzy
                    Name = "Combat Frenzy",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 74,
                    SkillId = 4, // Flay
                    Name = "Enhanced Flay",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 75,
                    SkillId = 4, // Flay
                    Name = "Battle Flay",
                    RequiredUpgradeId = 74,
                },
                new SkillUpgrade
                {
                    Id = 76,
                    SkillId = 4, // Flay
                    Name = "Combat Flay",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 77,
                    SkillId = 5, // Whirlwind
                    Name = "Enhanced Whirlwind",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 78,
                    SkillId = 5, // Whirlwind
                    Name = "Furious Whirlwind",
                    RequiredUpgradeId = 77,
                },
                new SkillUpgrade
                {
                    Id = 79,
                    SkillId = 5, // Whirlwind
                    Name = "Violent Whirlwind",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 80,
                    SkillId = 6, // Hammer of the Ancients
                    Name = "Enhanced Hammer Of The Ancients",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 81,
                    SkillId = 6, // Hammer of the Ancients
                    Name = "Furious Hammer Of The Ancients",
                    RequiredUpgradeId = 80,
                },
                new SkillUpgrade
                {
                    Id = 82,
                    SkillId = 6, // Hammer of the Ancients
                    Name = "Violent Hammer Of The Ancients",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 83,
                    SkillId = 7, // Upheaval
                    Name = "Enhanced Upheaval",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 84,
                    SkillId = 7, // Upheaval
                    Name = "Furious Upheaval",
                    RequiredUpgradeId = 83,
                },
                new SkillUpgrade
                {
                    Id = 85,
                    SkillId = 7, // Upheaval
                    Name = "Violent Upheaval",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 86,
                    SkillId = 8, // Double Swing
                    Name = "Enhanced Double Swing",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 87,
                    SkillId = 8, // Double Swing
                    Name = "Furious Double Swing",
                    RequiredUpgradeId = 86,
                },
                new SkillUpgrade
                {
                    Id = 88,
                    SkillId = 8, // Double Swing
                    Name = "Violent Double Swing",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 89,
                    SkillId = 9, // Rend
                    Name = "Enhanced Rend",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 90,
                    SkillId = 9, // Rend
                    Name = "Furious Rend",
                    RequiredUpgradeId = 89,
                },
                new SkillUpgrade
                {
                    Id = 91,
                    SkillId = 9, // Rend
                    Name = "Violent Rend",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 92,
                    SkillId = 10, // Double Stomp
                    Name = "Enhanced Double Stomp",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 93,
                    SkillId = 10, // Double Stomp
                    Name = "Strategic Double Stomp",
                    RequiredUpgradeId = 92,
                },
                new SkillUpgrade
                {
                    Id = 94,
                    SkillId = 10, // Double Stomp
                    Name = "Tactical Double Stomp",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 95,
                    SkillId = 11, // Rallying Cry
                    Name = "Enhanced Rallying Cry",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 96,
                    SkillId = 11, // Rallying Cry
                    Name = "Strategic Rallying Cry",
                    RequiredUpgradeId = 95,
                },
                new SkillUpgrade
                {
                    Id = 97,
                    SkillId = 11, // Rallying Cry
                    Name = "Tactical Rallying Cry",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 98,
                    SkillId = 12, // Iron Skin
                    Name = "Enhanced Iron Skin",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 99,
                    SkillId = 12, // Iron Skin
                    Name = "Strategic Iron Skin",
                    RequiredUpgradeId = 98,
                },
                new SkillUpgrade
                {
                    Id = 100,
                    SkillId = 12, // Iron Skin
                    Name = "Tactical Iron Skin",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 101,
                    SkillId = 13, // Challenging Shout
                    Name = "Enhanced Challenging Shout",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 102,
                    SkillId = 13, // Challenging Shout
                    Name = "Strategic Challenging Shout",
                    RequiredUpgradeId = 101,
                },
                new SkillUpgrade
                {
                    Id = 103,
                    SkillId = 13, // Challenging Shout
                    Name = "Tactical Challenging Shout",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 104,
                    SkillId = 14, // Kick
                    Name = "Enhanced Kick",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 105,
                    SkillId = 14, // Kick
                    Name = "Mighty Kick",
                    RequiredUpgradeId = 104,
                },
                new SkillUpgrade
                {
                    Id = 106,
                    SkillId = 14, // Kick
                    Name = "Power Kick",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 107,
                    SkillId = 15, // War Cry
                    Name = "Enhanced War Cry",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 108,
                    SkillId = 15, // War Cry
                    Name = "Mighty War Cry",
                    RequiredUpgradeId = 107,
                },
                new SkillUpgrade
                {
                    Id = 109,
                    SkillId = 15, // War Cry
                    Name = "Power War Cry",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 110,
                    SkillId = 16, // Charge
                    Name = "Enhanced Charge",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 111,
                    SkillId = 16, // Charge
                    Name = "Mighty Charge",
                    RequiredUpgradeId = 110,
                },
                new SkillUpgrade
                {
                    Id = 112,
                    SkillId = 16, // Charge
                    Name = "Power Charge",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 113,
                    SkillId = 17, // Leap
                    Name = "Enhanced Leap",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 114,
                    SkillId = 17, // Leap
                    Name = "Mighty Leap",
                    RequiredUpgradeId = 113,
                },
                new SkillUpgrade
                {
                    Id = 115,
                    SkillId = 17, // Leap
                    Name = "Power Leap",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 116,
                    SkillId = 18, // Rupture
                    Name = "Enhanced Rupture",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 117,
                    SkillId = 18, // Rupture
                    Name = "Fighter's Rupture",
                    RequiredUpgradeId = 116,
                },
                new SkillUpgrade
                {
                    Id = 118,
                    SkillId = 18, // Rupture
                    Name = "Warrior's Rupture",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 119,
                    SkillId = 19, // Steel Grasp
                    Name = "Enhanced Steel Grasp",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 120,
                    SkillId = 19, // Steel Grasp
                    Name = "Fighter's Steel Grasp",
                    RequiredUpgradeId = 119,
                },
                new SkillUpgrade
                {
                    Id = 121,
                    SkillId = 19, // Steel Grasp
                    Name = "Warrior's Steel Grasp",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 122,
                    SkillId = 20, // Death Blow
                    Name = "Enhanced Death Blow",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 123,
                    SkillId = 20, // Death Blow
                    Name = "Fighter's Death Blow",
                    RequiredUpgradeId = 122,
                },
                new SkillUpgrade
                {
                    Id = 124,
                    SkillId = 20, // Death Blow
                    Name = "Warrior's Death Blow",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 125,
                    SkillId = 21, // Mighty Blow
                    Name = "Enhanced Mighty Blow",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 126,
                    SkillId = 21, // Mighty Blow
                    Name = "Fighter's Mighty Blow",
                    RequiredUpgradeId = 125,
                },
                new SkillUpgrade
                {
                    Id = 127,
                    SkillId = 21, // Mighty Blow
                    Name = "Warrior's Mighty Blow",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 128,
                    SkillId = 22, // Call Of The Ancients
                    Name = "Prime Call Of The Ancients",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 129,
                    SkillId = 22, // Call Of The Ancients
                    Name = "Surpreme Call Of The Ancients",
                    RequiredUpgradeId = 128,
                },
                new SkillUpgrade
                {
                    Id = 130,
                    SkillId = 23, // Iron Maelstrom
                    Name = "Prime Iron Maelstrom",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 131,
                    SkillId = 23, // Iron Maelstrom
                    Name = "Supreme Iron Maelstrom",
                    RequiredUpgradeId = 130,
                },
                new SkillUpgrade
                {
                    Id = 132,
                    SkillId = 24, // Wrath Of The Berserker
                    Name = "Prime Wrath of The Berserker",
                    RequiredUpgradeId = 0,
                },
                new SkillUpgrade
                {
                    Id = 133,
                    SkillId = 24, // Wrath Of The Berserker
                    Name = "Supreme Wrath of The Berserker",
                    RequiredUpgradeId = 132
                }
                    );
                }
        }
    }
