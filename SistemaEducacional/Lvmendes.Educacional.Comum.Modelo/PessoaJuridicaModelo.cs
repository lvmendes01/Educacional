using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class PessoaJuridicaModelo : IdentificadorModelo
    {
        public virtual string Nome { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string IE { get; set; }
        public virtual bool Situacao { get; set; }
        public virtual DateTime DataCriacaoEmpresa { get; set; }
        public virtual List<Alvara> Alvara { get; set; }
        public virtual EnderecoModelo Endereco { get; set; }
        public PessoaJuridicaEntidade Transformar(PessoaJuridicaModelo objeto)
        {

            return new PessoaJuridicaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                
            };
        }
        public PessoaJuridicaModelo Transformar(PessoaJuridicaEntidade objeto)
        {

            return new PessoaJuridicaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CNPJ = objeto.CNPJ,
                IE = objeto.IE,
                Situacao = objeto.Situacao,
                DataCriacaoEmpresa = objeto.DataCriacaoEmpresa,
                Endereco = Endereco.Transformar(objeto.Endereco),
            };
        }

    }
}