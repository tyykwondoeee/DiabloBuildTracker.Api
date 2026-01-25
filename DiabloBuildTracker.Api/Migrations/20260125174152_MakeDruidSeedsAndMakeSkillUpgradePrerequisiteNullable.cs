using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiabloBuildTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class MakeDruidSeedsAndMakeSkillUpgradePrerequisiteNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequiredUpgradeId",
                table: "SkillUpgrades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Companion" },
                    { 11, "Wrath" }
                });

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 65,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 67,
                column: "RequiredUpgradeId",
                value: 65);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 68,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 70,
                column: "RequiredUpgradeId",
                value: 68);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 71,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 73,
                column: "RequiredUpgradeId",
                value: 71);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 74,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 76,
                column: "RequiredUpgradeId",
                value: 74);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 77,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 79,
                column: "RequiredUpgradeId",
                value: 77);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 80,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 82,
                column: "RequiredUpgradeId",
                value: 80);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 83,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 85,
                column: "RequiredUpgradeId",
                value: 83);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 86,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 88,
                column: "RequiredUpgradeId",
                value: 86);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 89,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 91,
                column: "RequiredUpgradeId",
                value: 89);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 92,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 94,
                column: "RequiredUpgradeId",
                value: 92);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 95,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 97,
                column: "RequiredUpgradeId",
                value: 95);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 98,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 100,
                column: "RequiredUpgradeId",
                value: 98);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 101,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 103,
                column: "RequiredUpgradeId",
                value: 101);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 104,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 106,
                column: "RequiredUpgradeId",
                value: 104);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 107,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 109,
                column: "RequiredUpgradeId",
                value: 107);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 110,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 112,
                column: "RequiredUpgradeId",
                value: 110);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 113,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 115,
                column: "RequiredUpgradeId",
                value: 113);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 116,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 118,
                column: "RequiredUpgradeId",
                value: 116);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 119,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 121,
                column: "RequiredUpgradeId",
                value: 119);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 122,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 124,
                column: "RequiredUpgradeId",
                value: 122);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 125,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 127,
                column: "RequiredUpgradeId",
                value: 125);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 128,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 130,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 132,
                column: "RequiredUpgradeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "SkillCategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "SkillCategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "SkillCategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "SkillCategoryId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "SkillCategoryId",
                value: 9);

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 134, 2, 5, "Maul", 1, 1 },
                    { 135, 2, 5, "Claw", 1, 1 },
                    { 136, 2, 5, "Storm Strike", 1, 1 },
                    { 137, 2, 5, "Wind Shear", 1, 1 },
                    { 138, 2, 5, "Earth Spike", 2, 1 },
                    { 139, 2, 5, "Lightning Storm", 2, 1 },
                    { 140, 2, 5, "Tornado", 2, 1 },
                    { 141, 2, 5, "Pulverize", 2, 1 },
                    { 142, 2, 5, "Shred", 2, 1 },
                    { 143, 2, 5, "Landslide", 3, 1 },
                    { 144, 2, 5, "Earthen Bulwark", 3, 1 },
                    { 145, 2, 5, "Cyclone Armor", 3, 1 },
                    { 146, 2, 5, "Blood Howl", 3, 1 },
                    { 147, 2, 5, "Debilitating Roar", 5, 1 },
                    { 155, 2, 3, "Grizzly Rage", 8, 1 },
                    { 156, 2, 3, "Petrify", 8, 1 },
                    { 157, 2, 3, "Lacerate", 8, 1 },
                    { 158, 2, 3, "Cataclysm", 8, 1 },
                    { 159, 2, 3, "Heart Of The Wind", 4, 2 },
                    { 160, 2, 3, "Wild Impulses", 4, 2 },
                    { 161, 2, 3, "Abundance", 4, 2 },
                    { 162, 2, 3, "Predatory Instinct", 4, 2 },
                    { 163, 2, 3, "Digitigrade Gait", 4, 2 },
                    { 164, 2, 3, "Iron Fur", 4, 2 },
                    { 165, 2, 3, "Ancestral Fortitude", 4, 2 },
                    { 166, 2, 3, "Vigilance", 4, 2 },
                    { 167, 2, 3, "Nature's Reach", 4, 2 },
                    { 168, 2, 3, "Call Of The Wind", 4, 2 },
                    { 169, 2, 3, "Clarity", 4, 2 },
                    { 170, 2, 3, "Elemental Exposure", 4, 2 },
                    { 171, 2, 3, "Charged Atmosphere", 4, 2 },
                    { 172, 2, 3, "Electric Shock", 4, 2 },
                    { 173, 2, 3, "Bad Omen", 4, 2 },
                    { 174, 2, 3, "Endless Tempest", 4, 2 },
                    { 175, 2, 3, "Crushing Earth", 4, 2 },
                    { 176, 2, 3, "Safeguard", 4, 2 },
                    { 177, 2, 3, "Stone Guard", 4, 2 },
                    { 178, 2, 3, "Mending", 4, 2 },
                    { 179, 2, 3, "Provocation", 4, 2 },
                    { 180, 2, 3, "Toxic", 4, 2 },
                    { 181, 2, 3, "Neurotoxin", 4, 2 },
                    { 182, 2, 3, "Envenom", 4, 2 },
                    { 183, 2, 3, "Defensive Posture", 4, 2 },
                    { 184, 2, 3, "Thick Hide", 4, 2 },
                    { 185, 2, 3, "Unrestrained", 4, 2 },
                    { 186, 2, 3, "Nature's Resolve", 4, 2 },
                    { 187, 2, 3, "Quickshift", 4, 2 },
                    { 188, 2, 3, "Natural Fortitude", 4, 2 },
                    { 189, 2, 3, "Heightened Senses", 4, 2 },
                    { 190, 2, 3, "Defiance", 4, 2 },
                    { 191, 2, 3, "Circle Of Life", 4, 2 },
                    { 192, 2, 3, "Resonance", 4, 2 },
                    { 193, 2, 3, "Natural Disaster", 4, 2 },
                    { 194, 2, 3, "Bestial Rampage", 9, 2 },
                    { 195, 2, 3, "Earthen Might", 9, 2 },
                    { 196, 2, 3, "Lupine Ferocity", 9, 2 },
                    { 197, 2, 3, "Nature's Fury", 9, 2 },
                    { 198, 2, 3, "Perfect Storm", 9, 2 },
                    { 199, 2, 3, "Ursine Strength", 9, 2 },
                    { 200, 2, 3, "One With Nature", 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 201, "", "Enhanced Maul", null, 134 },
                    { 204, "", "Enhanced Claw", null, 135 },
                    { 207, "", "Enhanced Storm Strike", null, 136 },
                    { 210, "", "Enhanced Wind Shear", null, 137 },
                    { 213, "", "Enhanced Earth Spike", null, 138 },
                    { 216, "", "Enhanced Lightning Storm", null, 139 },
                    { 219, "", "Enhanced Tornado", null, 140 },
                    { 222, "", "Enhanced Pulverize", null, 141 },
                    { 225, "", "Enhanced Shred", null, 142 },
                    { 228, "", "Enhanced Landslide", null, 143 },
                    { 231, "", "Enhanced Earthen Bulwark", null, 144 },
                    { 234, "", "Enhanced Cyclone Armor", null, 145 },
                    { 237, "", "Enhanced Blood Howl", null, 146 },
                    { 240, "", "Enhanced Debilitating Roar", null, 147 },
                    { 264, "", "Prime Grizzly rage", null, 155 },
                    { 266, "", "Prime Petrify", null, 156 },
                    { 268, "", "Prime Lacerate", null, 157 },
                    { 270, "", "Prime Cataclysm", null, 158 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 148, 2, 5, "Wolves", 10, 1 },
                    { 149, 2, 5, "Ravens", 10, 1 },
                    { 150, 2, 5, "Poison Creeper", 10, 1 },
                    { 151, 2, 5, "Boulder", 11, 1 },
                    { 152, 2, 5, "Trample", 11, 1 },
                    { 153, 2, 5, "Hurricane", 11, 1 },
                    { 154, 2, 5, "Rabies", 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 202, "", "Fierce Maul", 201, 134 },
                    { 203, "", "Wild Maul", 201, 134 },
                    { 205, "", "Fierce Claw", 204, 135 },
                    { 206, "", "Wild Claw", 204, 135 },
                    { 208, "", "Fierce Storm Strike", 207, 136 },
                    { 209, "", "Wild Storm Strike", 207, 136 },
                    { 211, "", "Fierce Wind Shear", 210, 137 },
                    { 212, "", "Wild Wind Shear", 210, 137 },
                    { 214, "", "Wild Earth Spike", 213, 138 },
                    { 215, "", "Fierce Earth Spike", 213, 138 },
                    { 217, "", "Raging Lightning Storm", 216, 139 },
                    { 218, "", "Primal Lightning Storm", 216, 139 },
                    { 220, "", "Primal Tornando", 219, 140 },
                    { 221, "", "Raging Tornado", 219, 140 },
                    { 223, "", "Primal Pulverize", 222, 141 },
                    { 224, "", "Raging Pulverize", 222, 141 },
                    { 226, "", "Primal Shred", 225, 142 },
                    { 227, "", "Raging Shred", 225, 142 },
                    { 229, "", "Primal Landslide", 228, 143 },
                    { 230, "", "Raging Landslide", 228, 143 },
                    { 232, "", "Innate Earthen Bulwark", 231, 144 },
                    { 235, "", "Innate Cyclone Armor", 234, 145 },
                    { 236, "", "Preserving Cyclone Armor", 234, 145 },
                    { 238, "", "Innate Blood Howl", 237, 146 },
                    { 239, "", "Preserving Blood Howl", 237, 146 },
                    { 241, "", "Innate Beblitating Roar", 240, 147 },
                    { 242, "", "Preserving Deblitating Roar", 240, 147 },
                    { 243, "", "Enhanced Wolf Pack", null, 148 },
                    { 246, "", "Enhanced Ravens", null, 149 },
                    { 249, "", "Enhanced Poison Creeper", null, 150 },
                    { 252, "", "Enhanced Boulder", null, 151 },
                    { 255, "", "Enhanced Trample", null, 152 },
                    { 258, "", "Enhanced Hurricane", null, 153 },
                    { 261, "", "Enhanced Rabies", null, 154 },
                    { 265, "", "Supreme Grizzly Rage", 264, 155 },
                    { 267, "", "Supreme Petrify", 266, 156 },
                    { 269, "", "Supreme Lacerate", 268, 157 },
                    { 271, "", "Supreme Cataclysm", 270, 158 },
                    { 233, "", "Preserving Earthen Bulwark", 232, 144 },
                    { 244, "", "Brustal Wolf Pack", 243, 148 },
                    { 245, "", "Ferocious Wolf Pack", 243, 148 },
                    { 247, "", "Brutal Ravens", 246, 149 },
                    { 248, "", "Ferocious Ravens", 246, 149 },
                    { 250, "", "Ferocious Poison Creeper", 249, 150 },
                    { 251, "", "Brutal Poison Creeper", 249, 150 },
                    { 253, "", "Natural Boulder", 252, 151 },
                    { 254, "", "Savage Boulder", 252, 151 },
                    { 256, "", "Natural Trample", 255, 152 },
                    { 257, "", "Savage Trample", 255, 152 },
                    { 259, "", "Natural Hurricane", 258, 153 },
                    { 260, "", "Savage Hurricane", 258, 153 },
                    { 262, "", "Natural Rabies", 261, 154 },
                    { 263, "", "Savage Rabies", 261, 154 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillUpgrades_RequiredUpgradeId",
                table: "SkillUpgrades",
                column: "RequiredUpgradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUpgrades_SkillUpgrades_RequiredUpgradeId",
                table: "SkillUpgrades",
                column: "RequiredUpgradeId",
                principalTable: "SkillUpgrades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUpgrades_SkillUpgrades_RequiredUpgradeId",
                table: "SkillUpgrades");

            migrationBuilder.DropIndex(
                name: "IX_SkillUpgrades_RequiredUpgradeId",
                table: "SkillUpgrades");

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.AlterColumn<int>(
                name: "RequiredUpgradeId",
                table: "SkillUpgrades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 65,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 67,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 68,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 70,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 71,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 73,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 74,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 76,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 77,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 79,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 80,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 82,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 83,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 85,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 86,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 88,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 89,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 91,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 92,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 94,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 95,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 97,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 98,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 100,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 101,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 103,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 104,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 106,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 107,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 109,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 110,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 112,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 113,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 115,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 116,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 118,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 119,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 121,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 122,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 124,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 125,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 127,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 128,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 130,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 132,
                column: "RequiredUpgradeId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "SkillCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "SkillCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "SkillCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "SkillCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "SkillCategoryId",
                value: 4);
        }
    }
}
