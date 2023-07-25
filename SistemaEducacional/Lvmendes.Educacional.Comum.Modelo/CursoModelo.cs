using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class CursoModelo : IdentificadorModelo
    {
        public string NomeCurso { get; set; }
        public CursoEntidade Transformar(CursoModelo objeto)
        {

            return new CursoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomeCurso = objeto.NomeCurso,
            };
        }
        public CursoModelo Transformar(CursoEntidade objeto)
        {

            return new CursoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomeCurso = objeto.NomeCurso,
            };
        }
    }
}
