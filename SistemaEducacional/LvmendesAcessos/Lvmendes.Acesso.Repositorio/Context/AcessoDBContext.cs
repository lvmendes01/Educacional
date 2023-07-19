
using Lvmendes.Acesso.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Acesso.Repositorio
{
    public class AcessoDBContext : DbContext
    {

        public AcessoDBContext(DbContextOptions<AcessoDBContext> options) : base(options)
        {

        }

        public DbSet<PerfilEntidade> Perfis { get; set; }
        public DbSet<PermissaoEntidade> Permissoes { get; set; }
        public DbSet<UsuarioEntidade> Usuarios { get; set; }


    }
}