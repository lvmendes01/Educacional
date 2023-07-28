using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class telefone_endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoEntidade_Cidades_CidadeId",
                table: "EnderecoEntidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoEntidade_Estados_EstadoId",
                table: "EnderecoEntidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_EnderecoEntidade_EnderecoId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_TelefoneEntidade_Professores_ProfessorEntidadeId",
                table: "TelefoneEntidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TelefoneEntidade",
                table: "TelefoneEntidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnderecoEntidade",
                table: "EnderecoEntidade");

            migrationBuilder.RenameTable(
                name: "TelefoneEntidade",
                newName: "Telefones");

            migrationBuilder.RenameTable(
                name: "EnderecoEntidade",
                newName: "Enderecos");

            migrationBuilder.RenameIndex(
                name: "IX_TelefoneEntidade_ProfessorEntidadeId",
                table: "Telefones",
                newName: "IX_Telefones_ProfessorEntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoEntidade_EstadoId",
                table: "Enderecos",
                newName: "IX_Enderecos_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_EnderecoEntidade_CidadeId",
                table: "Enderecos",
                newName: "IX_Enderecos_CidadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Cidades_CidadeId",
                table: "Enderecos",
                column: "CidadeId",
                principalTable: "Cidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Estados_EstadoId",
                table: "Enderecos",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Enderecos_EnderecoId",
                table: "Professores",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Professores_ProfessorEntidadeId",
                table: "Telefones",
                column: "ProfessorEntidadeId",
                principalTable: "Professores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Cidades_CidadeId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Estados_EstadoId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Enderecos_EnderecoId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Professores_ProfessorEntidadeId",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "TelefoneEntidade");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "EnderecoEntidade");

            migrationBuilder.RenameIndex(
                name: "IX_Telefones_ProfessorEntidadeId",
                table: "TelefoneEntidade",
                newName: "IX_TelefoneEntidade_ProfessorEntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_EstadoId",
                table: "EnderecoEntidade",
                newName: "IX_EnderecoEntidade_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_CidadeId",
                table: "EnderecoEntidade",
                newName: "IX_EnderecoEntidade_CidadeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TelefoneEntidade",
                table: "TelefoneEntidade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecoEntidade",
                table: "EnderecoEntidade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoEntidade_Cidades_CidadeId",
                table: "EnderecoEntidade",
                column: "CidadeId",
                principalTable: "Cidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoEntidade_Estados_EstadoId",
                table: "EnderecoEntidade",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_EnderecoEntidade_EnderecoId",
                table: "Professores",
                column: "EnderecoId",
                principalTable: "EnderecoEntidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TelefoneEntidade_Professores_ProfessorEntidadeId",
                table: "TelefoneEntidade",
                column: "ProfessorEntidadeId",
                principalTable: "Professores",
                principalColumn: "Id");
        }
    }
}
