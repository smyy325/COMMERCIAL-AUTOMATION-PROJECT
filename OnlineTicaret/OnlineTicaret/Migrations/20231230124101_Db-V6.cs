using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class DbV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CariSifre",
                table: "Caris",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CariSifre",
                table: "Caris");
        }
    }
}
