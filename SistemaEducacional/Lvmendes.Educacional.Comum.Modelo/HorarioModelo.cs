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
        public Int64 MateriaDisciplinaId { get; set; }
        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFim { get; set; }
        public Int64 ProfessorAulaId { get; set; }
        public HorarioEntidade Transformar(HorarioModelo objeto)
        {

            return new HorarioEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                DiaSemana = (EnumSemana)objeto.DiaSemana,
                HoraFim = objeto.HoraFim,
                HoraInicio = objeto.HoraInicio,
                MateriaDisciplina = new MateriasEntidade { Id = objeto.MateriaDisciplinaId },
                ProfessorAula = new ProfessorEntidade { Id = objeto.ProfessorAulaId }
                
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
                MateriaDisciplinaId = objeto.MateriaDisciplina.Id,
                ProfessorAulaId =  objeto.ProfessorAula.Id
            };
        }


    }
}
