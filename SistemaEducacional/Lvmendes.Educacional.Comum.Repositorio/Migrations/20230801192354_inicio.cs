using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConteudosMaterias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCurso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisciplinaNome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estados",
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
                    table.PrimaryKey("PK_Estados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CargaHora = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PeriodoEntidade",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePeriodo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dt_Inico = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Dt_Fim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Dt_Inico_Recup = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Dt_Fim_Recup = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoEntidade", x => x.Id);
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
                name: "Sexos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTurma = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTurno = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoId = table.Column<long>(type: "bigint", nullable: false),
                    EstadoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoEntidadeId",
                        column: x => x.EstadoEntidadeId,
                        principalTable: "Estados",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Enderecos",
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
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enderecos_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Natureza = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situacao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataCriacaoEmpresa = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instituicoes_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
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
                    NomeSocial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    SexoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professores_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Professores_Sexos_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Responsaveis",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeSocial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    SexoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsaveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsaveis_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responsaveis_Sexos_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alvaras",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Imagem = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Datainicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InstituicaoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alvaras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alvaras_Instituicoes_InstituicaoEntidadeId",
                        column: x => x.InstituicaoEntidadeId,
                        principalTable: "Instituicoes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instalacoes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InstituicaoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instalacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instalacoes_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instalacoes_Instituicoes_InstituicaoEntidadeId",
                        column: x => x.InstituicaoEntidadeId,
                        principalTable: "Instituicoes",
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
                        name: "FK_Horarios_Materias_MateriaDisciplinaId",
                        column: x => x.MateriaDisciplinaId,
                        principalTable: "Materias",
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

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResponsavelFinanceiroId = table.Column<long>(type: "bigint", nullable: false),
                    TipoIngresso = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeSocial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false),
                    SexoId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alunos_Responsaveis_ResponsavelFinanceiroId",
                        column: x => x.ResponsavelFinanceiroId,
                        principalTable: "Responsaveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alunos_Sexos_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CursosOfertados",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<long>(type: "bigint", nullable: false),
                    Modalidade = table.Column<int>(type: "int", nullable: false),
                    TurnoId = table.Column<long>(type: "bigint", nullable: false),
                    InstalacaoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosOfertados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursosOfertados_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursosOfertados_Instalacoes_InstalacaoEntidadeId",
                        column: x => x.InstalacaoEntidadeId,
                        principalTable: "Instalacoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CursosOfertados_Turnos_TurnoId",
                        column: x => x.TurnoId,
                        principalTable: "Turnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<long>(type: "bigint", nullable: false),
                    InstalacaoId = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matriculas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Instalacoes_InstalacaoId",
                        column: x => x.InstalacaoId,
                        principalTable: "Instalacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DDD = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AlunoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    InstalacaoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    InstituicaoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    ProfessorEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    ResponsavelEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Alunos_AlunoEntidadeId",
                        column: x => x.AlunoEntidadeId,
                        principalTable: "Alunos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Telefones_Instalacoes_InstalacaoEntidadeId",
                        column: x => x.InstalacaoEntidadeId,
                        principalTable: "Instalacoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Telefones_Instituicoes_InstituicaoEntidadeId",
                        column: x => x.InstituicaoEntidadeId,
                        principalTable: "Instituicoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Telefones_Professores_ProfessorEntidadeId",
                        column: x => x.ProfessorEntidadeId,
                        principalTable: "Professores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Telefones_Responsaveis_ResponsavelEntidadeId",
                        column: x => x.ResponsavelEntidadeId,
                        principalTable: "Responsaveis",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DisciplinasCursadas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisciplinaId = table.Column<long>(type: "bigint", nullable: false),
                    PeriodoId = table.Column<long>(type: "bigint", nullable: false),
                    Frequencia = table.Column<int>(type: "int", nullable: false),
                    Av1 = table.Column<double>(type: "double", nullable: false),
                    Av2 = table.Column<double>(type: "double", nullable: false),
                    Av3 = table.Column<double>(type: "double", nullable: false),
                    Av4 = table.Column<double>(type: "double", nullable: false),
                    NotaGlobal = table.Column<double>(type: "double", nullable: false),
                    SituacaoDisciplina = table.Column<int>(type: "int", nullable: false),
                    TurmaId = table.Column<long>(type: "bigint", nullable: false),
                    CursoOfertadoEntidadeId = table.Column<long>(type: "bigint", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinasCursadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplinasCursadas_CursosOfertados_CursoOfertadoEntidadeId",
                        column: x => x.CursoOfertadoEntidadeId,
                        principalTable: "CursosOfertados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DisciplinasCursadas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplinasCursadas_PeriodoEntidade_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "PeriodoEntidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplinasCursadas_Turmas_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EnderecoId",
                table: "Alunos",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_ResponsavelFinanceiroId",
                table: "Alunos",
                column: "ResponsavelFinanceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_SexoId",
                table: "Alunos",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alvaras_InstituicaoEntidadeId",
                table: "Alvaras",
                column: "InstituicaoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoEntidadeId",
                table: "Cidades",
                column: "EstadoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosOfertados_CursoId",
                table: "CursosOfertados",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosOfertados_InstalacaoEntidadeId",
                table: "CursosOfertados",
                column: "InstalacaoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosOfertados_TurnoId",
                table: "CursosOfertados",
                column: "TurnoId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinasCursadas_CursoOfertadoEntidadeId",
                table: "DisciplinasCursadas",
                column: "CursoOfertadoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinasCursadas_DisciplinaId",
                table: "DisciplinasCursadas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinasCursadas_PeriodoId",
                table: "DisciplinasCursadas",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinasCursadas_TurmaId",
                table: "DisciplinasCursadas",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_CidadeId",
                table: "Enderecos",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_EstadoId",
                table: "Enderecos",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_MateriaDisciplinaId",
                table: "Horarios",
                column: "MateriaDisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_ProfessorAulaId",
                table: "Horarios",
                column: "ProfessorAulaId");

            migrationBuilder.CreateIndex(
                name: "IX_Instalacoes_EnderecoId",
                table: "Instalacoes",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Instalacoes_InstituicaoEntidadeId",
                table: "Instalacoes",
                column: "InstituicaoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicoes_EnderecoId",
                table: "Instituicoes",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AlunoId",
                table: "Matriculas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_InstalacaoId",
                table: "Matriculas",
                column: "InstalacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_EnderecoId",
                table: "Professores",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_SexoId",
                table: "Professores",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsaveis_EnderecoId",
                table: "Responsaveis",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsaveis_SexoId",
                table: "Responsaveis",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_AlunoEntidadeId",
                table: "Telefones",
                column: "AlunoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_InstalacaoEntidadeId",
                table: "Telefones",
                column: "InstalacaoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_InstituicaoEntidadeId",
                table: "Telefones",
                column: "InstituicaoEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ProfessorEntidadeId",
                table: "Telefones",
                column: "ProfessorEntidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ResponsavelEntidadeId",
                table: "Telefones",
                column: "ResponsavelEntidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alvaras");

            migrationBuilder.DropTable(
                name: "ConteudosMaterias");

            migrationBuilder.DropTable(
                name: "DisciplinasCursadas");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "CursosOfertados");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "PeriodoEntidade");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Instalacoes");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Responsaveis");

            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "Sexos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
