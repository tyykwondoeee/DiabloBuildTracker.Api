using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiabloBuildTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedSorcererSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 17, "Conjuration" },
                    { 18, "Mastery" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 520, 5, 5, "Fire Bolt", 1, 1 },
                    { 521, 5, 5, "Frost Bolt", 1, 1 },
                    { 522, 5, 5, "Arc Lash", 1, 1 },
                    { 523, 5, 5, "Spark", 1, 1 },
                    { 524, 5, 5, "Fireball", 2, 1 },
                    { 525, 5, 5, "Incinerate", 2, 1 },
                    { 526, 5, 5, "Frozen Orb", 2, 1 },
                    { 527, 5, 5, "Ice Shards", 2, 1 },
                    { 528, 5, 5, "Chain Lightning", 2, 1 },
                    { 529, 5, 5, "Charged Bolts", 3, 1 },
                    { 530, 5, 5, "Flame Shield", 3, 1 },
                    { 531, 5, 5, "Frost Nova", 3, 1 },
                    { 532, 5, 5, "Ice Armor", 3, 1 },
                    { 533, 5, 5, "Teleport", 3, 1 },
                    { 542, 5, 3, "Inferno", 8, 1 },
                    { 543, 5, 3, "Deep Freeze", 8, 1 },
                    { 544, 5, 3, "Unstable Currents", 8, 1 },
                    { 545, 5, 3, "Devastation", 4, 2 },
                    { 546, 5, 3, "Elemental Dominance", 4, 2 },
                    { 547, 5, 3, "Potent Warding", 4, 2 },
                    { 548, 5, 3, "Elemental Attunment", 4, 2 },
                    { 549, 5, 3, "Glass Cannon", 4, 2 },
                    { 550, 5, 3, "Energy Focus", 4, 2 },
                    { 551, 5, 3, "Dampen Layer", 4, 2 },
                    { 552, 5, 3, "Align The Elements", 4, 2 },
                    { 553, 5, 3, "Mana Shield", 4, 2 },
                    { 554, 5, 3, "Protection", 4, 2 },
                    { 555, 5, 3, "Primordial Binding", 4, 2 },
                    { 556, 5, 3, "Precision Magic", 4, 2 },
                    { 557, 5, 3, "Inner Flames", 4, 2 },
                    { 558, 5, 3, "Crippling Flames", 4, 2 },
                    { 559, 5, 3, "Devouring Flames", 4, 2 },
                    { 560, 5, 3, "Icy Veil", 4, 2 },
                    { 561, 5, 3, "Cold Front", 4, 2 },
                    { 562, 5, 3, "Snap Freeze", 4, 2 },
                    { 563, 5, 3, "Static Discharge", 4, 2 },
                    { 564, 5, 3, "Invigorating Conduit", 4, 2 },
                    { 565, 5, 3, "Shocking Impact", 4, 2 },
                    { 566, 5, 3, "Elemental Synergies", 4, 2 },
                    { 567, 5, 3, "Evocation", 4, 2 },
                    { 568, 5, 3, "Fiery Surge", 4, 2 },
                    { 569, 5, 3, "Endless Pyre", 4, 2 },
                    { 570, 5, 3, "Soulfire", 4, 2 },
                    { 571, 5, 3, "Warmth", 4, 2 },
                    { 572, 5, 3, "Permafrost", 4, 2 },
                    { 573, 5, 3, "Hoarfrost", 4, 2 },
                    { 574, 5, 3, "Icy Touch", 4, 2 },
                    { 575, 5, 3, "Frigid Breeze", 4, 2 },
                    { 576, 5, 3, "Coursing Currents", 4, 2 },
                    { 577, 5, 3, "Conduction", 4, 2 },
                    { 578, 5, 3, "Electrocution", 4, 2 },
                    { 579, 5, 3, "Convulsions", 4, 2 },
                    { 580, 5, 1, "Enlightenment", 9, 2 },
                    { 581, 5, 1, "Combustion", 9, 2 },
                    { 582, 5, 1, "Esu's Ferocity", 9, 2 },
                    { 583, 5, 1, "Avalanche", 9, 2 },
                    { 584, 5, 1, "Shatter", 9, 2 },
                    { 585, 5, 1, "Overflowing Energy", 9, 2 },
                    { 586, 5, 1, "Vyr's Mastery", 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 587, "", "Enhanced Fire Bolt", null, 520 },
                    { 590, "", "Enhanced Frost Bolt", null, 521 },
                    { 593, "", "Enhanced Arc Lash", null, 522 },
                    { 596, "", "Enhanced Spark", null, 523 },
                    { 599, "", "Enhanced Fireball", null, 524 },
                    { 602, "", "Enhanced Incinerate", null, 525 },
                    { 605, "", "Enhanced Frozen Orb", null, 526 },
                    { 608, "", "Enhanced Ice Shards", null, 527 },
                    { 611, "", "Enhanced Chain Lightning", null, 528 },
                    { 614, "", "Enhanced Charged Bolts", null, 529 },
                    { 617, "", "Enhanced Flame Shield", null, 530 },
                    { 620, "", "Enhanced Frost Nova", null, 531 },
                    { 623, "", "Enhanced Ice Armor", null, 532 },
                    { 626, "", "Enhanced Teleport", null, 533 },
                    { 653, "", "Prime Inferno", null, 542 },
                    { 655, "", "Prime Deep Freeze", null, 543 },
                    { 657, "", "Prime Unstable Currents", null, 544 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 534, 5, 5, "Familiar", 17, 1 },
                    { 535, 5, 5, "Hydra", 17, 1 },
                    { 536, 5, 5, "Ice Blades", 17, 1 },
                    { 537, 5, 5, "Lightning Spear", 17, 1 },
                    { 538, 5, 5, "Firewall", 18, 1 },
                    { 539, 5, 5, "Meteor", 18, 1 },
                    { 540, 5, 5, "Blizzard", 18, 1 },
                    { 541, 5, 5, "Ball Lightning", 18, 1 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 588, "", "Flickering Fire Bolt", 587, 520 },
                    { 589, "", "Glinting Fire Bolt", 587, 520 },
                    { 591, "", "Flickering Frost Bolt", 590, 521 },
                    { 592, "", "Glinting Frost Bolt", 590, 521 },
                    { 594, "", "Flickering Arc Lash", 593, 522 },
                    { 595, "", "Glinting Arc Lash", 593, 522 },
                    { 597, "", "Flickering Spark", 596, 523 },
                    { 598, "", "Glinting Spark", 596, 523 },
                    { 600, "", "Destructive Fireball", 599, 524 },
                    { 601, "", "Greater Fireball", 599, 524 },
                    { 603, "", "Destructive Incinerate", 602, 525 },
                    { 604, "", "Greater Incinerate", 602, 525 },
                    { 606, "", "Destructive Frozen Orb", 605, 526 },
                    { 607, "", "Greater Frozen Orb", 605, 526 },
                    { 609, "", "Destructive Ice Shards", 608, 527 },
                    { 610, "", "Greater Ice Shards", 608, 527 },
                    { 612, "", "Destructive Chain Lightning", 611, 528 },
                    { 613, "", "Greater Chain Lightning", 611, 528 },
                    { 615, "", "Destructive Charged Bolts", 614, 529 },
                    { 616, "", "Greater Charged Bolts", 614, 529 },
                    { 618, "", "Mystical Flame Shield", 617, 530 },
                    { 619, "", "Shimmering Flame Shield", 617, 530 },
                    { 621, "", "Mystical Frost Nova", 620, 531 },
                    { 622, "", "Shimmering Frost Nova", 620, 531 },
                    { 624, "", "Mystical Ice Armor", 623, 532 },
                    { 625, "", "Shimmering Ice Armor", 623, 532 },
                    { 627, "", "Mystical Teleport", 626, 533 },
                    { 628, "", "Shimmering Teleport", 626, 533 },
                    { 629, "", "Enhanced Familiar", null, 534 },
                    { 632, "", "Enhanced Hydra", null, 535 },
                    { 635, "", "Enhanced Ice Blades", null, 536 },
                    { 638, "", "Enhanced Lightning Spear", null, 537 },
                    { 641, "", "Enhanced Firewall", null, 538 },
                    { 644, "", "Enhanced Meteor", null, 539 },
                    { 647, "", "Enhanced Blizzard", null, 540 },
                    { 650, "", "Enhanced Ball Lightning", null, 541 },
                    { 654, "", "Supreme Inferno", 653, 542 },
                    { 656, "", "Supreme Deep Freeze", 655, 543 },
                    { 658, "", "Supreme Unstable Currents", 657, 544 },
                    { 630, "", "Roaring Familiar", 629, 534 },
                    { 631, "", "Invoked Familar", 629, 534 },
                    { 633, "", "Roaring Hydra", 632, 535 },
                    { 634, "", "Invoked Hydra", 632, 535 },
                    { 636, "", "Roaring Ice Blades", 635, 536 },
                    { 637, "", "Invoked Ice Blades", 635, 536 },
                    { 639, "", "Roaring Lightning Spear", 638, 537 },
                    { 640, "", "Invoke Lightning Spear", 638, 537 },
                    { 642, "", "Mage's Firewall", 641, 538 },
                    { 643, "", "Wizard's Firewall", 641, 538 },
                    { 645, "", "Mage's Meteor", 644, 539 },
                    { 646, "", "Wizard's Meteor", 644, 539 },
                    { 648, "", "Mage's Blizzard", 647, 540 },
                    { 649, "", "Wizard's Blizzard", 647, 540 },
                    { 651, "", "Mage's Ball Lightning", 650, 541 },
                    { 652, "", "Wizard's Ball Lightning", 650, 541 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
