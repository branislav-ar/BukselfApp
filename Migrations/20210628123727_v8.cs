using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatSWE.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ocena",
                table: "Recenzija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Br1",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Br2",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Br3",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Br4",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Br5",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrR",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KnjigaOpis",
                table: "Knjiga",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prosek",
                table: "Knjiga",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ocena",
                table: "Recenzija");

            migrationBuilder.DropColumn(
                name: "Br1",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "Br2",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "Br3",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "Br4",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "Br5",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "BrR",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "KnjigaOpis",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "Prosek",
                table: "Knjiga");
        }
    }
}
