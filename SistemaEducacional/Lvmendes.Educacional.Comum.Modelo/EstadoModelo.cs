using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class EstadoModelo : IdentificadorModelo
    {
        public virtual string NomeEstado { get; set; }
        public virtual string Sigla { get; set; }
        public virtual IList<CidadeModelo> Cidades { get; set; }
        public EstadoEntidade Transformar(EstadoModelo objeto)
        {

            return new EstadoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomeEstado = objeto.NomeEstado,
                Sigla = objeto.Sigla,
                Cidades = (IList<CidadeEntidade>)objeto.Cidades
            };
        }
        public EstadoModelo Transformar(EstadoEntidade objeto)
        {

            return new EstadoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomeEstado = objeto.NomeEstado,
                Sigla = objeto.Sigla,
                Cidades = (IList<CidadeModelo>)objeto.Cidades
            };
        }
    }
}