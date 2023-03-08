using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YbadgesAPI.Migrations
{
    public partial class badgesmodif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categorie",
                schema: "archi",
                table: "Badge",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkMaterial",
                schema: "archi",
                table: "Badge",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkOBJ",
                schema: "archi",
                table: "Badge",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categorie",
                schema: "archi",
                table: "Badge");

            migrationBuilder.DropColumn(
                name: "LinkMaterial",
                schema: "archi",
                table: "Badge");

            migrationBuilder.DropColumn(
                name: "LinkOBJ",
                schema: "archi",
                table: "Badge");
        }
    }
}
