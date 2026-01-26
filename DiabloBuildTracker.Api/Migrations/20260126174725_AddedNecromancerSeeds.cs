using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiabloBuildTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedNecromancerSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "Curse" },
                    { 13, "Corpse & Macabre" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 272, 3, 5, "Bone Splinters", 1, 1 },
                    { 273, 3, 5, "Decompose", 1, 1 },
                    { 274, 3, 5, "Hemorrhage", 1, 1 },
                    { 275, 3, 5, "Reap", 1, 1 },
                    { 276, 3, 5, "Blight", 2, 1 },
                    { 277, 3, 5, "Blood Lance", 2, 1 },
                    { 278, 3, 5, "Blood Surge", 2, 1 },
                    { 279, 3, 5, "Bone Spear", 2, 1 },
                    { 280, 3, 5, "Sever", 2, 1 },
                    { 288, 3, 5, "Army Of The Dead", 8, 1 },
                    { 289, 3, 5, "Blood Wave", 8, 1 },
                    { 290, 3, 5, "Bone Storm", 8, 1 },
                    { 291, 3, 5, "Soulrift", 8, 1 },
                    { 292, 3, 3, "Unliving Energy", 4, 2 },
                    { 293, 3, 3, "Imperfectly Balanced", 4, 2 },
                    { 294, 3, 3, "Hewed Flesh", 4, 2 },
                    { 295, 3, 3, "Grim Harvest", 4, 2 },
                    { 296, 3, 3, "Fueled By Death", 4, 2 },
                    { 297, 3, 3, "Necrotic Fortitude", 4, 2 },
                    { 298, 3, 3, "Titan's Fall", 4, 2 },
                    { 299, 3, 3, "Skeletal Warrior Mastery", 4, 2 },
                    { 300, 3, 3, "Spiked Armor", 4, 2 },
                    { 301, 3, 3, "Amplify Damage", 4, 2 },
                    { 302, 3, 3, "Death's Embrace", 4, 2 },
                    { 303, 3, 3, "Skeletal Mage Mastery", 4, 2 },
                    { 304, 3, 3, "Precision Decay", 4, 2 },
                    { 305, 3, 3, "Gruesome Mending", 4, 2 },
                    { 306, 3, 3, "Coalesced Blood", 4, 2 },
                    { 307, 3, 3, "Transfusion", 4, 2 },
                    { 308, 3, 3, "Drain Vitality", 4, 2 },
                    { 309, 3, 3, "Tides Of Blood", 4, 2 },
                    { 310, 3, 3, "Reaper's Pursuit", 4, 2 },
                    { 311, 3, 3, "Crippling Darkness", 4, 2 },
                    { 312, 3, 3, "Gloom", 4, 2 },
                    { 313, 3, 3, "Terror", 4, 2 },
                    { 314, 3, 3, "Serration", 4, 2 },
                    { 315, 3, 3, "Compound Fracture", 4, 2 },
                    { 316, 3, 3, "Evulsion", 4, 2 },
                    { 317, 3, 3, "Rapid Ossification", 4, 2 },
                    { 318, 3, 3, "Necrotic Carapace", 4, 2 },
                    { 319, 3, 3, "Finality", 4, 2 },
                    { 320, 3, 3, "Stand Alone", 4, 2 },
                    { 321, 3, 3, "Memento Mori", 4, 2 },
                    { 322, 3, 3, "Golem Mastery", 4, 2 },
                    { 323, 3, 3, "Bonded in Essence", 4, 2 },
                    { 324, 3, 3, "Inspiring Leader", 4, 2 },
                    { 325, 3, 3, "Death's Defense", 4, 2 },
                    { 326, 3, 3, "Hellbent Commander", 4, 2 },
                    { 327, 3, 3, "Kalan's Edict", 9, 2 },
                    { 328, 3, 3, "Ossified Essence", 9, 2 },
                    { 329, 3, 3, "Affliction", 9, 2 },
                    { 330, 3, 3, "Rathma;s Vigor", 9, 2 },
                    { 331, 3, 3, "Shadowblight", 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 332, "", "Enhanced Bone Splinters", null, 272 },
                    { 335, "", "Enhanced Decompose", null, 273 },
                    { 338, "", "Enhanced Hemorrhage", null, 274 },
                    { 341, "", "Enhanced Reap", null, 275 },
                    { 344, "", "Enhanced Blight", null, 276 },
                    { 347, "", "Enhanced Blood Lance", null, 277 },
                    { 350, "", "Enhanced Blood Surge", null, 278 },
                    { 353, "", "Enhanced Bone Spear", null, 279 },
                    { 356, "", "Enhanced Sever", null, 280 },
                    { 380, "", "Prime Army of the Dead", null, 288 },
                    { 382, "", "Prime Blood Wave", null, 289 },
                    { 384, "", "Prime Bone Storm", null, 290 },
                    { 386, "", "Prime Soulrift", null, 291 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 281, 3, 5, "Blood Mist", 13, 1 },
                    { 282, 3, 5, "Bone Prison", 13, 1 },
                    { 283, 3, 5, "Corpse Explosion", 13, 1 },
                    { 284, 3, 5, "Decrepify", 12, 1 },
                    { 285, 3, 5, "Iron Maiden", 12, 1 },
                    { 286, 3, 5, "Bone Spirit", 13, 1 },
                    { 287, 3, 5, "Corpse Tendrils", 13, 1 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 333, "", "Acolyte's Bone Splinters", 332, 272 },
                    { 334, "", "Initiate's Bone Splinters", 332, 272 },
                    { 336, "", "Acolyte's Decompose", 335, 273 },
                    { 337, "", "Initiate's Decompose", 335, 273 },
                    { 339, "", "Acolyte's Hemorrhage", 338, 274 },
                    { 340, "", "Initiate's Hemorrhage", 338, 274 },
                    { 342, "", "Acolyte's Reap", 341, 275 },
                    { 343, "", "Initiate's Reap", 341, 275 },
                    { 345, "", "Paranormal Blight", 344, 276 },
                    { 346, "", "Supernatual Blight", 344, 276 },
                    { 348, "", "Paranormal Blood Lance", 347, 277 },
                    { 349, "", "Supernatual Blood Lance", 347, 277 },
                    { 351, "", "Paranormal Blood Surge", 350, 278 },
                    { 352, "", "Supernatural Blood Surge", 350, 278 },
                    { 354, "", "Paranormal Bone Spear", 353, 279 },
                    { 355, "", "Supernatual Bone Spear", 353, 279 },
                    { 357, "", "Paranormal Sever", 356, 280 },
                    { 358, "", "Supernatual Sever", 356, 280 },
                    { 359, "", "Enhanced Blood Mist", null, 281 },
                    { 362, "", "Enhanced Bone Prison", null, 282 },
                    { 365, "", "Enhanced Corpse Explosion", null, 283 },
                    { 368, "", "Enhanced Decrepify", null, 284 },
                    { 371, "", "Enhanced Iron Maiden", null, 285 },
                    { 374, "", "Enhanced Bone Spirit", null, 286 },
                    { 377, "", "Enhanced Corpse Tendrils", null, 287 },
                    { 381, "", "Supreme Army of the Dead", 380, 288 },
                    { 383, "", "Supreme Blood Wave", 382, 289 },
                    { 385, "", "Supreme Bone Storm", 384, 290 },
                    { 387, "", "Supreme Soulrift", 386, 291 },
                    { 360, "", "Dreadful Blood Mist", 359, 281 },
                    { 361, "", "Ghastly Blood Mist", 359, 281 },
                    { 363, "", "Dreadful Bone Prison", 362, 282 },
                    { 364, "", "Ghastly Bone Prison", 362, 282 },
                    { 366, "", "Dreadful Corpse Explosion", 365, 283 },
                    { 367, "", "Ghastly Corpse Explosion", 365, 283 },
                    { 369, "", "Abhorrent Decrepify", 368, 284 },
                    { 370, "", "Horrid Decrepify", 368, 284 },
                    { 372, "", "Abhorrent Iron Maiden", 371, 285 },
                    { 373, "", "Horrid Iron Maiden", 371, 285 },
                    { 375, "", "Dreadful Bone Spirit", 374, 286 },
                    { 376, "", "Ghastly Bone Spirit", 374, 286 },
                    { 378, "", "Dreadful Corpse Tendrils", 377, 287 },
                    { 379, "", "Ghastly Corpse Tendrils", 377, 287 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
