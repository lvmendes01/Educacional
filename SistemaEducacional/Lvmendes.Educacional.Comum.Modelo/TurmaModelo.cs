using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{

    public class TurmaModelo : IdentificadorModelo
    {
        public virtual string NomeTurma { get; set; }
        public TurmaEntidade Transformar(TurmaModelo objeto)
        {

            return new TurmaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomeTurma = objeto.NomeTurma
            };
        }
        public TurmaModelo Transformar(TurmaEntidade objeto)
        {

            return new TurmaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomeTurma = objeto.NomeTurma
            };
        }
    }
}
