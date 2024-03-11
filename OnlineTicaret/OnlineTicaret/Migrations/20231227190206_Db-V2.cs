using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class DbV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CariDurum",
                table: "Caris");

            migrationBuilder.AlterColumn<string>(
                name: "CariSoyad",
                table: "Caris",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "CariSehir",
                table: "Caris",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CariMail",
                table: "Caris",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CariAd",
                table: "Caris",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Caris",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Caris");

            migrationBuilder.AlterColumn<string>(
                name: "CariSoyad",
                table: "Caris",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CariSehir",
                table: "Caris",
                type: "varchar(13)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CariMail",
                table: "Caris",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CariAd",
                table: "Caris",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CariDurum",
                table: "Caris",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
