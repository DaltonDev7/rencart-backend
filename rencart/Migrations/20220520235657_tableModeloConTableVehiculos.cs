using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class tableModeloConTableVehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdModelo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdModelo",
                table: "Vehiculos",
                column: "IdModelo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Modelos_IdModelo",
                table: "Vehiculos",
                column: "IdModelo",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modelos_IdModelo",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_IdModelo",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdModelo",
                table: "Vehiculos");
        }
    }
}
