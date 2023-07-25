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


    }
}