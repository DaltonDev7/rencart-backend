using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class addAtributoConfirmarDevuelto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "confirmarDevolucion",
                table: "RentaDevolucion",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "confirmarDevolucion",
                table: "RentaDevolucion");
        }
    }
}
