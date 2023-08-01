using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class MatriculaModelo : IdentificadorModelo
    {
        public virtual string NomeMatricula { get; set; }
        public MatriculaEntidade Transformar(MatriculaModelo objeto)
        {

            return new MatriculaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
        public MatriculaModelo Transformar(MatriculaEntidade objeto)
        {

            return new MatriculaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
    }
}
