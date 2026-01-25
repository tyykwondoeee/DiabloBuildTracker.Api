using DiabloBuildTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Api.Data.Seed
{
    public static class DruidSkillUpgradeSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillUpgrade>().HasData(
                new SkillUpgrade
                {
                    Id = 201,
                    SkillId = 134, // Maul
                    Name = "Enhanced Maul",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 202,
                    SkillId = 134, // Maul
                    Name = "Fierce Maul",
                    RequiredUpgradeId = 201,
                },
                new SkillUpgrade
                {
                    Id = 203,
                    SkillId = 134, // Maul
                    Name = "Wild Maul",
                    RequiredUpgradeId = 201,
                },
                new SkillUpgrade
                {
                    Id = 204,
                    SkillId = 135, // Claw
                    Name = "Enhanced Claw",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 205,
                    SkillId = 135, // Claw
                    Name = "Fierce Claw",
                    RequiredUpgradeId = 204,
                },
                new SkillUpgrade
                {
                    Id = 206,
                    SkillId = 135, // Claw
                    Name = "Wild Claw",
                    RequiredUpgradeId = 204,
                },
                new SkillUpgrade
                {
                    Id = 207,
                    SkillId = 136, // Storm Strike
                    Name = "Enhanced Storm Strike",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 208,
                    SkillId = 136, // Storm Strike
                    Name = "Fierce Storm Strike",
                    RequiredUpgradeId = 207,
                },
                new SkillUpgrade
                {
                    Id = 209,
                    SkillId = 136, // Storm Strike
                    Name = "Wild Storm Strike",
                    RequiredUpgradeId = 207,
                },
                new SkillUpgrade
                {
                    Id = 210,
                    SkillId = 137, // Wind Shear
                    Name = "Enhanced Wind Shear",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 211,
                    SkillId = 137, // Wind Shear
                    Name = "Fierce Wind Shear",
                    RequiredUpgradeId = 210,
                },
                new SkillUpgrade
                {
                    Id = 212,
                    SkillId = 137, // Wind Shear
                    Name = "Wild Wind Shear",
                    RequiredUpgradeId = 210,
                },
                new SkillUpgrade
                {
                    Id = 213,
                    SkillId = 138, // Earth Spike
                    Name = "Enhanced Earth Spike",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 214,
                    SkillId = 138, // Earth Spike
                    Name = "Wild Earth Spike",
                    RequiredUpgradeId = 213,
                },
                new SkillUpgrade
                {
                    Id = 215,
                    SkillId = 138, // Earth Spike
                    Name = "Fierce Earth Spike",
                    RequiredUpgradeId = 213,
                },
                new SkillUpgrade
                {
                    Id = 216,
                    SkillId = 139, // Lightning Storm
                    Name = "Enhanced Lightning Storm",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 217,
                    SkillId = 139, // Lightning Storm
                    Name = "Raging Lightning Storm",
                    RequiredUpgradeId = 216,
                },
                new SkillUpgrade
                {
                    Id = 218,
                    SkillId = 139, // Lightning Storm
                    Name = "Primal Lightning Storm",
                    RequiredUpgradeId = 216,
                },
                new SkillUpgrade
                {
                    Id = 219,
                    SkillId = 140, // Tornado
                    Name = "Enhanced Tornado",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 220,
                    SkillId = 140, // Tornado
                    Name = "Primal Tornando",
                    RequiredUpgradeId = 219,
                },
                new SkillUpgrade
                {
                    Id = 221,
                    SkillId = 140, // Tornado
                    Name = "Raging Tornado",
                    RequiredUpgradeId = 219,
                },
                new SkillUpgrade
                {
                    Id = 222,
                    SkillId = 141, // Pulverize
                    Name = "Enhanced Pulverize",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 223,
                    SkillId = 141, // Pulverize
                    Name = "Primal Pulverize",
                    RequiredUpgradeId = 222,
                },
                new SkillUpgrade
                {
                    Id = 224,
                    SkillId = 141, // Pulverize
                    Name = "Raging Pulverize",
                    RequiredUpgradeId = 222,
                },
                new SkillUpgrade
                {
                    Id = 225,
                    SkillId = 142, // Shred
                    Name = "Enhanced Shred",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 226,
                    SkillId = 142, // Shred
                    Name = "Primal Shred",
                    RequiredUpgradeId = 225,
                },
                new SkillUpgrade
                {
                    Id = 227,
                    SkillId = 142, // Shred
                    Name = "Raging Shred",
                    RequiredUpgradeId = 225,
                },
                new SkillUpgrade
                {
                    Id = 228,
                    SkillId = 143, // Landslide
                    Name = "Enhanced Landslide",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 229,
                    SkillId = 143, // Landslide
                    Name = "Primal Landslide",
                    RequiredUpgradeId = 228,
                },
                new SkillUpgrade
                {
                    Id = 230,
                    SkillId = 143, // Landslide
                    Name = "Raging Landslide",
                    RequiredUpgradeId = 228,
                },
                new SkillUpgrade
                {
                    Id = 231,
                    SkillId = 144, // Earthen Bulwark
                    Name = "Enhanced Earthen Bulwark",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 232,
                    SkillId = 144, // Earthen Bulwark
                    Name = "Innate Earthen Bulwark",
                    RequiredUpgradeId = 231,
                },
                new SkillUpgrade
                {
                    Id = 233,
                    SkillId = 144, // Earthen Bulwark
                    Name = "Preserving Earthen Bulwark",
                    RequiredUpgradeId = 232,
                },
                new SkillUpgrade
                {
                    Id = 234,
                    SkillId = 145, // Cyclone Armor
                    Name = "Enhanced Cyclone Armor",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 235,
                    SkillId = 145, // Cyclone Armor
                    Name = "Innate Cyclone Armor",
                    RequiredUpgradeId = 234,
                },
                new SkillUpgrade
                {
                    Id = 236,
                    SkillId = 145, // Cyclone Armor
                    Name = "Preserving Cyclone Armor",
                    RequiredUpgradeId = 234,
                },
                new SkillUpgrade
                {
                    Id = 237,
                    SkillId = 146, // Blood Howl
                    Name = "Enhanced Blood Howl",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 238,
                    SkillId = 146, // Blood Howl
                    Name = "Innate Blood Howl",
                    RequiredUpgradeId = 237,
                },
                new SkillUpgrade
                {
                    Id = 239,
                    SkillId = 146, // Blood Howl
                    Name = "Preserving Blood Howl",
                    RequiredUpgradeId = 237,
                },
                new SkillUpgrade
                {
                    Id = 240,
                    SkillId = 147, // Delibilitating Roar
                    Name = "Enhanced Debilitating Roar",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 241,
                    SkillId = 147, // Delibitating Roar
                    Name = "Innate Beblitating Roar",
                    RequiredUpgradeId = 240,
                },
                new SkillUpgrade
                {
                    Id = 242,
                    SkillId = 147, // Deblitating Roar
                    Name = "Preserving Deblitating Roar",
                    RequiredUpgradeId = 240,
                },
                new SkillUpgrade
                {
                    Id = 243,
                    SkillId = 148, // Wolves
                    Name = "Enhanced Wolf Pack",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 244,
                    SkillId = 148, // Wolves
                    Name = "Brustal Wolf Pack",
                    RequiredUpgradeId = 243,
                },
                new SkillUpgrade
                {
                    Id = 245,
                    SkillId = 148, // Wolves
                    Name = "Ferocious Wolf Pack",
                    RequiredUpgradeId = 243,
                },
                new SkillUpgrade
                {
                    Id = 246,
                    SkillId = 149, // Ravens
                    Name = "Enhanced Ravens",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 247,
                    SkillId = 149, // Ravens
                    Name = "Brutal Ravens",
                    RequiredUpgradeId = 246,
                },
                new SkillUpgrade
                {
                    Id = 248,
                    SkillId = 149, // Ravens
                    Name = "Ferocious Ravens",
                    RequiredUpgradeId = 246,
                },
                new SkillUpgrade
                {
                    Id = 249,
                    SkillId = 150, // Poison Creeper
                    Name = "Enhanced Poison Creeper",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 250,
                    SkillId = 150, // Poison Creeper
                    Name = "Ferocious Poison Creeper",
                    RequiredUpgradeId = 249,
                },
                new SkillUpgrade
                {
                    Id = 251,
                    SkillId = 150, // Poison Creeper
                    Name = "Brutal Poison Creeper",
                    RequiredUpgradeId = 249,
                },
                new SkillUpgrade
                {
                    Id = 252,
                    SkillId = 151, // Boulder
                    Name = "Enhanced Boulder",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 253,
                    SkillId = 151, // Boulder
                    Name = "Natural Boulder",
                    RequiredUpgradeId = 252,
                },
                new SkillUpgrade
                {
                    Id = 254,
                    SkillId = 151, // Boulder
                    Name = "Savage Boulder",
                    RequiredUpgradeId = 252,
                },
                new SkillUpgrade
                {
                    Id = 255,
                    SkillId = 152, // Trample
                    Name = "Enhanced Trample",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 256,
                    SkillId = 152, // Tample
                    Name = "Natural Trample",
                    RequiredUpgradeId = 255,
                },
                new SkillUpgrade
                {
                    Id = 257,
                    SkillId = 152, // Trample
                    Name = "Savage Trample",
                    RequiredUpgradeId = 255,
                },
                new SkillUpgrade
                {
                    Id = 258,
                    SkillId = 153, // Hurricane
                    Name = "Enhanced Hurricane",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 259,
                    SkillId = 153, // Hurricane
                    Name = "Natural Hurricane",
                    RequiredUpgradeId = 258,
                },
                new SkillUpgrade
                {
                    Id = 260,
                    SkillId = 153, // Hurricane
                    Name = "Savage Hurricane",
                    RequiredUpgradeId = 258,
                },
                new SkillUpgrade
                {
                    Id = 261,
                    SkillId = 154, // Rabies
                    Name = "Enhanced Rabies",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 262,
                    SkillId = 154, // Rabies
                    Name = "Natural Rabies",
                    RequiredUpgradeId = 261,
                },
                new SkillUpgrade
                {
                    Id = 263,
                    SkillId = 154, // Rabies
                    Name = "Savage Rabies",
                    RequiredUpgradeId = 261,
                },
                new SkillUpgrade
                {
                    Id = 264,
                    SkillId = 155, // Grizzly Rage
                    Name = "Prime Grizzly rage",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 265,
                    SkillId = 155, // Grizzly Rage
                    Name = "Supreme Grizzly Rage",
                    RequiredUpgradeId = 264,
                },
                new SkillUpgrade
                {
                    Id = 266,
                    SkillId = 156, // Petrify
                    Name = "Prime Petrify",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 267,
                    SkillId = 156, // Petrify
                    Name = "Supreme Petrify",
                    RequiredUpgradeId = 266,
                },
                new SkillUpgrade
                {
                    Id = 268,
                    SkillId = 157, // Lacerate
                    Name = "Prime Lacerate",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 269,
                    SkillId = 157, // Lacerate
                    Name = "Supreme Lacerate",
                    RequiredUpgradeId = 268,
                },
                new SkillUpgrade
                {
                    Id = 270,
                    SkillId = 158, // Cataclysm
                    Name = "Prime Cataclysm",
                    RequiredUpgradeId = null,
                },
                new SkillUpgrade
                {
                    Id = 271,
                    SkillId = 158, // Cataclysm
                    Name = "Supreme Cataclysm",
                    RequiredUpgradeId = 270,
                }
                    );
        }
    }
}
