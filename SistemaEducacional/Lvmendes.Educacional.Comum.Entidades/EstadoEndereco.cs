namespace Lvmendes.Educacional.Comum.Entidades
{
    public class EstadoEndereco : IdentificadorEntidade
    {
        public virtual string NomeEstado { get; set; }
        public virtual string Sigla { get; set; }
    }
}