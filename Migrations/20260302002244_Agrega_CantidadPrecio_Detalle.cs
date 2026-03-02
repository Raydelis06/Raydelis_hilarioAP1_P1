using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Raydelis_HilarioAP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class Agrega_CantidadPrecio_Detalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "EntradasHuacales");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "EntradasHuacales");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "DetallesEntrada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "DetallesEntrada",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "DetallesEntrada");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "DetallesEntrada");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "EntradasHuacales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "EntradasHuacales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
