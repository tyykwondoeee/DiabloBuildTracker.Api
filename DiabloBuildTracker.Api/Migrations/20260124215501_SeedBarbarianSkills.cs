using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiabloBuildTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedBarbarianSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillCategoryId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillType",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SkillCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillUpgrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredUpgradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillUpgrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillUpgrades_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Barbarian" },
                    { 2, "Druid" },
                    { 3, "Necromancer" },
                    { 4, "Rouge" },
                    { 5, "Sorcerer" },
                    { 6, "Sprirtborn" },
                    { 7, "Paladin" }
                });

            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Basic" },
                    { 2, "Core" },
                    { 3, "Defensive" },
                    { 4, "Passive" },
                    { 5, "Brawling" },
                    { 6, "Weapon Mastery" },
                    { 7, "Upgrades" },
                    { 8, "Ultimate" },
                    { 9, "Key Passive" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 1, 1, 5, "Bash", 1, 1 },
                    { 2, 1, 5, "Lunging Strike", 1, 1 },
                    { 3, 1, 5, "Frenzy", 1, 1 },
                    { 4, 1, 5, "Flay", 1, 1 },
                    { 5, 1, 5, "Whirlwind", 2, 1 },
                    { 6, 1, 5, "Hammer of the Ancients", 2, 1 },
                    { 7, 1, 5, "Upheaval", 2, 1 },
                    { 8, 1, 5, "Double Swing", 2, 1 },
                    { 9, 1, 5, "Rend", 2, 1 },
                    { 10, 1, 5, "Ground Stomp", 3, 1 },
                    { 11, 1, 5, "Rallying Cry", 3, 1 },
                    { 12, 1, 5, "Iron Skin", 3, 1 },
                    { 13, 1, 5, "Challenging Shout", 3, 1 },
                    { 14, 1, 5, "Kick", 5, 1 },
                    { 15, 1, 5, "War Cry", 5, 1 },
                    { 16, 1, 5, "Charge", 5, 1 },
                    { 17, 1, 5, "Leap", 5, 1 },
                    { 18, 1, 5, "Rupture", 6, 1 },
                    { 19, 1, 5, "Steel Grasp", 6, 1 },
                    { 20, 1, 5, "Death Blow", 6, 1 },
                    { 21, 1, 5, "Mighty Throw", 6, 1 },
                    { 22, 1, 5, "Call Of The Ancients", 8, 1 },
                    { 23, 1, 5, "Iron Maelstrom", 8, 1 },
                    { 24, 1, 5, "Wrath Of The Berserker", 8, 1 },
                    { 25, 1, 3, "Pressure Point", 4, 2 },
                    { 26, 1, 3, "Endless Cry", 4, 2 },
                    { 27, 1, 3, "Warpath", 4, 2 },
                    { 28, 1, 3, "Imposing Presence", 4, 2 },
                    { 29, 1, 3, "Martial Vigor", 4, 2 },
                    { 30, 1, 3, "Outburst", 4, 2 },
                    { 31, 1, 3, "Tough As Nails", 4, 2 },
                    { 32, 1, 3, "Belligerence", 4, 2 },
                    { 33, 1, 3, "Booming Voice", 4, 2 },
                    { 34, 1, 3, "Raid Leader", 4, 2 },
                    { 35, 1, 3, "Guttural Yell", 4, 2 },
                    { 36, 1, 3, "Aggressive Resistance", 4, 2 },
                    { 37, 1, 3, "Battle Fervor", 4, 2 },
                    { 38, 1, 3, "Prolific Fury", 4, 2 },
                    { 39, 1, 3, "Swiftness", 4, 2 },
                    { 40, 1, 3, "Quick Impulses", 4, 2 },
                    { 41, 1, 3, "No Mercy", 4, 2 },
                    { 42, 1, 3, "Slaying Strike", 4, 2 },
                    { 43, 1, 3, "Expose Vulnerability", 4, 2 },
                    { 44, 1, 3, "Thick Skin", 4, 2 },
                    { 45, 1, 3, "Defensive Stance", 4, 2 },
                    { 46, 1, 3, "Counteroffensive", 4, 2 },
                    { 47, 1, 3, "Hamstring", 4, 2 },
                    { 48, 1, 3, "Cut To The Bone", 4, 2 },
                    { 49, 1, 3, "Pit Fighter", 4, 2 },
                    { 50, 1, 3, "Irrepressible", 4, 2 },
                    { 51, 1, 3, "Heavy Handed", 4, 2 },
                    { 52, 1, 3, "Wallop ", 4, 2 },
                    { 53, 1, 3, "Brute Force", 4, 2 },
                    { 54, 1, 3, "Concussion", 4, 2 },
                    { 55, 1, 3, "Tempered Fury", 4, 2 },
                    { 56, 1, 3, "Furious Impulse", 4, 2 },
                    { 57, 1, 3, "Invigorating Fury", 4, 2 },
                    { 58, 1, 3, "Duelist", 4, 2 },
                    { 59, 1, 3, "Heavy Hitter", 4, 2 },
                    { 60, 1, 3, "Unconstrained", 4, 2 },
                    { 61, 1, 3, "Walking Arsenal", 4, 2 },
                    { 62, 1, 3, "Unbridled Rage", 4, 2 },
                    { 63, 1, 3, "Gushing Wounds", 4, 2 },
                    { 64, 1, 3, "Barbed Carapace", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 65, "", "Enhanced Bash", 0, 1 },
                    { 66, "", "Battle Bash", 65, 1 },
                    { 67, "", "Combat Bash", 0, 1 },
                    { 68, "", "Enhanced Lunging Strike", 0, 2 },
                    { 69, "", "Battle Lunging Strike", 68, 2 },
                    { 70, "", "Combat Lunging Strike", 0, 2 },
                    { 71, "", "Enhanced Frenzy", 0, 3 },
                    { 72, "", "Battle Frenzy", 71, 3 },
                    { 73, "", "Combat Frenzy", 0, 3 },
                    { 74, "", "Enhanced Flay", 0, 4 },
                    { 75, "", "Battle Flay", 74, 4 },
                    { 76, "", "Combat Flay", 0, 4 },
                    { 77, "", "Enhanced Whirlwind", 0, 5 },
                    { 78, "", "Furious Whirlwind", 77, 5 },
                    { 79, "", "Violent Whirlwind", 0, 5 },
                    { 80, "", "Enhanced Hammer Of The Ancients", 0, 6 },
                    { 81, "", "Furious Hammer Of The Ancients", 80, 6 },
                    { 82, "", "Violent Hammer Of The Ancients", 0, 6 },
                    { 83, "", "Enhanced Upheaval", 0, 7 },
                    { 84, "", "Furious Upheaval", 83, 7 },
                    { 85, "", "Violent Upheaval", 0, 7 },
                    { 86, "", "Enhanced Double Swing", 0, 8 },
                    { 87, "", "Furious Double Swing", 86, 8 },
                    { 88, "", "Violent Double Swing", 0, 8 },
                    { 89, "", "Enhanced Rend", 0, 9 },
                    { 90, "", "Furious Rend", 89, 9 },
                    { 91, "", "Violent Rend", 0, 9 },
                    { 92, "", "Enhanced Double Stomp", 0, 10 },
                    { 93, "", "Strategic Double Stomp", 92, 10 },
                    { 94, "", "Tactical Double Stomp", 0, 10 },
                    { 95, "", "Enhanced Rallying Cry", 0, 11 },
                    { 96, "", "Strategic Rallying Cry", 95, 11 },
                    { 97, "", "Tactical Rallying Cry", 0, 11 },
                    { 98, "", "Enhanced Iron Skin", 0, 12 },
                    { 99, "", "Strategic Iron Skin", 98, 12 },
                    { 100, "", "Tactical Iron Skin", 0, 12 },
                    { 101, "", "Enhanced Challenging Shout", 0, 13 },
                    { 102, "", "Strategic Challenging Shout", 101, 13 },
                    { 103, "", "Tactical Challenging Shout", 0, 13 },
                    { 104, "", "Enhanced Kick", 0, 14 },
                    { 105, "", "Mighty Kick", 104, 14 },
                    { 106, "", "Power Kick", 0, 14 },
                    { 107, "", "Enhanced War Cry", 0, 15 },
                    { 108, "", "Mighty War Cry", 107, 15 },
                    { 109, "", "Power War Cry", 0, 15 },
                    { 110, "", "Enhanced Charge", 0, 16 },
                    { 111, "", "Mighty Charge", 110, 16 },
                    { 112, "", "Power Charge", 0, 16 },
                    { 113, "", "Enhanced Leap", 0, 17 },
                    { 114, "", "Mighty Leap", 113, 17 },
                    { 115, "", "Power Leap", 0, 17 },
                    { 116, "", "Enhanced Rupture", 0, 18 },
                    { 117, "", "Fighter's Rupture", 116, 18 },
                    { 118, "", "Warrior's Rupture", 0, 18 },
                    { 119, "", "Enhanced Steel Grasp", 0, 19 },
                    { 120, "", "Fighter's Steel Grasp", 119, 19 },
                    { 121, "", "Warrior's Steel Grasp", 0, 19 },
                    { 122, "", "Enhanced Death Blow", 0, 20 },
                    { 123, "", "Fighter's Death Blow", 122, 20 },
                    { 124, "", "Warrior's Death Blow", 0, 20 },
                    { 125, "", "Enhanced Mighty Blow", 0, 21 },
                    { 126, "", "Fighter's Mighty Blow", 125, 21 },
                    { 127, "", "Warrior's Mighty Blow", 0, 21 },
                    { 128, "", "Prime Call Of The Ancients", 0, 22 },
                    { 129, "", "Surpreme Call Of The Ancients", 128, 22 },
                    { 130, "", "Prime Iron Maelstrom", 0, 23 },
                    { 131, "", "Supreme Iron Maelstrom", 130, 23 },
                    { 132, "", "Prime Wrath of The Berserker", 0, 24 },
                    { 133, "", "Supreme Wrath of The Berserker", 132, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillCategoryId",
                table: "Skills",
                column: "SkillCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillUpgrades_SkillId",
                table: "SkillUpgrades",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillCategories_SkillCategoryId",
                table: "Skills",
                column: "SkillCategoryId",
                principalTable: "SkillCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillCategories_SkillCategoryId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "SkillCategories");

            migrationBuilder.DropTable(
                name: "SkillUpgrades");

            migrationBuilder.DropIndex(
                name: "IX_Skills_SkillCategoryId",
                table: "Skills");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SkillCategoryId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SkillType",
                table: "Skills");
        }
    }
}
