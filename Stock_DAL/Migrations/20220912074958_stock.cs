using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_DAL.Migrations
{
    public partial class stock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_DetailsId",
                table: "product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_Product_DetailsId",
                table: "product",
                column: "Product_DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_Product_Details_Product_DetailsId",
                table: "product",
                column: "Product_DetailsId",
                principalTable: "Product_Details",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_Product_Details_Product_DetailsId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_Product_DetailsId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "Product_DetailsId",
                table: "product");
        }
    }
}
