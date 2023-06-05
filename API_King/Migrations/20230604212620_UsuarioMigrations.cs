using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_King.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 26, 20, 160, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 6, 4, 16, 26, 20, 160, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 26, 20, 160, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 6, 4, 16, 26, 20, 160, DateTimeKind.Local).AddTicks(4236) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

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
    }
}
