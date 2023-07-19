using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class profesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoEndereco",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeEstado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sigla = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoEndereco", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CidadeEndereco",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoEnderecoId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CidadeEndereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CidadeEndereco_EstadoEndereco_EstadoEnderecoId",
                        column: x => x.EstadoEnderecoId,
                        principalTable: "EstadoEndereco",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EnderecoEntidade",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CidadeId = table.Column<long>(type: "bigint", nullable: false),
                    EstadoId = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEntidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecoEntidade_CidadeEndereco_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "CidadeEndereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnderecoEntidade_EstadoEndereco_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoEndereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professores_EnderecoEntidade_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "EnderecoEntidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TelefoneEntidade",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DDD = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfessorEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefoneEntidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefoneEntidade_Professores_ProfessorEntidadeId",
                        column: x => x.ProfessorEntidadeId,
                        principalTable: "Professores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CidadeEndereco_EstadoEnderecoId",
                table: "CidadeEndereco",
                column: "EstadoEnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntidade_CidadeId",
                table: "EnderecoEntidade",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEntidade_EstadoId",
                table: "EnderecoEntidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_EnderecoId",
                table: "Professores",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneEntidade_ProfessorEntidadeId",
                table: "TelefoneEntidade",
                column: "ProfessorEntidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelefoneEntidade");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "EnderecoEntidade");

            migrationBuilder.DropTable(
                name: "CidadeEndereco");

            migrationBuilder.DropTable(
                name: "EstadoEndereco");
        }
    }
}
