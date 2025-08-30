using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoulineWarehouse.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumnsInStockItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockItems_ThreadColors_ThreadColorID",
                table: "StockItems");

            migrationBuilder.RenameColumn(
                name: "ThreadColorID",
                table: "StockItems",
                newName: "ThreadColorId");

            migrationBuilder.RenameColumn(
                name: "Reserved",
                table: "StockItems",
                newName: "ReservedQuantity");

            migrationBuilder.RenameIndex(
                name: "IX_StockItems_ThreadColorID",
                table: "StockItems",
                newName: "IX_StockItems_ThreadColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItems_ThreadColors_ThreadColorId",
                table: "StockItems",
                column: "ThreadColorId",
                principalTable: "ThreadColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockItems_ThreadColors_ThreadColorId",
                table: "StockItems");

            migrationBuilder.RenameColumn(
                name: "ThreadColorId",
                table: "StockItems",
                newName: "ThreadColorID");

            migrationBuilder.RenameColumn(
                name: "ReservedQuantity",
                table: "StockItems",
                newName: "Reserved");

            migrationBuilder.RenameIndex(
                name: "IX_StockItems_ThreadColorId",
                table: "StockItems",
                newName: "IX_StockItems_ThreadColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockItems_ThreadColors_ThreadColorID",
                table: "StockItems",
                column: "ThreadColorID",
                principalTable: "ThreadColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
