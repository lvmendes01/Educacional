using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class ProfessorEntidade : PessoaFisicaEntidade
    {
        public virtual string Matricula { get; set; }

    }
}
