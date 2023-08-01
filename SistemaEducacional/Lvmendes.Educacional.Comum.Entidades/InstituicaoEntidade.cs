using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class InstituicaoEntidade : PessoaJuridicaEntidade
    {
        public virtual string Natureza { get; set; }
        public virtual IList<InstalacaoEntidade> Filias { get; set; }
        public virtual List<Alvara> Alvara { get; set; }
    }
}
