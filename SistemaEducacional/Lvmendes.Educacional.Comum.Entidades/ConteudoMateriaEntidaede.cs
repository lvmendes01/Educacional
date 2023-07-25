namespace Lvmendes.Educacional.Comum.Entidades
{
    public class ConteudoMateriaEntidade : IdentificadorEntidade
    {
        public string Conteudo { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataRealizada { get; set; }
        public bool Realizada { get; set; }
    }
}