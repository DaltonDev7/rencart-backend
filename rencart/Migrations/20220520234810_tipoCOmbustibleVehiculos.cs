using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class tipoCOmbustibleVehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TipoVehiculo_IdTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoCombustible",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdTipoCombustible",
                table: "Vehiculos",
                column: "IdTipoCombustible");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TipoCombustible_IdTipoCombustible",
                table: "Vehiculos",
                column: "IdTipoCombustible",
                principalTable: "TipoCombustible",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TipoVehiculo_IdTipoVehiculo",
                table: "Vehiculos",
                column: "IdTipoVehiculo",
                principalTable: "TipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TipoCombustible_IdTipoCombustible",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TipoVehiculo_IdTipoVehiculo",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_IdTipoCombustible",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdTipoCombustible",
                table: "Vehiculos");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TipoVehiculo_IdTipoVehiculo",
                table: "Vehiculos",
                column: "IdTipoVehiculo",
                principalTable: "TipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
