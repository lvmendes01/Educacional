using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;

namespace Lvmendes.Educacional.Comum.Repositorio
{
    public class SalaRepositorio : ComumRepositorio<SalaEntidade>, ISalaRepositorio
    {
        public SalaRepositorio(ComumBDContext _context) : base(_context)
        {
        }

    }
}
