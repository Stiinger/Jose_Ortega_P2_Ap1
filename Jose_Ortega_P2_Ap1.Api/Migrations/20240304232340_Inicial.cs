using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jose_Ortega_P2_Ap1.Api.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesorios",
                columns: table => new
                {
                    AccesorioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesorios", x => x.AccesorioId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Gastos = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "VehiculosDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false),
                    AccesorioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Accesorios = table.Column<int>(type: "INTEGER", nullable: true),
                    Vehiculos = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculosDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_VehiculosDetalle_Accesorios_Accesorios",
                        column: x => x.Accesorios,
                        principalTable: "Accesorios",
                        principalColumn: "AccesorioId");
                    table.ForeignKey(
                        name: "FK_VehiculosDetalle_Vehiculos_Vehiculos",
                        column: x => x.Vehiculos,
                        principalTable: "Vehiculos",
                        principalColumn: "VehiculoId");
                });

            migrationBuilder.InsertData(
                table: "Accesorios",
                columns: new[] { "AccesorioId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Camara trasera" },
                    { 2, "Pantalla interior" },
                    { 3, "Interior en piel" },
                    { 4, "Sun Roof" },
                    { 5, "Aros de lujo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalle_Accesorios",
                table: "VehiculosDetalle",
                column: "Accesorios");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosDetalle_Vehiculos",
                table: "VehiculosDetalle",
                column: "Vehiculos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiculosDetalle");

            migrationBuilder.DropTable(
                name: "Accesorios");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
