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
        public virtual EnderecoModelo Endereco { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<TelefoneEntidade> Telefones { get; set; } = new List<TelefoneEntidade>();
        public PessoaJuridicaEntidade Transformar(PessoaJuridicaModelo objeto)
        {

            var entidade = new PessoaJuridicaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                IE = objeto.IE,
                Nome = objeto.Nome,
                DataCriacaoEmpresa = objeto.DataCriacaoEmpresa,
                Endereco = Endereco.Transformar(objeto.Endereco),
                CNPJ = objeto.CNPJ,
                Email = objeto.Email,
                Situacao = objeto.Situacao


            };

            foreach (var item in objeto.Telefones)
            {
                entidade.Telefones.Add(new TelefoneEntidade
                {
                    DataCriacao = item.DataCriacao,
                    DDD = item.DDD,
                    Id = item.Id,
                    Numero = item.Numero,

                });
            }

            return entidade;
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