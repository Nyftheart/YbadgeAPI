using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YbadgesAPI.Migrations
{
    public partial class filiere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Classe",
                schema: "archi",
                table: "User",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Filiere",
                schema: "archi",
                table: "User",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classe",
                schema: "archi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Filiere",
                schema: "archi",
                table: "User");
        }
    }
}
