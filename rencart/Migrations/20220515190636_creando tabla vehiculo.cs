using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class creandotablavehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoChasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoMotor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoPlaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
