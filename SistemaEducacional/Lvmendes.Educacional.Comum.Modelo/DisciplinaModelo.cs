using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class DisciplinaModelo : IdentificadorModelo
    {
        public virtual string NomeDisciplina { get; set; }
        public DisciplinaEntidade Transformar(DisciplinaModelo objeto)
        {

            return new DisciplinaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
        public DisciplinaModelo Transformar(DisciplinaEntidade objeto)
        {

            return new DisciplinaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
    }
}
