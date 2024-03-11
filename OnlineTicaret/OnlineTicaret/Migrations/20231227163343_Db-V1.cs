using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicaret.Migrations
{
    public partial class DbV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Adminid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciAd = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Sifre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Yetki = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Adminid);
                });

            migrationBuilder.CreateTable(
                name: "Caris",
                columns: table => new
                {
                    Cariid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CariAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    CariSoyad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    CariSehir = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: true),
                    CariMail = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    CariDurum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caris", x => x.Cariid);
                });

            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    Departmanid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DepartmanAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Durum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.Departmanid);
                });

            migrationBuilder.CreateTable(
                name: "Detays",
                columns: table => new
                {
                    Detayid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UrunAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    UrunBilgi = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detays", x => x.Detayid);
                });

            migrationBuilder.CreateTable(
                name: "Faturas",
                columns: table => new
                {
                    FaturaID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FaturaSeriNo = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true),
                    FaturaSiraNo = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    VergiDairesi = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    Saat = table.Column<string>(type: "char(5)", maxLength: 5, nullable: true),
                    TeslimEden = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    TeslimAlan = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Toplam = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturas", x => x.FaturaID);
                });

            migrationBuilder.CreateTable(
                name: "Giders",
                columns: table => new
                {
                    Giderid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Aciklama = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Tutar = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giders", x => x.Giderid);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    Kategoriid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KategoriAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.Kategoriid);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Personelid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonelAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PersonelSoyad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PersonelGorsel = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Departmanid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Personelid);
                    table.ForeignKey(
                        name: "FK_Personels_Departmans_Departmanid",
                        column: x => x.Departmanid,
                        principalTable: "Departmans",
                        principalColumn: "Departmanid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaKalems",
                columns: table => new
                {
                    FaturaKalemid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Aciklama = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Miktar = table.Column<int>(nullable: false),
                    BirimFiyat = table.Column<decimal>(nullable: false),
                    Tutar = table.Column<decimal>(nullable: false),
                    Faturaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaKalems", x => x.FaturaKalemid);
                    table.ForeignKey(
                        name: "FK_FaturaKalems_Faturas_Faturaid",
                        column: x => x.Faturaid,
                        principalTable: "Faturas",
                        principalColumn: "FaturaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    Urunid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UrunAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Marka = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Stok = table.Column<short>(nullable: false),
                    AlisFiyat = table.Column<decimal>(nullable: false),
                    SatisFiyat = table.Column<decimal>(nullable: false),
                    Durum = table.Column<bool>(nullable: false),
                    UrunGorsel = table.Column<string>(type: "Varchar(250)", maxLength: 250, nullable: true),
                    Kategoriid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.Urunid);
                    table.ForeignKey(
                        name: "FK_Uruns_Kategoris_Kategoriid",
                        column: x => x.Kategoriid,
                        principalTable: "Kategoris",
                        principalColumn: "Kategoriid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatisHarekets",
                columns: table => new
                {
                    Satisid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Adet = table.Column<int>(nullable: false),
                    Fiyat = table.Column<decimal>(nullable: false),
                    ToplamTutar = table.Column<decimal>(nullable: false),
                    Urunid = table.Column<int>(nullable: false),
                    Cariid = table.Column<int>(nullable: false),
                    Personelid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisHarekets", x => x.Satisid);
                    table.ForeignKey(
                        name: "FK_SatisHarekets_Caris_Cariid",
                        column: x => x.Cariid,
                        principalTable: "Caris",
                        principalColumn: "Cariid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHarekets_Personels_Personelid",
                        column: x => x.Personelid,
                        principalTable: "Personels",
                        principalColumn: "Personelid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisHarekets_Uruns_Urunid",
                        column: x => x.Urunid,
                        principalTable: "Uruns",
                        principalColumn: "Urunid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaturaKalems_Faturaid",
                table: "FaturaKalems",
                column: "Faturaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_Departmanid",
                table: "Personels",
                column: "Departmanid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Cariid",
                table: "SatisHarekets",
                column: "Cariid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Personelid",
                table: "SatisHarekets",
                column: "Personelid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Urunid",
                table: "SatisHarekets",
                column: "Urunid");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_Kategoriid",
                table: "Uruns",
                column: "Kategoriid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Detays");

            migrationBuilder.DropTable(
                name: "FaturaKalems");

            migrationBuilder.DropTable(
                name: "Giders");

            migrationBuilder.DropTable(
                name: "SatisHarekets");

            migrationBuilder.DropTable(
                name: "Faturas");

            migrationBuilder.DropTable(
                name: "Caris");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Uruns");

            migrationBuilder.DropTable(
                name: "Departmans");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
