using Microsoft.EntityFrameworkCore.Migrations;

namespace GRDL.Migrations
{
    public partial class FixedLPRefError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationProducts_Records_LocID",
                table: "LocationProducts");

            migrationBuilder.CreateIndex(
                name: "IX_LocationProducts_RecID",
                table: "LocationProducts",
                column: "RecID");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationProducts_Records_RecID",
                table: "LocationProducts",
                column: "RecID",
                principalTable: "Records",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationProducts_Records_RecID",
                table: "LocationProducts");

            migrationBuilder.DropIndex(
                name: "IX_LocationProducts_RecID",
                table: "LocationProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationProducts_Records_LocID",
                table: "LocationProducts",
                column: "LocID",
                principalTable: "Records",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
