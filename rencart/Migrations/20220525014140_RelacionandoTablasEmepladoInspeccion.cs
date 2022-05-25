using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class RelacionandoTablasEmepladoInspeccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Inspeccion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "Inspeccion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "LlantaA",
                table: "Inspeccion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LlantaB",
                table: "Inspeccion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LlantaC",
                table: "Inspeccion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LlantaD",
                table: "Inspeccion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_IdEmpleado",
                table: "Inspeccion",
                column: "IdEmpleado");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Empleados_IdEmpleado",
                table: "Inspeccion",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Empleados_IdEmpleado",
                table: "Inspeccion");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_IdEmpleado",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "LlantaA",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "LlantaB",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "LlantaC",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "LlantaD",
                table: "Inspeccion");
        }
    }
}
