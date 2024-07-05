using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GaziU.HukukBuroOtomasyonu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DurusmaYeri",
                table: "Durusmalar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurusmaYeri",
                table: "Durusmalar");
        }
    }
}
