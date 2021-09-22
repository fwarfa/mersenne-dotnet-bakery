using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_bakery.Migrations
{
    public partial class AddBakedByToBread : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bakedById",
                table: "Breads",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Breads_bakedById",
                table: "Breads",
                column: "bakedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Breads_Bakers_bakedById",
                table: "Breads",
                column: "bakedById",
                principalTable: "Bakers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breads_Bakers_bakedById",
                table: "Breads");

            migrationBuilder.DropIndex(
                name: "IX_Breads_bakedById",
                table: "Breads");

            migrationBuilder.DropColumn(
                name: "bakedById",
                table: "Breads");
        }
    }
}
