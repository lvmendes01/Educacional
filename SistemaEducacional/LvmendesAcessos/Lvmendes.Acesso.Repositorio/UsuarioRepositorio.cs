using Lvmendes.Acesso.Entidades;
using Lvmendes.Acesso.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Acesso.Repositorio
{
    public class UsuarioRepositorio : ComumRepositorio<UsuarioEntidade>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(AcessoDBContext _context) : base(_context)
        {
        }

    }
}
