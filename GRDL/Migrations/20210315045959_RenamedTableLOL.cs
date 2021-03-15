using Microsoft.EntityFrameworkCore.Migrations;

namespace GRDL.Migrations
{
    public partial class RenamedTableLOL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Locations_LocID",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Records_LocID",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "LocationProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationProducts",
                table: "LocationProducts",
                columns: new[] { "LocID", "RecID" });

            migrationBuilder.AddForeignKey(
                name: "FK_LocationProducts_Locations_LocID",
                table: "LocationProducts",
                column: "LocID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationProducts_Records_LocID",
                table: "LocationProducts",
                column: "LocID",
                principalTable: "Records",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationProducts_Locations_LocID",
                table: "LocationProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationProducts_Records_LocID",
                table: "LocationProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationProducts",
                table: "LocationProducts");

            migrationBuilder.RenameTable(
                name: "LocationProducts",
                newName: "Inventories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                columns: new[] { "LocID", "RecID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Locations_LocID",
                table: "Inventories",
                column: "LocID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Records_LocID",
                table: "Inventories",
                column: "LocID",
                principalTable: "Records",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
