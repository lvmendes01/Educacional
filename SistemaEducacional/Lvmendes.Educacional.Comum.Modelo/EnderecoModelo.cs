using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class EnderecoModelo : IdentificadorModelo
    {
        public virtual string Logradouro { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual Int64 CidadeId { get; set; }
        public virtual Int64 EstadoId { get; set; }
        public EnderecoEntidade Transformar(EnderecoModelo objeto)
        {

            return new EnderecoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,Cep = objeto.Cep,
                Numero = objeto.Numero, 
                Cidade = new CidadeEntidade { Id = objeto.CidadeId},
                Complemento = objeto.Complemento,
                Estado = new EstadoEntidade { Id= objeto.EstadoId},
                Logradouro = objeto.Logradouro,
                
               
            };
        }
        public EnderecoModelo Transformar(EnderecoEntidade objeto)
        {

            return new EnderecoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cep = objeto.Cep,
                Numero = objeto.Numero,
                CidadeId = objeto.Cidade.Id,
                Complemento = objeto.Complemento,
                EstadoId = objeto.Estado.Id,
                Logradouro = objeto.Logradouro,
            };
        }

    }
}