using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Repositorio
{
    public class CidadeRepositorio :ComumRepositorio<CidadeEntidade>, ICidadeRepositorio
    {
        ComumBDContext context;
        public CidadeRepositorio(ComumBDContext _context) : base(_context)
        {
            context = _context;
        }

        public CidadeEntidade CarregarCidadePeloId(long id)
        {
            return context.Cidades.SingleOrDefault(s => s.Id == id);
        }

        public EstadoEntidade CarregarEstadoPeloId(long id)
        {
            return context.Estados
                .Include(cid => cid.Cidades)
                .SingleOrDefault(s => s.Id == id);
        }

        public List<CidadeEntidade> ListarCidadesPeloEstado(long Id)
        {
            return context.Cidades.Where(s => s.EstadoId == Id).ToList();
        }

        public List<EstadoEntidade> ListarEstado()
        {
            return context.Estados.ToList();
        }
    }
}
