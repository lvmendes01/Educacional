using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class PeriodoModelo : IdentificadorModelo
    {
        public virtual string NomePeriodo { get; set; }
        public PeriodoEntidade Transformar(PeriodoModelo objeto)
        {

            return new PeriodoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomePeriodo = objeto.NomePeriodo
            };
        }
        public PeriodoModelo Transformar(PeriodoEntidade objeto)
        {

            return new PeriodoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NomePeriodo = objeto.NomePeriodo
            };
        }
    }
}
