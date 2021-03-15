using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GRDL.Migrations
{
    public partial class AddedDependencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCoast",
                table: "Orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "OrderProducts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "localName",
                table: "Locations",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Inventories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Carts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "localID",
                table: "Carts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CartProducts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                columns: new[] { "OrdID", "RecID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                columns: new[] { "LocID", "RecID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts",
                columns: new[] { "CartID", "RecID" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LocationID",
                table: "Orders",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_RecID",
                table: "OrderProducts",
                column: "RecID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerID",
                table: "Carts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_LocationID",
                table: "Carts",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_RecID",
                table: "CartProducts",
                column: "RecID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Carts_CartID",
                table: "CartProducts",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Records_RecID",
                table: "CartProducts",
                column: "RecID",
                principalTable: "Records",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Customers_CustomerID",
                table: "Carts",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Locations_LocationID",
                table: "Carts",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrdID",
                table: "OrderProducts",
                column: "OrdID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Records_RecID",
                table: "OrderProducts",
                column: "RecID",
                principalTable: "Records",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Locations_LocationID",
                table: "Orders",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Carts_CartID",
                table: "CartProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Records_RecID",
                table: "CartProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Customers_CustomerID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Locations_LocationID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Locations_LocID",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Records_LocID",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_OrdID",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Records_RecID",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Locations_LocationID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LocationID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderProducts_RecID",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CustomerID",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_LocationID",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts");

            migrationBuilder.DropIndex(
                name: "IX_CartProducts_RecID",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalCoast",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "localName",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "localID",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "OrderProducts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Inventories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CartProducts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
