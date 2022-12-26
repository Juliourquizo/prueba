using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FACTURA.Migrations
{
    /// <inheritdoc />
    public partial class AddIdHojaFactura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Linea_HojaFactura_HojaFacturaIdHojaFactura",
                table: "Linea");

            migrationBuilder.RenameColumn(
                name: "HojaFacturaIdHojaFactura",
                table: "Linea",
                newName: "IdHojaFactura");

            migrationBuilder.RenameIndex(
                name: "IX_Linea_HojaFacturaIdHojaFactura",
                table: "Linea",
                newName: "IX_Linea_IdHojaFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_Linea_HojaFactura_IdHojaFactura",
                table: "Linea",
                column: "IdHojaFactura",
                principalTable: "HojaFactura",
                principalColumn: "IdHojaFactura",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Linea_HojaFactura_IdHojaFactura",
                table: "Linea");

            migrationBuilder.RenameColumn(
                name: "IdHojaFactura",
                table: "Linea",
                newName: "HojaFacturaIdHojaFactura");

            migrationBuilder.RenameIndex(
                name: "IX_Linea_IdHojaFactura",
                table: "Linea",
                newName: "IX_Linea_HojaFacturaIdHojaFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_Linea_HojaFactura_HojaFacturaIdHojaFactura",
                table: "Linea",
                column: "HojaFacturaIdHojaFactura",
                principalTable: "HojaFactura",
                principalColumn: "IdHojaFactura",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
