using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pagamentoProduto.Migrations
{
    public partial class CorrecaoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Cliente_ClienteNotaId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Pagamento_PagamentoNotaId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TipoPagamento_TipoPagamentoNotaId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraNotaId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorNotaId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Item_ItemId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Marca_MarcaProdutoId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_ItemId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_MarcaProdutoId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_NotaDeVenda_ClienteNotaId",
                table: "NotaDeVenda");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "MarcaProdutoId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ClienteNotaId",
                table: "NotaDeVenda");

            migrationBuilder.RenameColumn(
                name: "VendedorNotaId",
                table: "NotaDeVenda",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "TransportadoraNotaId",
                table: "NotaDeVenda",
                newName: "TransportadoraId");

            migrationBuilder.RenameColumn(
                name: "TipoPagamentoNotaId",
                table: "NotaDeVenda",
                newName: "TipoPagamentoId");

            migrationBuilder.RenameColumn(
                name: "PagamentoNotaId",
                table: "NotaDeVenda",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_VendedorNotaId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_TransportadoraNotaId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_TransportadoraId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_TipoPagamentoNotaId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_TipoPagamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_PagamentoNotaId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Pagamento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_MarcaId",
                table: "Produto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_NotaDeVendaId",
                table: "Pagamento",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_NotaDeVendaId",
                table: "Item",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ProdutoId",
                table: "Item",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_NotaDeVenda_NotaDeVendaId",
                table: "Item",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Produto_ProdutoId",
                table: "Item",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Cliente_ClienteId",
                table: "NotaDeVenda",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TipoPagamento_TipoPagamentoId",
                table: "NotaDeVenda",
                column: "TipoPagamentoId",
                principalTable: "TipoPagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId",
                principalTable: "Transportadora",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorId",
                table: "NotaDeVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_NotaDeVenda_NotaDeVendaId",
                table: "Pagamento",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Marca_MarcaId",
                table: "Produto",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_NotaDeVenda_NotaDeVendaId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Produto_ProdutoId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Cliente_ClienteId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TipoPagamento_TipoPagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_NotaDeVenda_NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Marca_MarcaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_MarcaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Item_NotaDeVendaId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ProdutoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "NotaDeVenda",
                newName: "VendedorNotaId");

            migrationBuilder.RenameColumn(
                name: "TransportadoraId",
                table: "NotaDeVenda",
                newName: "TransportadoraNotaId");

            migrationBuilder.RenameColumn(
                name: "TipoPagamentoId",
                table: "NotaDeVenda",
                newName: "TipoPagamentoNotaId");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "NotaDeVenda",
                newName: "PagamentoNotaId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_VendedorId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_VendedorNotaId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_TransportadoraId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_TransportadoraNotaId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_TipoPagamentoId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_TipoPagamentoNotaId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_ClienteId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_PagamentoNotaId");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Produto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarcaProdutoId",
                table: "Produto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteNotaId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ItemId",
                table: "Produto",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_MarcaProdutoId",
                table: "Produto",
                column: "MarcaProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDeVenda_ClienteNotaId",
                table: "NotaDeVenda",
                column: "ClienteNotaId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Cliente_ClienteNotaId",
                table: "NotaDeVenda",
                column: "ClienteNotaId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Pagamento_PagamentoNotaId",
                table: "NotaDeVenda",
                column: "PagamentoNotaId",
                principalTable: "Pagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TipoPagamento_TipoPagamentoNotaId",
                table: "NotaDeVenda",
                column: "TipoPagamentoNotaId",
                principalTable: "TipoPagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadora_TransportadoraNotaId",
                table: "NotaDeVenda",
                column: "TransportadoraNotaId",
                principalTable: "Transportadora",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Vendedor_VendedorNotaId",
                table: "NotaDeVenda",
                column: "VendedorNotaId",
                principalTable: "Vendedor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Item_ItemId",
                table: "Produto",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Marca_MarcaProdutoId",
                table: "Produto",
                column: "MarcaProdutoId",
                principalTable: "Marca",
                principalColumn: "Id");
        }
    }
}
