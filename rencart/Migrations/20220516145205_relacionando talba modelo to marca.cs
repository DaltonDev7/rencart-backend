using Microsoft.EntityFrameworkCore.Migrations;

namespace rencart.Migrations
{
    public partial class relacionandotalbamodelotomarca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMarca",
                table: "Modelos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_IdMarca",
                table: "Modelos",
                column: "IdMarca");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Marcas_IdMarca",
                table: "Modelos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Marcas_IdMarca",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_IdMarca",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "IdMarca",
                table: "Modelos");
        }
    }
}
