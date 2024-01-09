using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddMonstersToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "ArmorClass", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Name" },
                values: new object[,]
                {
                    { 1, 15, 40, 1, "8d10", 4, 84, "Troll" },
                    { 2, 17, 10, 1, "5d8", 3, 32, "Bronze Dragon Wyrmling" },
                    { 3, 15, 24, 1, "12d10", 4, 90, "Salamander" },
                    { 4, 11, 12, 1, "4d10", 4, 34, "Brown Bear" },
                    { 5, 12, 1, 1, "1d4", 1, 12, "Cat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 5);
        }
    }
}
