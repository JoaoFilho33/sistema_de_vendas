using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pagamentoProduto.Migrations
{
    public partial class PagamentoComCheque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Banco",
                table: "TipoPagamento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeDoBanco",
                table: "TipoPagamento",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Banco",
                table: "TipoPagamento");

            migrationBuilder.DropColumn(
                name: "NomeDoBanco",
                table: "TipoPagamento");
        }
    }
}
