using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatSWE.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Datum",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drzava",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pol",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecenzijaIDR",
                table: "Korisnik",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zanr",
                table: "Knjiga",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    IDR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDK = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.IDR);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Recenzija_RecenzijaIDR",
                table: "Korisnik");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_RecenzijaIDR",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Datum",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Drzava",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Pol",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "RecenzijaIDR",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Zanr",
                table: "Knjiga");
        }
    }
}
