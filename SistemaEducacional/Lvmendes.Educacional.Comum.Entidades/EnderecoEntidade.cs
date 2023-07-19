namespace Lvmendes.Educacional.Comum.Entidades
{
    public class EnderecoEntidade : IdentificadorEntidade
    {
        public virtual string Logradouro { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual CidadeEndereco Cidade { get; set; }
        public virtual EstadoEndereco Estado { get; set; }

    }
}