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
            var entidade = new ProfessorEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Matricula = objeto.Matricula,
                Cpf = objeto.Cpf,
                Nome = objeto.Nome,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
            };


            foreach (var item in objeto.Telefones)
            {
                entidade.Telefones.Add(new TelefoneEntidade
                {
                    DataCriacao = item.DataCriacao,
                    DDD = item.DDD,
                    Id = item.Id,
                    Numero = item.Numero,

                });
            }

            return entidade;
        }
        public ProfessorModelo Transformar(ProfessorEntidade objeto)
        {

            return new ProfessorModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Matricula=objeto.Matricula,
                Cpf = objeto.Cpf,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
                Telefones = (IList<TelefoneModelo>)objeto.Telefones.ToList()
            };
        }
            
    }
}
