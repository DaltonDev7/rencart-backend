using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class CreateTableinspeccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inspeccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieneRayadura = table.Column<bool>(type: "bit", nullable: false),
                    CantidadCombustible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TieneGomaRepuesto = table.Column<bool>(type: "bit", nullable: false),
                    TieneGato = table.Column<bool>(type: "bit", nullable: false),
                    TieneRoturaCristal = table.Column<bool>(type: "bit", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspeccion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspeccion");
        }
    }
}
