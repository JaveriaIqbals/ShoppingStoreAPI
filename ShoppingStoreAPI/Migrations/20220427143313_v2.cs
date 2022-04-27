using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingStoreAPI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_customers_CustomerCustId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CustomerCustId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CustomerCustId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "ProductProdId",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_ProductProdId",
                table: "customers",
                column: "ProductProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_products_ProductProdId",
                table: "customers",
                column: "ProductProdId",
                principalTable: "products",
                principalColumn: "ProdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_products_ProductProdId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_ProductProdId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "ProductProdId",
                table: "customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerCustId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_CustomerCustId",
                table: "products",
                column: "CustomerCustId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_customers_CustomerCustId",
                table: "products",
                column: "CustomerCustId",
                principalTable: "customers",
                principalColumn: "CustId");
        }
    }
}
