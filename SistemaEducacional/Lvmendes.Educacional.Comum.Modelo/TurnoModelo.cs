using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class TurnoModelo : IdentificadorModelo
    {
        public virtual string NomeTurno { get; set; }
        public TurnoEntidade Transformar(TurnoModelo objeto)
        {

            return new TurnoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
        public TurnoModelo Transformar(TurnoEntidade objeto)
        {

            return new TurnoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
    }
}
