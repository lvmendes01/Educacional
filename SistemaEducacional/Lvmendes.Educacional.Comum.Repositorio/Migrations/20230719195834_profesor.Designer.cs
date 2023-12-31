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
    [Migration("20230719195834_profesor")]
    partial class profesor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CidadeEndereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("EstadoEnderecoId")
                        .HasColumnType("bigint");

                    b.Property<string>("NomeCidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EstadoEnderecoId");

                    b.ToTable("CidadeEndereco");
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

                    b.ToTable("EnderecoEntidade");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EstadoEndereco", b =>
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

                    b.ToTable("EstadoEndereco");
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

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.TelefoneEntidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("ProfessorEntidadeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorEntidadeId");

                    b.ToTable("TelefoneEntidade");
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

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.CidadeEndereco", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EstadoEndereco", null)
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoEnderecoId");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EnderecoEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.CidadeEndereco", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.EstadoEndereco", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Estado");
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

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.TelefoneEntidade", b =>
                {
                    b.HasOne("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", null)
                        .WithMany("Telefones")
                        .HasForeignKey("ProfessorEntidadeId");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.EstadoEndereco", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("Lvmendes.Educacional.Comum.Entidades.ProfessorEntidade", b =>
                {
                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
