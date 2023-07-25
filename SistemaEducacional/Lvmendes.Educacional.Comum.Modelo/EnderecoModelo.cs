using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class EnderecoModelo : IdentificadorModelo
    {
        public virtual string Logradouro { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual CidadeModelo Cidade { get; set; }
        public virtual EstadoModelo Estado { get; set; }
        public EnderecoEntidade Transformar(EnderecoModelo objeto)
        {

            return new EnderecoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,Cep = objeto.Cep,
                Numero = objeto.Numero, 
                Cidade = Cidade.Transformar(objeto.Cidade),
                Complemento = objeto.Complemento,
                Estado = Estado.Transformar(objeto.Estado),
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
                Cidade = Cidade.Transformar(objeto.Cidade),
                Complemento = objeto.Complemento,
                Estado = Estado.Transformar(objeto.Estado),
                Logradouro = objeto.Logradouro,
            };
        }

    }
}