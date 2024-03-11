using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class MD1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mesajlars",
                columns: table => new
                {
                    MesajID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Gonderici = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Alici = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    Konu = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true),
                    icerik = table.Column<string>(type: "Varchar(2000)", maxLength: 2000, nullable: true),
                    Tarih = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesajlars", x => x.MesajID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mesajlars");
        }
    }
}
