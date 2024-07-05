using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziU.HukukBuroOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MahkemeId",
                table: "DavaDosyalar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YargiTuruId",
                table: "DavaDosyalar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DavaDosyalar_MahkemeId",
                table: "DavaDosyalar",
                column: "MahkemeId");

            migrationBuilder.CreateIndex(
                name: "IX_DavaDosyalar_YargiTuruId",
                table: "DavaDosyalar",
                column: "YargiTuruId");

            migrationBuilder.AddForeignKey(
                name: "FK_DavaDosyalar_Mahkeme_MahkemeId",
                table: "DavaDosyalar",
                column: "MahkemeId",
                principalTable: "Mahkeme",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DavaDosyalar_YargiTurler_YargiTuruId",
                table: "DavaDosyalar",
                column: "YargiTuruId",
                principalTable: "YargiTurler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DavaDosyalar_Mahkeme_MahkemeId",
                table: "DavaDosyalar");

            migrationBuilder.DropForeignKey(
                name: "FK_DavaDosyalar_YargiTurler_YargiTuruId",
                table: "DavaDosyalar");

            migrationBuilder.DropIndex(
                name: "IX_DavaDosyalar_MahkemeId",
                table: "DavaDosyalar");

            migrationBuilder.DropIndex(
                name: "IX_DavaDosyalar_YargiTuruId",
                table: "DavaDosyalar");

            migrationBuilder.DropColumn(
                name: "MahkemeId",
                table: "DavaDosyalar");

            migrationBuilder.DropColumn(
                name: "YargiTuruId",
                table: "DavaDosyalar");
        }
    }
}
