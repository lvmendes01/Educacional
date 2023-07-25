using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class ProfessorModelo : PessoaFisicaModelo
    {
        public virtual string Matricula { get; set; }
        public ProfessorEntidade Transformar(ProfessorModelo objeto)
        {

            return new ProfessorEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Matricula = objeto.Matricula,
            };
        }
        public ProfessorModelo Transformar(ProfessorEntidade objeto)
        {

            return new ProfessorModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Matricula=objeto.Matricula,
            };
        }
            
    }
}
