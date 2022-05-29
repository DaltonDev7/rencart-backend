using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class RelacionarTablaMarcaVehiculo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMarca",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdMarca",
                table: "Vehiculos",
                column: "IdMarca");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Marcas_IdMarca",
                table: "Vehiculos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Marcas_IdMarca",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_IdMarca",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdMarca",
                table: "Vehiculos");
        }
    }
}
