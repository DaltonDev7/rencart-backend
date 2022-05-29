using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class agregandoCantidadDias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadDias",
                table: "RentaDevolucion",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadDias",
                table: "RentaDevolucion");
        }
    }
}
