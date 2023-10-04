using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_aPi.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Name", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa....", new DateTime(2023, 10, 4, 13, 47, 44, 25, DateTimeKind.Local).AddTicks(6982), new DateTime(2023, 10, 4, 13, 47, 44, 25, DateTimeKind.Local).AddTicks(6992), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa....", new DateTime(2023, 10, 4, 13, 47, 44, 25, DateTimeKind.Local).AddTicks(6994), new DateTime(2023, 10, 4, 13, 47, 44, 25, DateTimeKind.Local).AddTicks(6995), "", 30, "Premium vista a la Piscina", 3, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
