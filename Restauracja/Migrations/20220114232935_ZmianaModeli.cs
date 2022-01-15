using Microsoft.EntityFrameworkCore.Migrations;

namespace Restauracja.Migrations
{
    public partial class ZmianaModeli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KategoriaPozycji",
                table: "PozycjeZamowienia");

            migrationBuilder.AddColumn<decimal>(
                name: "Cena",
                table: "Zamowienie_PozycjaZamowienia",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Zamowienie_PozycjaZamowienia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Liczba",
                table: "Zamowienie_PozycjaZamowienia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "PozycjeZamowienia",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Zamowienie_PozycjaZamowienia");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Zamowienie_PozycjaZamowienia");

            migrationBuilder.DropColumn(
                name: "Liczba",
                table: "Zamowienie_PozycjaZamowienia");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "PozycjeZamowienia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "KategoriaPozycji",
                table: "PozycjeZamowienia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
