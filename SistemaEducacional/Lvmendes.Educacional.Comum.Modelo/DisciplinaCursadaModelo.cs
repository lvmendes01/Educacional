using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class DisciplinaCursadaModelo : IdentificadorModelo
    {
        public virtual string NomeDisciplinaCursada { get; set; }
        public DisciplinaCursadaEntidade Transformar(DisciplinaCursadaModelo objeto)
        {

            return new DisciplinaCursadaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
        public DisciplinaCursadaModelo Transformar(DisciplinaCursadaEntidade objeto)
        {

            return new DisciplinaCursadaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
    }
}
