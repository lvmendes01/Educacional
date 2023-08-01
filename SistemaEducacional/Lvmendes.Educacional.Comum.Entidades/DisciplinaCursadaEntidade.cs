using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class DisciplinaCursadaEntidade : IdentificadorEntidade
    {
        public virtual DisciplinaEntidade Disciplina { get; set; }
        public virtual PeriodoEntidade Periodo { get; set; }
        public virtual int Frequencia { get; set; }
        public virtual double Av1 { get; set; }
        public virtual double Av2 { get; set; }
        public virtual double Av3 { get; set; }
        public virtual double Av4 { get; set; }
        public virtual double NotaGlobal { get; set; }
        public virtual SituacaoDisciplinaEnum SituacaoDisciplina { get; set; }
        public virtual TurmaEntidade Turma { get; set; }

    }
}
