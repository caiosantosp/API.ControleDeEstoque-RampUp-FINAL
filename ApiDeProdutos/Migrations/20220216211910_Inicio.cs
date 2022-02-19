using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiDeProdutos.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalDeCompras",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalDeVendas",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDeCompras",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "TotalDeVendas",
                table: "Produtos");
        }
    }
}
