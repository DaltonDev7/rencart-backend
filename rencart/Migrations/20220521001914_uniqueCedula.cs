using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class uniqueCedula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Empleados",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Clientes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Cedula",
                table: "Empleados",
                column: "Cedula",
                unique: true,
                filter: "[Cedula] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Cedula",
                table: "Clientes",
                column: "Cedula",
                unique: true,
                filter: "[Cedula] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Empleados_Cedula",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_Cedula",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cedula",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
