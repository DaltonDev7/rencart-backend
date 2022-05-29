using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class RelacionandOtABLETipoVehiculosConVehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdTipoVehiculo",
                table: "Vehiculos",
                column: "IdTipoVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TipoVehiculo_IdTipoVehiculo",
                table: "Vehiculos",
                column: "IdTipoVehiculo",
                principalTable: "TipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TipoVehiculo_IdTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_IdTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdTipoVehiculo",
                table: "Vehiculos");
        }
    }
}
