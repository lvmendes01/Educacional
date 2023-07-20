using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Servico.Interfaces
{
    public interface ICidadeServico 
    {
        CidadeEntidade CarregarCidadePeloId(Int64 id);
        EstadoEntidade CarregarEstadoPeloId(Int64 id);

        List<CidadeEntidade> ListarCidadesPeloEstado(Int64 Id);

        List<EstadoEntidade> ListarEstado();
    }
}
