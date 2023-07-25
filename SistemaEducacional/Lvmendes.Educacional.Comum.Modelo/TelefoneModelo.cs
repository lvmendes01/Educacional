using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class TelefoneModelo : IdentificadorModelo
    {
        public virtual string DDD { get; set; }
        public virtual string Numero { get; set; }
        public TelefoneEntidade Transformar(TelefoneModelo objeto)
        {

            return new TelefoneEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                DDD = objeto.DDD,
                Numero = objeto.Numero,
            };
        }
        public TelefoneModelo Transformar(TelefoneEntidade objeto)
        {

            return new TelefoneModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                DDD = objeto.DDD,
                Numero = objeto.Numero,
            };
        }
    }
}