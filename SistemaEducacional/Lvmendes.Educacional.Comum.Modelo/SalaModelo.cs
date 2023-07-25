using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class SalaModelo: IdentificadorModelo
    {
        public string NumeroSala { get; set; }
        public SalaEntidade Transformar(SalaModelo objeto)
        {

            return new SalaEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NumeroSala=objeto.NumeroSala,
            };
        }
        public SalaModelo Transformar(SalaEntidade objeto)
        {

            return new SalaModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                NumeroSala = objeto.NumeroSala,
            };
        }

    }
}
