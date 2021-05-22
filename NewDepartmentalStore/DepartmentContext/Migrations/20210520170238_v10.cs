using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductContext.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Product_ProductId1",
                table: "ProductSupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Supplier_SupplierId1",
                table: "ProductSupplier");

            migrationBuilder.DropIndex(
                name: "IX_ProductSupplier_ProductId1",
                table: "ProductSupplier");

            migrationBuilder.DropIndex(
                name: "IX_ProductSupplier_SupplierId1",
                table: "ProductSupplier");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "ProductSupplier");

            migrationBuilder.DropColumn(
                name: "SupplierId1",
                table: "ProductSupplier");

            migrationBuilder.AlterColumn<long>(
                name: "SupplierId",
                table: "ProductSupplier",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "ProductSupplier",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_SupplierId",
                table: "ProductSupplier",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Product_ProductId",
                table: "ProductSupplier",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Supplier_SupplierId",
                table: "ProductSupplier",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Product_ProductId",
                table: "ProductSupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Supplier_SupplierId",
                table: "ProductSupplier");

            migrationBuilder.DropIndex(
                name: "IX_ProductSupplier_SupplierId",
                table: "ProductSupplier");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "ProductSupplier",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductSupplier",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ProductId1",
                table: "ProductSupplier",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SupplierId1",
                table: "ProductSupplier",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_ProductId1",
                table: "ProductSupplier",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_SupplierId1",
                table: "ProductSupplier",
                column: "SupplierId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Product_ProductId1",
                table: "ProductSupplier",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Supplier_SupplierId1",
                table: "ProductSupplier",
                column: "SupplierId1",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
