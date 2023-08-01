namespace Lvmendes.Educacional.Comum.Entidades
{
    public class PessoaJuridicaEntidade : IdentificadorEntidade
    {
        public virtual string Nome { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string IE { get; set; }
        public virtual bool Situacao { get; set; }
        public virtual DateTime DataCriacaoEmpresa { get; set; }
        public virtual EnderecoEntidade Endereco { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<TelefoneEntidade> Telefones { get; set; } = new List<TelefoneEntidade>();

    }
}