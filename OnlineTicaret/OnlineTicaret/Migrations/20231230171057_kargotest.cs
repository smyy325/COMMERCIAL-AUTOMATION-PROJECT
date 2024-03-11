using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class kargotest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KargoDetays",
                columns: table => new
                {
                    KargoDetayid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Aciklama = table.Column<string>(type: "Varchar(300)", maxLength: 300, nullable: true),
                    TakipKodu = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: true),
                    Personel = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Alici = table.Column<string>(type: "Varchar(25)", maxLength: 25, nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoDetays", x => x.KargoDetayid);
                });

            migrationBuilder.CreateTable(
                name: "KargoTakips",
                columns: table => new
                {
                    KargoTakipid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TakipKodu = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: true),
                    Aciklama = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    TarihZaman = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KargoTakips", x => x.KargoTakipid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KargoDetays");

            migrationBuilder.DropTable(
                name: "KargoTakips");
        }
    }
}
