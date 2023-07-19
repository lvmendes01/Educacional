using Lvmendes.Educacional.Comum.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}