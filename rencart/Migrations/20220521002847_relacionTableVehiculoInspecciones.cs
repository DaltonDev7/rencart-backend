using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class relacionTableVehiculoInspecciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdVehiculo",
                table: "Inspeccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_IdVehiculo",
                table: "Inspeccion",
                column: "IdVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Vehiculos_IdVehiculo",
                table: "Inspeccion",
                column: "IdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Vehiculos_IdVehiculo",
                table: "Inspeccion");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_IdVehiculo",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "IdVehiculo",
                table: "Inspeccion");
        }
    }
}
