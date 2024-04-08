using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M20240408AccesoADatos.Migrations
{
    public partial class Acceso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreM = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ApellidoM = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimientoM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusM = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
