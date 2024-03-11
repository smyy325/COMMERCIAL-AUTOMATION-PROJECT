using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class DbV7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ToplamTutar",
                table: "SatisHarekets",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Fiyat",
                table: "SatisHarekets",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ToplamTutar",
                table: "SatisHarekets",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fiyat",
                table: "SatisHarekets",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5);
        }
    }
}
