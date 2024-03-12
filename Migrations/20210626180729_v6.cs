using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatSWE.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrR",
                table: "Korisnik",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrR",
                table: "Korisnik");
        }
    }
}
