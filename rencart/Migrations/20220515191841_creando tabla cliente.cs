using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class creandotablacliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoTarjetaCR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LimiteCredito = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
