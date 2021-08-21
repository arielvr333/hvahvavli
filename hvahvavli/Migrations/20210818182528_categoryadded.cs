using Microsoft.EntityFrameworkCore.Migrations;

namespace hvahvavli.Migrations
{
    public partial class categoryadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryIdId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryIdId",
                table: "Product",
                column: "categoryIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_categoryIdId",
                table: "Product",
                column: "categoryIdId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_categoryIdId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Product_categoryIdId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "categoryIdId",
                table: "Product");
        }
    }
}
