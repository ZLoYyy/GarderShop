using Microsoft.EntityFrameworkCore.Migrations;

namespace GarderShop.Migrations
{
    public partial class UpdateCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryID",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryID",
                table: "Categories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Categories");
        }
    }
}
