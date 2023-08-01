using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class remover_entidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Sexos_SexoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Sexos_SexoId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsaveis_Sexos_SexoId",
                table: "Responsaveis");

            migrationBuilder.DropTable(
                name: "Sexos");

            migrationBuilder.DropIndex(
                name: "IX_Responsaveis_SexoId",
                table: "Responsaveis");

            migrationBuilder.DropIndex(
                name: "IX_Professores_SexoId",
                table: "Professores");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_SexoId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "SexoId",
                table: "Responsaveis");

            migrationBuilder.DropColumn(
                name: "SexoId",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "SexoId",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Responsaveis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Professores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Responsaveis");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Alunos");

            migrationBuilder.AddColumn<long>(
                name: "SexoId",
                table: "Responsaveis",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SexoId",
                table: "Professores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SexoId",
                table: "Alunos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Sexos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Responsaveis_SexoId",
                table: "Responsaveis",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_SexoId",
                table: "Professores",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_SexoId",
                table: "Alunos",
                column: "SexoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Sexos_SexoId",
                table: "Alunos",
                column: "SexoId",
                principalTable: "Sexos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Sexos_SexoId",
                table: "Professores",
                column: "SexoId",
                principalTable: "Sexos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsaveis_Sexos_SexoId",
                table: "Responsaveis",
                column: "SexoId",
                principalTable: "Sexos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
