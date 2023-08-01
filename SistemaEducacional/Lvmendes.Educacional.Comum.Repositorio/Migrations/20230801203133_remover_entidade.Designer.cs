﻿// <auto-generated />
using System;
using Lvmendes.Educacional.Comum.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lvmendes.Educacional.Comum.Repositorio.Migrations
{
    [DbContext(typeof(ComumBDContext))]
    [Migration("20230801203133_remover_entidade")]
    partial class remover_entidade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.AlunoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("ResponsavelFinanceiroId")
                        .HasColumnType("bigint");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("TipoIngresso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("ResponsavelFinanceiroId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.Alvara", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Datainicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("InstituicaoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoEntidadeId");

                    b.ToTable("Alvaras");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CidadeEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("EstadoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<long>("EstadoId")
                        .HasColumnType("bigint");

                    b.Property<string>("NomeCidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EstadoEntidadeId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ConteudoMateriaEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPrevista")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataRealizada")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Realizada")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("ConteudosMaterias");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CursoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CursoOfertadoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("CursoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("InstalacaoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<int>("Modalidade")
                        .HasColumnType("int");

                    b.Property<long>("TurnoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("InstalacaoEntidadeId");

                    b.HasIndex("TurnoId");

                    b.ToTable("CursosOfertados");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.DisciplinaCursadaEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<double>("Av1")
                        .HasColumnType("double");

                    b.Property<double>("Av2")
                        .HasColumnType("double");

                    b.Property<double>("Av3")
                        .HasColumnType("double");

                    b.Property<double>("Av4")
                        .HasColumnType("double");

                    b.Property<long?>("CursoOfertadoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DisciplinaId")
                        .HasColumnType("bigint");

                    b.Property<int>("Frequencia")
                        .HasColumnType("int");

                    b.Property<double>("NotaGlobal")
                        .HasColumnType("double");

                    b.Property<long>("PeriodoId")
                        .HasColumnType("bigint");

                    b.Property<int>("SituacaoDisciplina")
                        .HasColumnType("int");

                    b.Property<long>("TurmaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CursoOfertadoEntidadeId");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("PeriodoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("DisciplinasCursadas");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.DisciplinaEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DisciplinaNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("CidadeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("EstadoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EstadoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeEstado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.HorarioEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HoraFim")
                        .HasColumnType("time(6)");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time(6)");

                    b.Property<long>("MateriaDisciplinaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProfessorAulaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MateriaDisciplinaId");

                    b.HasIndex("ProfessorAulaId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.InstalacaoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<long?>("InstituicaoEntidadeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("InstituicaoEntidadeId");

                    b.ToTable("Instalacoes");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.InstituicaoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacaoEmpresa")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<string>("IE")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Natureza")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.MateriasEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("CargaHora")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.MatriculaEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("InstalacaoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("InstalacaoId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.PeriodoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Dt_Fim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Dt_Fim_Recup")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Dt_Inico")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Dt_Inico_Recup")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomePeriodo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PeriodoEntidade");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ResponsavelEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Responsaveis");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.SalaEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumeroSala")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.TelefoneEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("AlunoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("InstalacaoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("InstituicaoEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("ProfessorEntidadeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ResponsavelEntidadeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AlunoEntidadeId");

                    b.HasIndex("InstalacaoEntidadeId");

                    b.HasIndex("InstituicaoEntidadeId");

                    b.HasIndex("ProfessorEntidadeId");

                    b.HasIndex("ResponsavelEntidadeId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.TurmaEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeTurma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.TurnoEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeTurno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.AlunoEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.ResponsavelEntidade", "ResponsavelFinanceiro")
                        .WithMany()
                        .HasForeignKey("ResponsavelFinanceiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("ResponsavelFinanceiro");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.Alvara", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.InstituicaoEntidade", null)
                        .WithMany("Alvara")
                        .HasForeignKey("InstituicaoEntidadeId");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CidadeEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EstadoEntidade", null)
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoEntidadeId");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CursoOfertadoEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.CursoEntidade", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.InstalacaoEntidade", null)
                        .WithMany("Cursos")
                        .HasForeignKey("InstalacaoEntidadeId");

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.TurnoEntidade", "Turno")
                        .WithMany()
                        .HasForeignKey("TurnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.DisciplinaCursadaEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.CursoOfertadoEntidade", null)
                        .WithMany("DisciplinasCurso")
                        .HasForeignKey("CursoOfertadoEntidadeId");

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.DisciplinaEntidade", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.PeriodoEntidade", "Periodo")
                        .WithMany()
                        .HasForeignKey("PeriodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.TurmaEntidade", "Turma")
                        .WithMany()
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("Periodo");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.CidadeEntidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EstadoEntidade", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.HorarioEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.MateriasEntidade", "MateriaDisciplina")
                        .WithMany()
                        .HasForeignKey("MateriaDisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", "ProfessorAula")
                        .WithMany()
                        .HasForeignKey("ProfessorAulaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MateriaDisciplina");

                    b.Navigation("ProfessorAula");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.InstalacaoEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.InstituicaoEntidade", null)
                        .WithMany("Filias")
                        .HasForeignKey("InstituicaoEntidadeId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.InstituicaoEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.MatriculaEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.AlunoEntidade", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.InstalacaoEntidade", "Instalacao")
                        .WithMany()
                        .HasForeignKey("InstalacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Instalacao");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ResponsavelEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.TelefoneEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.AlunoEntidade", null)
                        .WithMany("Telefones")
                        .HasForeignKey("AlunoEntidadeId");

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.InstalacaoEntidade", null)
                        .WithMany("Telefones")
                        .HasForeignKey("InstalacaoEntidadeId");

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.InstituicaoEntidade", null)
                        .WithMany("Telefones")
                        .HasForeignKey("InstituicaoEntidadeId");

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", null)
                        .WithMany("Telefones")
                        .HasForeignKey("ProfessorEntidadeId");

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.ResponsavelEntidade", null)
                        .WithMany("Telefones")
                        .HasForeignKey("ResponsavelEntidadeId");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.AlunoEntidade", b =>
                {
                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CursoOfertadoEntidade", b =>
                {
                    b.Navigation("DisciplinasCurso");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EstadoEntidade", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.InstalacaoEntidade", b =>
                {
                    b.Navigation("Cursos");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.InstituicaoEntidade", b =>
                {
                    b.Navigation("Alvara");

                    b.Navigation("Filias");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", b =>
                {
                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ResponsavelEntidade", b =>
                {
                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
