using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatSWE.Migrations
{
    public partial class LV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pisac",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPrezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDatum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrK = table.Column<int>(type: "int", nullable: false),
                    POpis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PPhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisac", x => x.PID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pisac");
        }
    }
}
