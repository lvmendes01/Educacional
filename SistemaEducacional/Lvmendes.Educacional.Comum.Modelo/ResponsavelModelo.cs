using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class ResponsavelModelo : PessoaFisicaModelo
    {
        public virtual Decimal RendaFamiliar { get; set; }
        public ResponsavelEntidade Transformar(ResponsavelModelo objeto)
        {

            var entidade = new ResponsavelEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cpf = objeto.Cpf,
                Nome = objeto.Nome,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
                EstadoCivil = objeto.EstadoCivil,
                NomeSocial = objeto.NomeSocial,
                Sexo = objeto.Sexo,

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
        public ResponsavelModelo Transformar(ResponsavelEntidade objeto)
        {

            var entidade = new ResponsavelModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cpf = objeto.Cpf,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
                EstadoCivil = objeto.EstadoCivil,
                NomeSocial = objeto.NomeSocial,
                Sexo = objeto.Sexo,
            };


            foreach (var item in objeto.Telefones)
            {
                entidade.Telefones.Add(new TelefoneModelo
                {
                    DataCriacao = item.DataCriacao,
                    DDD = item.DDD,
                    Id = item.Id,
                    Numero = item.Numero,

                });
            }

            return entidade;
        }
    }
}
