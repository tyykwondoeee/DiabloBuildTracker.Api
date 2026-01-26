using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiabloBuildTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedRogueSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Rogue");

            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 14, "Agility" },
                    { 15, "Subterfuge" },
                    { 16, "Imbuement" }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 195,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 196,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 197,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 198,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 199,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 200,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 327,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 328,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 329,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 330,
                column: "MaxRank",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 331,
                column: "MaxRank",
                value: 1);

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 388, 4, 5, "Blade Shift", 1, 1 },
                    { 389, 4, 5, "Invigorating Strike", 1, 1 },
                    { 390, 4, 5, "Forceful Arrow", 1, 1 },
                    { 391, 4, 5, "Heartseeker", 1, 1 },
                    { 392, 4, 5, "Puncture", 2, 1 },
                    { 393, 4, 5, "Flurry", 2, 1 },
                    { 394, 4, 5, "Twisting Blades", 2, 1 },
                    { 395, 4, 5, "Barrage", 2, 1 },
                    { 396, 4, 5, "Penetrating Shot", 2, 1 },
                    { 397, 4, 5, "Rapid Fire", 3, 1 },
                    { 409, 4, 5, "Death Trap", 8, 1 },
                    { 410, 4, 5, "Rain Of Arrows", 8, 1 },
                    { 411, 4, 5, "Shadow Clone", 8, 1 },
                    { 412, 4, 3, "Target Practice", 4, 2 },
                    { 413, 4, 3, "Stutter Step", 4, 2 },
                    { 414, 4, 3, "Sturdy", 4, 2 },
                    { 415, 4, 3, "Siphoning Strikes", 4, 2 },
                    { 416, 4, 3, "Unstable Elixirs", 4, 2 },
                    { 417, 4, 3, "Rapid Gambits", 4, 2 },
                    { 418, 4, 3, "Trick Attacks", 4, 2 },
                    { 419, 4, 3, "Balestra", 4, 2 },
                    { 420, 4, 3, "Weapon Mastery", 4, 2 },
                    { 421, 4, 3, "Rugged", 4, 2 },
                    { 422, 4, 3, "Reactive Defense", 4, 2 },
                    { 423, 4, 3, "Agile", 4, 2 },
                    { 424, 4, 3, "Mending Obscurity", 4, 2 },
                    { 425, 4, 3, "Evasive", 4, 2 },
                    { 426, 4, 3, "Exploit", 4, 2 },
                    { 427, 4, 3, "Malice", 4, 2 },
                    { 428, 4, 3, "Frigid Finesse", 4, 2 },
                    { 429, 4, 3, "Chilling Weight", 4, 2 },
                    { 430, 4, 3, "Precision Imbuement", 4, 2 },
                    { 431, 4, 3, "Deadly Venom", 4, 2 },
                    { 432, 4, 3, "Alchemical Advantage", 4, 2 },
                    { 433, 4, 3, "Debilitating Toxins", 4, 2 },
                    { 434, 4, 3, "Shadow Crash", 4, 2 },
                    { 435, 4, 3, "Consuming Shadows", 4, 2 },
                    { 436, 4, 3, "Trap Mastery", 4, 2 },
                    { 437, 4, 3, "Innervation", 4, 2 },
                    { 438, 4, 3, "Alchemist's Fortune", 4, 2 },
                    { 439, 4, 3, "Second Wind", 4, 2 },
                    { 440, 4, 3, "Aftermath", 4, 2 },
                    { 441, 4, 3, "Unto Dawn", 4, 2 },
                    { 442, 4, 3, "Adrenaline Rush", 4, 2 },
                    { 443, 4, 3, "Haste", 4, 2 },
                    { 444, 4, 3, "Impetus", 4, 2 },
                    { 445, 4, 3, "Alchemical Admixture", 9, 2 },
                    { 446, 4, 3, "Close Quarters Combat", 9, 2 },
                    { 447, 4, 1, "Exposure", 9, 2 },
                    { 448, 4, 1, "Momentum", 9, 2 },
                    { 449, 4, 1, "Precision", 9, 2 },
                    { 450, 4, 1, "Victimize", 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 451, "", "Enhanced Blade Shift", null, 388 },
                    { 454, "", "Enhanced Invigorating Strike", null, 389 },
                    { 457, "", "Enhanced Forceful Arrow", null, 390 },
                    { 460, "", "Enhanced Heartseeker", null, 391 },
                    { 463, "", "Enhanced Puncture", null, 392 },
                    { 466, "", "Enhanced Flurry", null, 393 },
                    { 469, "", "Enhanced Twisting Blades", null, 394 },
                    { 472, "", "Enhanced Barrage", null, 395 },
                    { 475, "", "Enhanced Penetrating Shot", null, 396 },
                    { 478, "", "Enhanced Rapid Fire", null, 397 },
                    { 514, "", "Prime Death Trap", null, 409 },
                    { 516, "", "Prime Rain Of Arrows", null, 410 },
                    { 518, "", "Prime Shadow Clone", null, 411 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 398, 4, 5, "Dance Of Knives", 14, 1 },
                    { 399, 4, 5, "Shadow Step", 14, 1 },
                    { 400, 4, 5, "Caltrops", 14, 1 },
                    { 401, 4, 5, "Dash", 14, 1 },
                    { 402, 4, 5, "Concealment", 15, 1 },
                    { 403, 4, 5, "Dark Shroud", 15, 1 },
                    { 404, 4, 5, "Poison Trap", 15, 1 },
                    { 405, 4, 5, "Smoke Grenade", 15, 1 },
                    { 406, 4, 5, "Cold Imbuement", 16, 1 },
                    { 407, 4, 5, "Poison Imbuement", 16, 1 },
                    { 408, 4, 5, "Shadow Imbuement", 16, 1 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 452, "", "Fundamental Blade Shift", 451, 388 },
                    { 453, "", "Primary Blade Shift", 451, 388 },
                    { 455, "", "Fundamental Invigorating Strike", 454, 389 },
                    { 456, "", "Primary Invigorating Strike", 454, 389 },
                    { 458, "", "Fundamental Forceful Arrow", 457, 390 },
                    { 459, "", "Primary Forceful Arrow", 457, 390 },
                    { 461, "", "Fundamental Heartseeker", 460, 391 },
                    { 462, "", "Primary Heartseeker", 460, 391 },
                    { 464, "", "Fundamental Puncture", 463, 392 },
                    { 465, "", "Primary Puncture", 463, 392 },
                    { 467, "", "Advanced Flurry", 466, 393 },
                    { 468, "", "Improved Flurry", 466, 393 },
                    { 470, "", "Advanced Twisting Blades", 469, 394 },
                    { 471, "", "Improved Twisting Blades", 469, 394 },
                    { 473, "", "Advanced Barrage", 472, 395 },
                    { 474, "", "Improved Barrage", 472, 395 },
                    { 476, "", "Advanced Penetrating Shot", 475, 396 },
                    { 477, "", "Improved Penetrating Shot", 475, 396 },
                    { 479, "", "Advanced Rapid Fire", 478, 397 },
                    { 480, "", "Improved Rapid Fire", 478, 397 },
                    { 481, "", "Enhanced Dance Of Knives", null, 398 },
                    { 484, "", "Enhanced Shadow Step", null, 399 },
                    { 487, "", "Enhanced Caltrops", null, 400 },
                    { 490, "", "Enhanced Dash", null, 401 },
                    { 493, "", "Enhanced Concealment", null, 402 },
                    { 496, "", "Enhanced Dark Shroud", null, 403 },
                    { 499, "", "Enhanced Poison Trap", null, 404 },
                    { 502, "", "Enhanced Smoke Grenade", null, 405 },
                    { 505, "", "Enhanced Cold Imbuement", null, 406 },
                    { 508, "", "Enhanced Poison Imbuement", null, 407 },
                    { 511, "", "Enhanced Shadow Imbuement", null, 408 },
                    { 515, "", "Surpreme Death Trap", 514, 409 },
                    { 517, "", "Supreme Rain Of Arrows", 516, 410 },
                    { 519, "", "Supreme Shadow Clone", 518, 411 },
                    { 482, "", "Methodical Dance Of Knives", 481, 398 },
                    { 483, "", "Disciplined Dance Of Knives", 481, 398 },
                    { 485, "", "Methodical Shadow Step", 484, 399 },
                    { 486, "", "Disciplined Shadow Step", 484, 399 },
                    { 488, "", "Methodical Caltrops", 487, 400 },
                    { 489, "", "Disciplined Caltrops", 487, 400 },
                    { 491, "", "Methodical Dash", 490, 401 },
                    { 492, "", "Disciplined Dash", 490, 401 },
                    { 494, "", "Countering Concealment", 493, 402 },
                    { 495, "", "Subvverting Concealment", 493, 402 },
                    { 497, "", "Countering Dark Shroud", 496, 403 },
                    { 498, "", "Subverting Dark Shroud", 496, 403 },
                    { 500, "", "Countering Poison Trap", 499, 404 },
                    { 501, "", "Subverting Poison Trap", 499, 404 },
                    { 503, "", "Countering Smoke Grenade", 502, 405 },
                    { 504, "", "Subverting Smoke Grenade", 502, 405 },
                    { 506, "", "Blended Cold Imbuement", 505, 406 },
                    { 507, "", "Mixed Cold Imbuement", 505, 406 },
                    { 509, "", "Blended Poison Imbuement", 508, 407 },
                    { 510, "", "Mixed Poison Imbuement", 508, 407 },
                    { 512, "", "Blended Shadow Imbuement", 511, 408 },
                    { 513, "", "Mixed Poison Imbuement", 511, 408 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Rouge");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 195,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 196,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 197,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 198,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 199,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 200,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 327,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 328,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 329,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 330,
                column: "MaxRank",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 331,
                column: "MaxRank",
                value: 3);
        }
    }
}
