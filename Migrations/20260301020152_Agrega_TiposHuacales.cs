using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Raydelis_HilarioAP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class Agrega_TiposHuacales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesEntrada",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEntrada = table.Column<int>(type: "int", nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesEntrada", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_DetallesEntrada_EntradasHuacales_IdEntrada",
                        column: x => x.IdEntrada,
                        principalTable: "EntradasHuacales",
                        principalColumn: "IdEntrada",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposHuacales",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposHuacales", x => x.TipoId);
                });

            migrationBuilder.InsertData(
                table: "TiposHuacales",
                columns: new[] { "TipoId", "Descripcion", "Existencia" },
                values: new object[,]
                {
                    { 1, "Rojo", 0 },
                    { 2, "Verde", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntrada_IdEntrada",
                table: "DetallesEntrada",
                column: "IdEntrada");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesEntrada");

            migrationBuilder.DropTable(
                name: "TiposHuacales");
        }
    }
}
