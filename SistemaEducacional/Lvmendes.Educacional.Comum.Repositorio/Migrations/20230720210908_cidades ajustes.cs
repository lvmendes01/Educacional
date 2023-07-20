using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class cidadesajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Estados_EstadoId",
                table: "Cidades");

            migrationBuilder.DropIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades");

            migrationBuilder.AddColumn<long>(
                name: "EstadoEntidadeId",
                table: "Cidades",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoEntidadeId",
                table: "Cidades",
                column: "EstadoEntidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Estados_EstadoEntidadeId",
                table: "Cidades",
                column: "EstadoEntidadeId",
                principalTable: "Estados",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Estados_EstadoEntidadeId",
                table: "Cidades");

            migrationBuilder.DropIndex(
                name: "IX_Cidades_EstadoEntidadeId",
                table: "Cidades");

            migrationBuilder.DropColumn(
                name: "EstadoEntidadeId",
                table: "Cidades");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoId",
                table: "Cidades",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Estados_EstadoId",
                table: "Cidades",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
