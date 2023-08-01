using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class PessoaFisicaModelo : IdentificadorModelo
    {
        public virtual string Nome { get; set; }
        public virtual string Cpf { get; set; }
        public virtual DateTime DataNascimento { get; set; }

        public virtual EnderecoModelo Endereco { get; set; }
        public PessoaFisicaEntidade Transformar(PessoaFisicaModelo objeto)
        {

            return new PessoaFisicaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                
            };
        }
        public PessoaFisicaModelo Transformar(PessoaFisicaEntidade objeto)
        {

            return new PessoaFisicaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cpf = objeto.Cpf,
                DataNascimento = objeto.DataNascimento,
                Endereco = Endereco.Transformar(objeto.Endereco),
            };
        }

    }
}