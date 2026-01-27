using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiabloBuildTracker.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedSpiritbornSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 19, "Focus" },
                    { 20, "Potency" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 659, 6, 5, "Rock Splitter", 1, 1 },
                    { 660, 6, 5, "Thunderspike", 1, 1 },
                    { 661, 6, 5, "Thrash", 1, 1 },
                    { 662, 6, 5, "Withering Fist", 1, 1 },
                    { 663, 6, 5, "Crushing Hand", 2, 1 },
                    { 664, 6, 5, "Quill Volley", 2, 1 },
                    { 665, 6, 5, "Rake", 2, 1 },
                    { 666, 6, 5, "Stinger", 2, 1 },
                    { 671, 6, 5, "Armored Hide", 3, 1 },
                    { 672, 6, 5, "Concussive Stomp", 3, 1 },
                    { 673, 6, 5, "Counterattack", 3, 1 },
                    { 674, 6, 5, "Scourge", 3, 1 },
                    { 679, 6, 5, "The Protector", 8, 1 },
                    { 680, 6, 5, "The Seeker", 8, 1 },
                    { 681, 6, 3, "The Hunter", 8, 1 },
                    { 682, 6, 3, "The Devourer", 8, 1 },
                    { 683, 6, 3, "Vigorous", 4, 2 },
                    { 684, 6, 3, "Velocity", 4, 2 },
                    { 685, 6, 3, "Follow Through", 4, 2 },
                    { 686, 6, 3, "Apex", 4, 2 },
                    { 687, 6, 3, "Diminishment", 4, 2 },
                    { 688, 6, 3, "Mirage", 4, 2 },
                    { 689, 6, 3, "Unrestrained Power", 4, 2 },
                    { 690, 6, 3, "Swift", 4, 2 },
                    { 691, 6, 3, "Endurance", 4, 2 },
                    { 692, 6, 3, "Perseverance", 4, 2 },
                    { 693, 6, 3, "Fueld", 4, 2 },
                    { 694, 6, 3, "Patient Guard", 4, 2 },
                    { 695, 6, 3, "Auspicious", 4, 2 },
                    { 696, 6, 3, "Bastion", 4, 2 },
                    { 697, 6, 3, "Antivenom", 4, 2 },
                    { 698, 6, 3, "Nourisment", 4, 2 },
                    { 699, 6, 3, "Resilient", 4, 2 },
                    { 700, 6, 3, "Dominant", 4, 2 },
                    { 701, 6, 3, "Brilliance", 4, 2 },
                    { 702, 6, 3, "Acceleration", 4, 2 },
                    { 703, 6, 3, "Potent", 4, 2 },
                    { 704, 6, 3, "Furnace", 4, 2 },
                    { 705, 6, 3, "Ravenous", 4, 2 },
                    { 706, 6, 3, "Oppressive", 4, 2 },
                    { 707, 6, 3, "Resolution", 4, 2 },
                    { 708, 6, 3, "Spiritual Attunement", 4, 2 },
                    { 709, 6, 3, "Sustenance", 4, 2 },
                    { 710, 6, 3, "Supremacy", 4, 2 },
                    { 711, 6, 3, "Initiative", 4, 2 },
                    { 712, 6, 3, "Intricacy", 4, 2 },
                    { 713, 6, 3, "Vital Strikes", 9, 2 },
                    { 714, 6, 3, "Adaptive Stances", 9, 2 },
                    { 715, 6, 3, "Prodigy's Tempo", 9, 2 },
                    { 716, 6, 3, "Noxious Resonance", 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 717, "", "Enhanced Fire Bolt", null, 659 },
                    { 720, "", "Enhanced Thunderspike", null, 660 },
                    { 723, "", "Enhanced Thrash", null, 661 },
                    { 726, "", "Enhanced Withering Fist", null, 662 },
                    { 729, "", "Enhanced Crushing Hand", null, 663 },
                    { 732, "", "Enhanced Quill Volley", null, 664 },
                    { 735, "", "Enhanced Rake", null, 665 },
                    { 738, "", "Enhanced Stinger", null, 666 },
                    { 753, "", "Enhanced Armored Hide", null, 671 },
                    { 756, "", "Enhanced Concussive Stomp", null, 672 },
                    { 759, "", "Enhanced Counterattack", null, 673 },
                    { 774, "", "Harmonious Protector", null, 679 },
                    { 776, "", "Harmonious Seeker", null, 680 },
                    { 778, "", "Harmonious Hunter", null, 681 },
                    { 780, "", "Harmonious Devourer", null, 682 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ClassId", "MaxRank", "Name", "SkillCategoryId", "SkillType" },
                values: new object[,]
                {
                    { 667, 6, 5, "Vortex", 19, 1 },
                    { 668, 6, 5, "Soar", 19, 1 },
                    { 669, 6, 5, "Ravager", 19, 1 },
                    { 670, 6, 5, "Toxic Skin", 19, 1 },
                    { 675, 6, 5, "Payback", 20, 1 },
                    { 676, 6, 5, "Razor Wings", 20, 1 },
                    { 677, 6, 5, "Rushing Claw", 20, 1 },
                    { 678, 6, 5, "Touch Of Death", 20, 1 }
                });

            migrationBuilder.InsertData(
                table: "SkillUpgrades",
                columns: new[] { "Id", "Description", "Name", "RequiredUpgradeId", "SkillId" },
                values: new object[,]
                {
                    { 718, "", "Accelerated Rock Splitter", 717, 659 },
                    { 719, "", "Sharp Rock Splitter", 717, 659 },
                    { 721, "", "Accelerated Thunderspike", 720, 660 },
                    { 722, "", "Sharp Thunderspike", 720, 660 },
                    { 724, "", "Accelerated Thrash", 723, 661 },
                    { 725, "", "Sharp Thrash", 723, 661 },
                    { 727, "", "Accelerated Withering Fist", 726, 662 },
                    { 728, "", "Sharp Withering Fist", 726, 662 },
                    { 730, "", "Rampant Crushing Hand", 729, 663 },
                    { 731, "", "Advantageous Crushing Hand", 729, 663 },
                    { 733, "", "Rampant Quill Volley", 732, 664 },
                    { 734, "", "Advantageous Quill Volley", 732, 664 },
                    { 736, "", "Rampant Rake", 735, 665 },
                    { 737, "", "Advantageous Rake", 735, 665 },
                    { 739, "", "Rampant Stinger", 738, 666 },
                    { 740, "", "Advantageous Stinger", 738, 666 },
                    { 741, "", "Enhanced Vortex", null, 667 },
                    { 744, "", "Enhanced Soar", null, 668 },
                    { 747, "", "Enhanced Raveager", null, 669 },
                    { 750, "", "Enhanced Toxic Skin", null, 670 },
                    { 754, "", "Adaptable Armor Hide", 753, 671 },
                    { 755, "", "Reinforced Armored Hide", 753, 671 },
                    { 757, "", "Adaptable Concussive Stomp", 756, 672 },
                    { 758, "", "Reinforced Concussive Stomp", 756, 672 },
                    { 760, "", "Adaptable Scourge", 759, 674 },
                    { 761, "", "Reinforced Scourge", 759, 674 },
                    { 762, "", "Enhanced Payback", null, 675 },
                    { 765, "", "Enhanced Razor Wings", null, 676 },
                    { 768, "", "Enhanced Rushing Claw", null, 677 },
                    { 771, "", "Enhanced Touch Of Death", null, 678 },
                    { 775, "", "Exalted Protector", 774, 679 },
                    { 777, "", "Exalted Seeker", 776, 680 },
                    { 779, "", "Exalted Hunter", 778, 681 },
                    { 781, "", "Exalted Devourer", 780, 682 },
                    { 742, "", "Replenishing Vortex", 741, 667 },
                    { 743, "", "Measured Vortex", 741, 667 },
                    { 745, "", "Replenishing Soar", 744, 668 },
                    { 746, "", "Measured Soar", 744, 668 },
                    { 748, "", "Replenishing Ravager", 747, 669 },
                    { 749, "", "Measured Ravager", 747, 669 },
                    { 751, "", "Replenishing Toxic Skin", 750, 670 },
                    { 752, "", "Measured Toxic Skin", 750, 670 },
                    { 763, "", "Poised Payback", 762, 675 },
                    { 764, "", "Invasive Payback", 762, 675 },
                    { 766, "", "Poised Razor Wings", 765, 676 },
                    { 767, "", "Invasive Razor Wings", 765, 676 },
                    { 769, "", "Poised Rushing Claw", 768, 677 },
                    { 770, "", "Invasive Rushing Claw", 768, 677 },
                    { 772, "", "Poised Touch Of Death", 771, 678 },
                    { 773, "", "Invasive Touch Of Death", 771, 678 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "SkillUpgrades",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
