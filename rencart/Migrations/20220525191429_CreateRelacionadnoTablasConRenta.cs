using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class CreateRelacionadnoTablasConRenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "RentaDevolucion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "RentaDevolucion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVehiculo",
                table: "RentaDevolucion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_IdCliente",
                table: "RentaDevolucion",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_IdEmpleado",
                table: "RentaDevolucion",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_RentaDevolucion_IdVehiculo",
                table: "RentaDevolucion",
                column: "IdVehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_RentaDevolucion_Clientes_IdCliente",
                table: "RentaDevolucion",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RentaDevolucion_Empleados_IdEmpleado",
                table: "RentaDevolucion",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RentaDevolucion_Vehiculos_IdVehiculo",
                table: "RentaDevolucion",
                column: "IdVehiculo",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentaDevolucion_Clientes_IdCliente",
                table: "RentaDevolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_RentaDevolucion_Empleados_IdEmpleado",
                table: "RentaDevolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_RentaDevolucion_Vehiculos_IdVehiculo",
                table: "RentaDevolucion");

            migrationBuilder.DropIndex(
                name: "IX_RentaDevolucion_IdCliente",
                table: "RentaDevolucion");

            migrationBuilder.DropIndex(
                name: "IX_RentaDevolucion_IdEmpleado",
                table: "RentaDevolucion");

            migrationBuilder.DropIndex(
                name: "IX_RentaDevolucion_IdVehiculo",
                table: "RentaDevolucion");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "RentaDevolucion");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "RentaDevolucion");

            migrationBuilder.DropColumn(
                name: "IdVehiculo",
                table: "RentaDevolucion");
        }
    }
}
