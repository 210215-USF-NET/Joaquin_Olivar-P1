using Microsoft.EntityFrameworkCore.Migrations;

namespace GRDL.Migrations
{
    public partial class NvmFuqThat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Locations_LocID",
                table: "CartProducts");

            migrationBuilder.DropIndex(
                name: "IX_CartProducts_LocID",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "LocID",
                table: "CartProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocID",
                table: "CartProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_LocID",
                table: "CartProducts",
                column: "LocID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Locations_LocID",
                table: "CartProducts",
                column: "LocID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
