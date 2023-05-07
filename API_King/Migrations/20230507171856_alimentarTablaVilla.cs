using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_King.Migrations
{
    /// <inheritdoc />
    public partial class alimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa", new DateTime(2023, 5, 7, 12, 18, 56, 627, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 5, 7, 12, 18, 56, 627, DateTimeKind.Local).AddTicks(5404), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Villa Premiun", new DateTime(2023, 5, 7, 12, 18, 56, 627, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 5, 7, 12, 18, 56, 627, DateTimeKind.Local).AddTicks(5448), "", 60, "Villa Live", 10, 500.0 }
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
