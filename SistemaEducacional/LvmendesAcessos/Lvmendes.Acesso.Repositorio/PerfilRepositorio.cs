using Lvmendes.Acesso.Entidades;
using Lvmendes.Acesso.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Acesso.Repositorio
{
    public class PerfilRepositorio : ComumRepositorio<PerfilEntidade>, IPerfilRepositorio
    {
        public PerfilRepositorio(AcessoDBContext _context) : base(_context)
        {
        }

    }
}
