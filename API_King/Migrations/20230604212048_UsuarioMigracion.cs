using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_King.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 20, 47, 775, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 6, 4, 16, 20, 47, 775, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 20, 47, 775, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 6, 4, 16, 20, 47, 775, DateTimeKind.Local).AddTicks(440) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 29, 21, 8, 14, 945, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 5, 29, 21, 8, 14, 945, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 29, 21, 8, 14, 945, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 5, 29, 21, 8, 14, 945, DateTimeKind.Local).AddTicks(4734) });
        }
    }
}
