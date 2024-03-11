using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class DbV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KategoriAd",
                table: "Uruns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KategoriAd",
                table: "Uruns");
        }
    }
}
