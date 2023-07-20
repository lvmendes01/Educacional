using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Lvmendes.Educacional.Comum.Servico.Interfaces;

namespace Lvmendes.Educacional.Comum.Servico
{
    public class CidadeServico : ICidadeServico
    {

        private ICidadeRepositorio _repositorio;

        public CidadeServico(ICidadeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public CidadeEntidade CarregarCidadePeloId(long id)
        {
            return _repositorio.CarregarCidadePeloId(id);
        }

        public EstadoEntidade CarregarEstadoPeloId(long id)
        {
            return _repositorio.CarregarEstadoPeloId(id);
        }

        public List<CidadeEntidade> ListarCidadesPeloEstado(long Id)
        {
            return _repositorio.ListarCidadesPeloEstado(Id);
        }

        public List<EstadoEntidade> ListarEstado()
        {
            return _repositorio.ListarEstado();
        }
    }
}
