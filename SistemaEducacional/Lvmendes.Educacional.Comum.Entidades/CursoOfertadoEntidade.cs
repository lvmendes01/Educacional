using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class CursoOfertadoEntidade : IdentificadorEntidade
    {

        public virtual CursoEntidade Curso { get; set; }
        public virtual ModalidadeEnum Modalidade { get; set; }
        public virtual IList<DisciplinaCursadaEntidade> DisciplinasCurso { get; set; }
        public virtual TurnoEntidade Turno { get; set; }

    }
}
