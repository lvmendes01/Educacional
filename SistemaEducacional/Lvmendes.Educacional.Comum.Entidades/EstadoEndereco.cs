namespace Lvmendes.Educacional.Comum.Entidades
{
    public class EstadoEntidade : IdentificadorEntidade
    {
        public virtual string NomeEstado { get; set; }
        public virtual string Sigla { get; set; }
        public virtual IList<CidadeEntidade> Cidades { get; set; }
    }
}