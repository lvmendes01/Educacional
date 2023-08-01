using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Repositorio
{
    public class TurmaRepositorio : ComumRepositorio<TurmaEntidade>, ITurmaRepositorio
    {
        public TurmaRepositorio(ComumBDContext _context) : base(_context)
        {
        }

    }
}
