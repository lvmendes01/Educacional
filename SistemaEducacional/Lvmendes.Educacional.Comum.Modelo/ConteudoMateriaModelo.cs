using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class ConteudoMateriaModelo : IdentificadorModelo
    {
        public string Conteudo { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataRealizada { get; set; }
        public bool Realizada { get; set; }



        public ConteudoMateriaEntidade Transformar(ConteudoMateriaModelo objeto)
        {

            return new ConteudoMateriaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Conteudo = objeto.Conteudo,
                DataPrevista = objeto.DataPrevista, 
                DataRealizada = objeto.DataRealizada,
                Realizada = objeto.Realizada
            };
        }
        public ConteudoMateriaModelo Transformar(ConteudoMateriaEntidade objeto)
        {

            return new ConteudoMateriaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Conteudo = objeto.Conteudo,
                DataPrevista = objeto.DataPrevista,
                DataRealizada = objeto.DataRealizada,
                Realizada = objeto.Realizada
            };
        }
    }
}