using Microsoft.EntityFrameworkCore.Migrations;

namespace GRDL.Migrations
{
    public partial class SeedDataTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "daFormat",
                table: "Records",
                newName: "DaFormat");

            migrationBuilder.RenameColumn(
                name: "daCondition",
                table: "Records",
                newName: "DaCondition");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Records",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "ID", "Artist", "DaCondition", "DaFormat", "GenreType", "Price", "RecordName" },
                values: new object[] { 1000, "Noname", 1, 1, 1, 249.99m, "Telefone" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "ID",
                keyValue: 1000);

            migrationBuilder.RenameColumn(
                name: "DaFormat",
                table: "Records",
                newName: "daFormat");

            migrationBuilder.RenameColumn(
                name: "DaCondition",
                table: "Records",
                newName: "daCondition");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Records",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }
    }
}
