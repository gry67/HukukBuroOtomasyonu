using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziU.HukukBuroOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avukatlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcKimlikNo = table.Column<int>(type: "int", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avukatlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YargiTurler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YargiTuruAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YargiTurler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DavaDosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsasNumarası = table.Column<int>(type: "int", nullable: false),
                    MahkemeBilgisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Davaci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Davali = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaNumarasi = table.Column<int>(type: "int", nullable: false),
                    DavaKonusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IcraTutari = table.Column<double>(type: "float", nullable: false),
                    IcraTakipKonusu = table.Column<double>(type: "float", nullable: false),
                    AtananAvukatId = table.Column<int>(type: "int", nullable: false),
                    MyPropertyId = table.Column<int>(type: "int", nullable: false),
                    DurusmaId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavaDosyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DavaDosyalar_Avukatlar_MyPropertyId",
                        column: x => x.MyPropertyId,
                        principalTable: "Avukatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mahkeme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MahkemeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YargiTuruId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahkeme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahkeme_YargiTurler_YargiTuruId",
                        column: x => x.YargiTuruId,
                        principalTable: "YargiTurler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Durusmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DavaDosyasiId = table.Column<int>(type: "int", nullable: false),
                    DurusmaGunu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durusmalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Durusmalar_DavaDosyalar_DavaDosyasiId",
                        column: x => x.DavaDosyasiId,
                        principalTable: "DavaDosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DavaDosyalar_MyPropertyId",
                table: "DavaDosyalar",
                column: "MyPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Durusmalar_DavaDosyasiId",
                table: "Durusmalar",
                column: "DavaDosyasiId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahkeme_YargiTuruId",
                table: "Mahkeme",
                column: "YargiTuruId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Durusmalar");

            migrationBuilder.DropTable(
                name: "Mahkeme");

            migrationBuilder.DropTable(
                name: "DavaDosyalar");

            migrationBuilder.DropTable(
                name: "YargiTurler");

            migrationBuilder.DropTable(
                name: "Avukatlar");
        }
    }
}
