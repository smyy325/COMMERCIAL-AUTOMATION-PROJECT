﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineTicaret.Models.Siniflar;

namespace OnlineTicaret.Migrations
{
    [DbContext(typeof(ApplicationConnectionDb))]
    [Migration("20231229173712_Db-V4")]
    partial class DbV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("Adminid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAd")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Sifre")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Yetki")
                        .HasColumnType("char(1)")
                        .HasMaxLength(1);

                    b.HasKey("Adminid");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Cari", b =>
                {
                    b.Property<int>("Cariid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CariAd")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("CariMail")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("CariSehir")
                        .HasColumnType("varchar(13) CHARACTER SET utf8mb4")
                        .HasMaxLength(13);

                    b.Property<string>("CariSoyad")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<bool>("Durum")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Cariid");

                    b.ToTable("Caris");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Departman", b =>
                {
                    b.Property<int>("Departmanid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmanAd")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("Durum")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Departmanid");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Detay", b =>
                {
                    b.Property<int>("Detayid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UrunAd")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("UrunBilgi")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Detayid");

                    b.ToTable("Detays");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Fatura", b =>
                {
                    b.Property<int>("FaturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FaturaSeriNo")
                        .HasColumnType("char(1)")
                        .HasMaxLength(1);

                    b.Property<string>("FaturaSiraNo")
                        .HasColumnType("varchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("Saat")
                        .HasColumnType("char(5)")
                        .HasMaxLength(5);

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TeslimAlan")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("TeslimEden")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("Toplam")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("VergiDairesi")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("FaturaID");

                    b.ToTable("Faturas");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.FaturaKalem", b =>
                {
                    b.Property<int>("FaturaKalemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Faturaid")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("FaturaKalemid");

                    b.HasIndex("Faturaid");

                    b.ToTable("FaturaKalems");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Gider", b =>
                {
                    b.Property<int>("Giderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Giderid");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Kategori", b =>
                {
                    b.Property<int>("Kategoriid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KategoriAd")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Kategoriid");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Personel", b =>
                {
                    b.Property<int>("Personelid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Departmanid")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PersonelGorsel")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("PersonelSoyad")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Personelid");

                    b.HasIndex("Departmanid");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.SatisHareket", b =>
                {
                    b.Property<int>("Satisid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("Cariid")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Personelid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Urunid")
                        .HasColumnType("int");

                    b.HasKey("Satisid");

                    b.HasIndex("Cariid");

                    b.HasIndex("Personelid");

                    b.HasIndex("Urunid");

                    b.ToTable("SatisHarekets");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Urun", b =>
                {
                    b.Property<int>("Urunid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("AlisFiyat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Durum")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("KategoriAd")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Kategoriid")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("SatisFiyat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAd")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("UrunGorsel")
                        .HasColumnType("Varchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Urunid");

                    b.HasIndex("Kategoriid");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.FaturaKalem", b =>
                {
                    b.HasOne("OnlineTicaret.Models.Siniflar.Fatura", "Fatura")
                        .WithMany("FaturaKalems")
                        .HasForeignKey("Faturaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Personel", b =>
                {
                    b.HasOne("OnlineTicaret.Models.Siniflar.Departman", "Departman")
                        .WithMany("Employees")
                        .HasForeignKey("Departmanid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.SatisHareket", b =>
                {
                    b.HasOne("OnlineTicaret.Models.Siniflar.Cari", "Cari")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("Cariid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTicaret.Models.Siniflar.Personel", "Personel")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("Personelid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTicaret.Models.Siniflar.Urun", "Urun")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("Urunid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTicaret.Models.Siniflar.Urun", b =>
                {
                    b.HasOne("OnlineTicaret.Models.Siniflar.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("Kategoriid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
