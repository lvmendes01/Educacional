using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class CidadeModelo : IdentificadorModelo
    {
        public virtual string NomeCidade { get; set; }
        public virtual Int64 EstadoId { get; set; }

        public CidadeEntidade Transformar(CidadeModelo objeto)
        {

            return new CidadeEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                EstadoId = objeto.EstadoId,
                NomeCidade = objeto.NomeCidade,
            };
        }
        public CidadeModelo Transformar(CidadeEntidade objeto)
        {

            return new CidadeModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                EstadoId = objeto.EstadoId,
                NomeCidade = objeto.NomeCidade,
            };
        }

    }
}
  