using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class materia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudosMaterias_Materias_MateriasEntidadeId",
                table: "ConteudosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_ProfessorTitularId",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_ProfessorTitularId",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_ConteudosMaterias_MateriasEntidadeId",
                table: "ConteudosMaterias");

            migrationBuilder.DropColumn(
                name: "ProfessorTitularId",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "MateriasEntidadeId",
                table: "ConteudosMaterias");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProfessorTitularId",
                table: "Materias",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MateriasEntidadeId",
                table: "ConteudosMaterias",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_ProfessorTitularId",
                table: "Materias",
                column: "ProfessorTitularId");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudosMaterias_MateriasEntidadeId",
                table: "ConteudosMaterias",
                column: "MateriasEntidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudosMaterias_Materias_MateriasEntidadeId",
                table: "ConteudosMaterias",
                column: "MateriasEntidadeId",
                principalTable: "Materias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_ProfessorTitularId",
                table: "Materias",
                column: "ProfessorTitularId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
