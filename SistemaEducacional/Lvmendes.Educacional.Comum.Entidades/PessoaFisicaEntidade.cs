namespace Lvmendes.Educacional.Comum.Entidades
{
    public class PessoaFisicaEntidade : IdentificadorEntidade
    {
        public virtual string Nome { get; set; }
        public virtual string NomeSocial { get; set; }
        public virtual string Cpf { get; set; }
        public virtual DateTime DataNascimento { get; set; }

        public virtual EstadoCivilEnum EstadoCivil { get; set; }
        public virtual EnderecoEntidade Endereco { get; set; }
        public virtual SexoEnumerado Sexo { get; set; }

        public virtual string Email { get; set; }
        public virtual IList<TelefoneEntidade> Telefones { get; set; } = new List<TelefoneEntidade>();
    }
}