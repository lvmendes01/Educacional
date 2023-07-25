using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class MateriasModelo : IdentificadorModelo
    {
        public string Nome { get; set; }
        public ProfessorModelo ProfessorTitular { get; set; }
        public int CargaHora { get; set; }

        public IList<Int64> conteudoMaterias { get; set; }
        public MateriasEntidade Transformar(MateriasModelo objeto)
        {
            var lista = new List<ConteudoMateriaEntidade>();

            objeto.conteudoMaterias.ToList().ForEach(s =>
            {
                lista.Add(new ConteudoMateriaEntidade { Id = s });
            });

            return new MateriasEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CargaHora = objeto.CargaHora,
                conteudoMaterias = lista,
                ProfessorTitular = new ProfessorEntidade { Id=objeto.ProfessorTitular.Id },
            };
        }
        public MateriasModelo Transformar(MateriasEntidade objeto)
        {

            return new MateriasModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CargaHora = objeto.CargaHora,
                conteudoMaterias = objeto.conteudoMaterias.Select(s=>s.Id).ToList(),
                ProfessorTitular = ProfessorTitular.Transformar(objeto.ProfessorTitular),
            };
        }

    }
}
