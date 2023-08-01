using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class AlunoEntidade : PessoaFisicaEntidade
    {
        public virtual ResponsavelEntidade ResponsavelFinanceiro { get; set; }

        public virtual TipoIngressoEnum TipoIngresso { get; set; }



    }
}
