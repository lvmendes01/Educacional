using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class cadastrobase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MateriasEntidade",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfessorTitularId = table.Column<long>(type: "bigint", nullable: false),
                    CargaHora = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriasEntidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MateriasEntidade_Professores_ProfessorTitularId",
                        column: x => x.ProfessorTitularId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroSala = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConteudosMaterias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Conteudo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataPrevista = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataRealizada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Realizada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MateriasEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConteudosMaterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConteudosMaterias_MateriasEntidade_MateriasEntidadeId",
                        column: x => x.MateriasEntidadeId,
                        principalTable: "MateriasEntidade",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiaSemana = table.Column<int>(type: "int", nullable: false),
                    MateriaDisciplinaId = table.Column<long>(type: "bigint", nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    HoraFim = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    ProfessorAulaId = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horarios_MateriasEntidade_MateriaDisciplinaId",
                        column: x => x.MateriaDisciplinaId,
                        principalTable: "MateriasEntidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Horarios_Professores_ProfessorAulaId",
                        column: x => x.ProfessorAulaId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudosMaterias_MateriasEntidadeId",
                table: "ConteudosMaterias",
                column: "MateriasEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_MateriaDisciplinaId",
                table: "Horarios",
                column: "MateriaDisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_ProfessorAulaId",
                table: "Horarios",
                column: "ProfessorAulaId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriasEntidade_ProfessorTitularId",
                table: "MateriasEntidade",
                column: "ProfessorTitularId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConteudosMaterias");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "MateriasEntidade");
        }
    }
}
