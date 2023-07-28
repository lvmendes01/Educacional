using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class PeriodoEntidade : IdentificadorEntidade
    {
        public string NomePeriodo { get; set; }
        public DateTime Dt_Inico { get; set; }
        public DateTime Dt_Fim { get; set; }
        public DateTime Dt_Inico_Recup { get; set; }
        public DateTime Dt_Fim_Recup { get; set; }


    }
}
