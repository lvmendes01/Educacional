namespace Lvmendes.Educacional.Comum.Entidades
{
    public class CidadeEntidade : IdentificadorEntidade
    {
        public virtual string NomeCidade { get; set; }
        public virtual Int64 EstadoId { get; set; }
    }
}