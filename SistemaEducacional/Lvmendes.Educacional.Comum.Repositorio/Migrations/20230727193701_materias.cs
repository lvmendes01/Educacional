using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class materias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudosMaterias_MateriasEntidade_MateriasEntidadeId",
                table: "ConteudosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_MateriasEntidade_MateriaDisciplinaId",
                table: "Horarios");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriasEntidade_Professores_ProfessorTitularId",
                table: "MateriasEntidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriasEntidade",
                table: "MateriasEntidade");

            migrationBuilder.RenameTable(
                name: "MateriasEntidade",
                newName: "Materias");

            migrationBuilder.RenameIndex(
                name: "IX_MateriasEntidade_ProfessorTitularId",
                table: "Materias",
                newName: "IX_Materias_ProfessorTitularId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materias",
                table: "Materias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudosMaterias_Materias_MateriasEntidadeId",
                table: "ConteudosMaterias",
                column: "MateriasEntidadeId",
                principalTable: "Materias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Materias_MateriaDisciplinaId",
                table: "Horarios",
                column: "MateriaDisciplinaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_ProfessorTitularId",
                table: "Materias",
                column: "ProfessorTitularId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudosMaterias_Materias_MateriasEntidadeId",
                table: "ConteudosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Materias_MateriaDisciplinaId",
                table: "Horarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_ProfessorTitularId",
                table: "Materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materias",
                table: "Materias");

            migrationBuilder.RenameTable(
                name: "Materias",
                newName: "MateriasEntidade");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_ProfessorTitularId",
                table: "MateriasEntidade",
                newName: "IX_MateriasEntidade_ProfessorTitularId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriasEntidade",
                table: "MateriasEntidade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudosMaterias_MateriasEntidade_MateriasEntidadeId",
                table: "ConteudosMaterias",
                column: "MateriasEntidadeId",
                principalTable: "MateriasEntidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_MateriasEntidade_MateriaDisciplinaId",
                table: "Horarios",
                column: "MateriaDisciplinaId",
                principalTable: "MateriasEntidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriasEntidade_Professores_ProfessorTitularId",
                table: "MateriasEntidade",
                column: "ProfessorTitularId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
