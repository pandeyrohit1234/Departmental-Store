using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProductContext.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    ProductCode = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    ManuFacturer = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CostPrice = table.Column<decimal>(type: "numeric", maxLength: 6, nullable: false),
                    SellingPrice = table.Column<decimal>(type: "numeric", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
