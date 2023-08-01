using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Repositorio
{
    public class ComumBDContext : DbContext
    {

        public ComumBDContext(DbContextOptions<ComumBDContext> options) : base(options)
        {
         
        }

        public DbSet<CursoEntidade> Cursos { get; set; }
        public DbSet<TurnoEntidade> Turnos { get; set; }
        public DbSet<ProfessorEntidade> Professores { get; set; }
        public DbSet<CidadeEntidade> Cidades { get; set; }
        public DbSet<EstadoEntidade> Estados { get; set; }
        public DbSet<SalaEntidade> Salas { get; set; }
        public DbSet<ConteudoMateriaEntidade> ConteudosMaterias { get; set; }
        public DbSet<HorarioEntidade> Horarios { get; set; }
        public DbSet<MateriasEntidade> Materias { get; set; }
        public DbSet<EnderecoEntidade> Enderecos { get; set; }
        public DbSet<TelefoneEntidade> Telefones { get; set; }
        public DbSet<AlunoEntidade> Alunos { get; set; }
        public DbSet<Alvara> Alvaras { get; set; }
        public DbSet<CursoOfertadoEntidade> CursosOfertados { get; set; }
        public DbSet<DisciplinaCursadaEntidade> DisciplinasCursadas { get; set; }
        public DbSet<DisciplinaEntidade> Disciplinas { get; set; }
        public DbSet<InstalacaoEntidade> Instalacoes { get; set; }
        public DbSet<InstituicaoEntidade> Instituicoes { get; set; }
        public DbSet<MatriculaEntidade> Matriculas { get; set; }
        public DbSet<ResponsavelEntidade> Responsaveis { get; set; }
        public DbSet<TurmaEntidade> Turmas { get; set; }


    }
}