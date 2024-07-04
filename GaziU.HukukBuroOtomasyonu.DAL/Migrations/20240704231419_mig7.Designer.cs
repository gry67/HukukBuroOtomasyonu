﻿// <auto-generated />
using System;
using GaziU.HukukBuroOtomasyonu.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GaziU.HukukBuroOtomasyonu.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240704231419_mig7")]
    partial class mig7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.Avukat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TcKimlikNo")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Avukatlar");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.DavaDosyasi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AtananAvukatId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DavaKonusu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Davaci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Davali")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DosyaDurumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DosyaNotu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DosyaNumarasi")
                        .HasColumnType("int");

                    b.Property<int?>("DurusmaId")
                        .HasColumnType("int");

                    b.Property<int>("EsasNumarası")
                        .HasColumnType("int");

                    b.Property<string>("IcraTakipKonusu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("IcraTutari")
                        .HasColumnType("float");

                    b.Property<string>("MahkemeBilgisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AtananAvukatId");

                    b.ToTable("DavaDosyalar");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.Durusma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DavaDosyasiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DurusmaGunu")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DavaDosyasiId");

                    b.ToTable("Durusmalar");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.Mahkeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MahkemeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("YargiTuruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YargiTuruId");

                    b.ToTable("Mahkeme");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.YargiTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("YargiTuruAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YargiTurler");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.DavaDosyasi", b =>
                {
                    b.HasOne("GaziU.HukukBuroOtomasyonu.DAL.Models.Avukat", "AtananAvukat")
                        .WithMany()
                        .HasForeignKey("AtananAvukatId");

                    b.Navigation("AtananAvukat");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.Durusma", b =>
                {
                    b.HasOne("GaziU.HukukBuroOtomasyonu.DAL.Models.DavaDosyasi", "DavaDosyasi")
                        .WithMany("Durusmalar")
                        .HasForeignKey("DavaDosyasiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DavaDosyasi");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.Mahkeme", b =>
                {
                    b.HasOne("GaziU.HukukBuroOtomasyonu.DAL.Models.YargiTuru", "YargiTuru")
                        .WithMany("mahkemeler")
                        .HasForeignKey("YargiTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YargiTuru");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.DavaDosyasi", b =>
                {
                    b.Navigation("Durusmalar");
                });

            modelBuilder.Entity("GaziU.HukukBuroOtomasyonu.DAL.Models.YargiTuru", b =>
                {
                    b.Navigation("mahkemeler");
                });
#pragma warning restore 612, 618
        }
    }
}
