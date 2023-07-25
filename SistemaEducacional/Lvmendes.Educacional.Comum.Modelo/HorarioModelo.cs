using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class HorarioModelo :IdentificadorModelo
    {
        public int DiaSemana { get; set; }
        public MateriasModelo MateriaDisciplina { get; set; }
        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFim { get; set; }
        public ProfessorModelo ProfessorAula { get; set; }
        public HorarioEntidade Transformar(HorarioModelo objeto)
        {

            return new HorarioEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                DiaSemana = (EnumSemana) objeto.DiaSemana,
                HoraFim= objeto.HoraFim,
                HoraInicio = objeto.HoraInicio,
                MateriaDisciplina = MateriaDisciplina.Transformar(objeto.MateriaDisciplina),
                ProfessorAula = ProfessorAula.Transformar(objeto.ProfessorAula),
                
            };
        }
        public HorarioModelo Transformar(HorarioEntidade objeto)
        {

            return new HorarioModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                DiaSemana = (int) objeto.DiaSemana,
                HoraFim= objeto.HoraFim,
                HoraInicio = objeto.HoraInicio,
                MateriaDisciplina = MateriaDisciplina.Transformar(objeto.MateriaDisciplina),
                ProfessorAula = ProfessorAula.Transformar(objeto.ProfessorAula),
            };
        }


    }
}
