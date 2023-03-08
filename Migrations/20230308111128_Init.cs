using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YbadgesAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
               name: "User",
               schema: "archi",
               columns: table => new
               {
                   ID = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Nom = table.Column<string>(maxLength: 150, nullable: false),
                   Prenom = table.Column<string>(maxLength: 150, nullable: false),
                   Email = table.Column<string>(maxLength: 150, nullable: false),
                   MDP = table.Column<string>(maxLength: 150, nullable: false),
                   Classe = table.Column<string>(maxLength: 150, nullable: false),
                   Filiere = table.Column<string>(maxLength: 150, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_User", x => x.ID);
               });

            migrationBuilder.CreateTable(
                name: "Obtenu",
                schema: "archi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IdUser = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obtenu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Badge",
                schema: "archi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LinkImage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LinkOBJ = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LinkMaterial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ObtenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Badge_Obtenu_ObtenuID",
                        column: x => x.ObtenuID,
                        principalSchema: "archi",
                        principalTable: "Obtenu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badge_ObtenuID",
                schema: "archi",
                table: "Badge",
                column: "ObtenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badge",
                schema: "archi");

            migrationBuilder.DropTable(
                name: "Obtenu",
                schema: "archi");

            migrationBuilder.RenameColumn(
                name: "Filiere",
                schema: "archi",
                table: "User",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Classe",
                schema: "archi",
                table: "User",
                newName: "MDPConf");

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "archi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Lieux = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NombreBalise = table.Column<int>(type: "int", nullable: false),
                    NombreCourse = table.Column<int>(type: "int", nullable: false),
                    Reussis = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Time = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Balise",
                schema: "archi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Activation = table.Column<bool>(type: "bit", nullable: false),
                    BonneReponseDonnee = table.Column<bool>(type: "bit", nullable: false),
                    CordonneesX = table.Column<int>(type: "int", nullable: false),
                    CordonneesY = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OrdreBalise = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Reponse1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Reponse2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Reponse3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReponseBonne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balise", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Balise_Course_CourseID",
                        column: x => x.CourseID,
                        principalSchema: "archi",
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Balise_CourseID",
                schema: "archi",
                table: "Balise",
                column: "CourseID");
        }
    }
}
