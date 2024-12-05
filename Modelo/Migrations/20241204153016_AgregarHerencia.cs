using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AgregarHerencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFactura_Factura_FacturaId",
                table: "DetalleFactura");

            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                table: "DetalleFactura");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaId",
                table: "DetalleFactura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CUIT",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCliente",
                table: "Cliente",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFactura_Factura_FacturaId",
                table: "DetalleFactura",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFactura_Factura_FacturaId",
                table: "DetalleFactura");

            migrationBuilder.DropColumn(
                name: "CUIT",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "TipoCliente",
                table: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaId",
                table: "DetalleFactura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<float>(
                name: "PrecioUnitario",
                table: "DetalleFactura",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFactura_Factura_FacturaId",
                table: "DetalleFactura",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "Id");
        }
    }
}
