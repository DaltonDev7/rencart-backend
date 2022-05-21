using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class relacionClienteInspecciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Inspeccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_IdCliente",
                table: "Inspeccion",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Clientes_IdCliente",
                table: "Inspeccion",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Clientes_IdCliente",
                table: "Inspeccion");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_IdCliente",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Inspeccion");
        }
    }
}
