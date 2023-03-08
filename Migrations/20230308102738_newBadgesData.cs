using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YbadgesAPI.Migrations
{
    public partial class newBadgesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                schema: "archi",
                table: "Badge");

            migrationBuilder.DropColumn(
                name: "Obtenu",
                schema: "archi",
                table: "Badge");

            migrationBuilder.CreateTable(
                name: "Obtenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadgeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obtenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obtenu_Badge_BadgeID",
                        column: x => x.BadgeID,
                        principalSchema: "archi",
                        principalTable: "Badge",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Obtenu_BadgeID",
                table: "Obtenu",
                column: "BadgeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obtenu");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                schema: "archi",
                table: "Badge",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Obtenu",
                schema: "archi",
                table: "Badge",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
