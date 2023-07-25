using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class HorarioEntidade :IdentificadorEntidade
    {
        public EnumSemana DiaSemana { get; set; }
        public MateriasEntidade MateriaDisciplina { get; set; }
        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFim { get; set; }
        public ProfessorEntidade ProfessorAula { get; set; }


    }
}
