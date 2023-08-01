using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class CursoOfertadoModelo : IdentificadorModelo
    {
        public virtual string NomeCursoOfertado { get; set; }
        public CursoOfertadoEntidade Transformar(CursoOfertadoModelo objeto)
        {

            return new CursoOfertadoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                
                
            };
        }
        public CursoOfertadoModelo Transformar(CursoOfertadoEntidade objeto)
        {

            return new CursoOfertadoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao
            };
        }
    }
}
