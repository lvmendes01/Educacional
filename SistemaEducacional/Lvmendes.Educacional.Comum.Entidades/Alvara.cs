namespace Lvmendes.Educacional.Comum.Entidades
{
    public class Alvara : IdentificadorEntidade
    {
        public virtual string Nome { get; set; }
        public virtual string Registro { get; set; }

        public virtual string Imagem { get; set; }

        public virtual DateTime Datainicio { get; set; }
        public virtual DateTime DataFim { get; set; }
    }
}