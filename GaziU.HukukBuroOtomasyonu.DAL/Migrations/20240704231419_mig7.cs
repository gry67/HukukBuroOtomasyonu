using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziU.HukukBuroOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DavaDosyalar_Avukatlar_MyPropertyId",
                table: "DavaDosyalar");

            migrationBuilder.DropIndex(
                name: "IX_DavaDosyalar_MyPropertyId",
                table: "DavaDosyalar");

            migrationBuilder.DropColumn(
                name: "MyPropertyId",
                table: "DavaDosyalar");

            migrationBuilder.CreateIndex(
                name: "IX_DavaDosyalar_AtananAvukatId",
                table: "DavaDosyalar",
                column: "AtananAvukatId");

            migrationBuilder.AddForeignKey(
                name: "FK_DavaDosyalar_Avukatlar_AtananAvukatId",
                table: "DavaDosyalar",
                column: "AtananAvukatId",
                principalTable: "Avukatlar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DavaDosyalar_Avukatlar_AtananAvukatId",
                table: "DavaDosyalar");

            migrationBuilder.DropIndex(
                name: "IX_DavaDosyalar_AtananAvukatId",
                table: "DavaDosyalar");

            migrationBuilder.AddColumn<int>(
                name: "MyPropertyId",
                table: "DavaDosyalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DavaDosyalar_MyPropertyId",
                table: "DavaDosyalar",
                column: "MyPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_DavaDosyalar_Avukatlar_MyPropertyId",
                table: "DavaDosyalar",
                column: "MyPropertyId",
                principalTable: "Avukatlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
