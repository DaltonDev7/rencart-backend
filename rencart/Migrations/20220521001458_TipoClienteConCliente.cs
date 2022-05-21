using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class TipoClienteConCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoPersona",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdTipoPersona",
                table: "Clientes",
                column: "IdTipoPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TipoPersona_IdTipoPersona",
                table: "Clientes",
                column: "IdTipoPersona",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TipoPersona_IdTipoPersona",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdTipoPersona",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdTipoPersona",
                table: "Clientes");
        }
    }
}
