using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatSWE.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Recenzija_RecenzijaIDR",
                table: "Korisnik");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_RecenzijaIDR",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "RecenzijaIDR",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "Korisnik",
                newName: "POpis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "POpis",
                table: "Korisnik",
                newName: "Opis");

            migrationBuilder.AddColumn<int>(
                name: "RecenzijaIDR",
                table: "Korisnik",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_RecenzijaIDR",
                table: "Korisnik",
                column: "RecenzijaIDR");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Recenzija_RecenzijaIDR",
                table: "Korisnik",
                column: "RecenzijaIDR",
                principalTable: "Recenzija",
                principalColumn: "IDR",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
